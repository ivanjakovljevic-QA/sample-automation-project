using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using NUnit.Framework;
using realworld.main.proxy;
using realworld.main.rest.data;
using realworld.main.storage;
using static realworld.main.storage.StorageSingleton;
using Assert = NUnit.Framework.Assert;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.test.stepdef
{

    public class UserStepDefinition
    {
        UserProxy userProxy = new UserProxy();

        System.Random random = new System.Random();

        /**
         * Method used for user creation 
         */
        public void createNewUser()
        {

            UserEntity user = new UserEntity();

            int randomUserNumber = random.Next(10000000, 99999999);

            //Set new user data
            user.Username = "wolf" + randomUserNumber;
            user.Email = "wolf" + randomUserNumber + "@wolf.com";
            user.Password = "wolftester123";

            //Add new user data to storage singleton
            storageData().AddUser(user);

            //Register user and retrive register response data
            UserResponseDSO userResponse = userProxy.userRegister(user);

            //User register validations
            Assert.That(userResponse.User.Email, Is.EqualTo(user.Email));
            Assert.That(userResponse.User.Username, Is.EqualTo(user.Username));
            Assert.That(userResponse.User.Token, Is.Not.Null);

            Logger.LogMessage("User with username: {0} was successfully created!", user.Username);

        }

        /**
         * Method used for user login in order to retrive authorization token
         * Token is added to storage for later use within other method
         */
        public void userLogin()
        {
            UserEntity user = storageData().User;

            //Login and retrive login response data
            UserResponseDSO userResponse = userProxy.userLogin(user);

            //User login validations
            Assert.That(userResponse.User.Email, Is.EqualTo(user.Email));
            Assert.That(userResponse.User.Username, Is.EqualTo(user.Username));
            Assert.That(userResponse.User.Token, Is.Not.Null);

            Logger.LogMessage("User with username: {0} has successfully logged in!", user.Username);
        }

    }
}
