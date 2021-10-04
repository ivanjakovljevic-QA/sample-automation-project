using realworld.main.rest.data;
using realworld.main.storage;
using realworld.main.rest;
using RestSharp;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.proxy
{
    public class UserProxy
    {
        UserRestClient userRegisterRestClient = new UserRestClient();

        /*
         * Method for triggering register request
         */
        public UserResponseDSO userRegister(UserEntity userEntity)
        {

            UserRegisterRequestDSO userRequestBody = new UserRegisterRequestDSO();

            UserRegisterRequestBodyDSO user = userRequestBody.User;

            user.Email = userEntity.Email;
            user.Username = userEntity.Username;
            user.Password = userEntity.Password;

            //User register response
            IRestResponse response = userRegisterRestClient.registerUser(userRequestBody);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ArgumentException("User registration was unsuccessful");
            }

            UserResponseDSO userRegisterResponse = JsonConvert.DeserializeObject<UserResponseDSO>(response.Content);

            return userRegisterResponse;

        }

        /**
         * Method for triggering login request
         */
        public UserResponseDSO userLogin(UserEntity userEntity)
        {

            UserLoginRequestDSO userRequestBody = new UserLoginRequestDSO();

            UserLoginRequestBodyDSO user = userRequestBody.User;

            user.Email = userEntity.Email;
            user.Password = userEntity.Password;

            //User login response
            IRestResponse response = userRegisterRestClient.userLogin(userRequestBody);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ArgumentException("User login was unsuccessful");
            }

            UserResponseDSO userLoginResponse = JsonConvert.DeserializeObject<UserResponseDSO>(response.Content);

            userEntity.Token = userLoginResponse.User.Token;

            return userLoginResponse;

        }

    }
}
