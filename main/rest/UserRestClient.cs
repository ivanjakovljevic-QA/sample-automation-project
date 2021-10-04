using realworld.main.rest.data;
using RestSharp;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest
{
    public class UserRestClient
    {
        private static RestClient client = new RestClient("https://conduit.productionready.io/api/users");

        /*
         * User register request
         */
        public IRestResponse registerUser(UserRegisterRequestDSO userRequestBody)
        {

            RestRequest request = new RestRequest("", Method.POST);
            request.AddJsonBody(userRequestBody);
            IRestResponse response = client.Execute(request);

            return response;

        }

        /*
         * User login request
         */
        public IRestResponse userLogin(UserLoginRequestDSO userRequestBody)
        {

            RestRequest request = new RestRequest("/login", Method.POST);
            request.AddJsonBody(userRequestBody);
            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}
