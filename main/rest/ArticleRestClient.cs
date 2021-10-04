using realworld.main.rest.data;
using realworld.main.storage;
using RestSharp;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest
{
    class ArticleRestClient
    {

        private static RestClient client = new RestClient("https://conduit.productionready.io/api/articles/");

        /*
         * Create article request
         */
        public IRestResponse createArticle(ArticleRequestDSO articleRequestBody, UserEntity user)
        {

            RestRequest request = new RestRequest("", Method.POST);
            request.AddJsonBody(articleRequestBody);
            request.AddHeader("Authorization", "Token " + user.Token);
            IRestResponse response = client.Execute(request);

            return response;

        }

        /*
         * Add comment request
         */
        public IRestResponse addComment(CommentRequestDSO commentRequest, UserEntity user, ArticleEntity article)
        {

            RestRequest request = new RestRequest(article.Slug + "/comments", Method.POST);
            request.AddJsonBody(commentRequest);
            request.AddHeader("Authorization", "Token " + user.Token);
            IRestResponse response = client.Execute(request);

            return response;

        }
    }
}
