using Newtonsoft.Json;
using realworld.main.rest;
using realworld.main.rest.data;
using realworld.main.storage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

using static realworld.main.storage.StorageSingleton;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.proxy
{
    public class ArticleProxy
    {

        ArticleRestClient articleRestClient = new ArticleRestClient();

        /*
         * Method for triggering article creation request
         */
        public ArticleResponseDSO createArticle()
        {

            UserEntity userEntity = storageData().User;

            ArticleEntity articleEntity = storageData().Article;

            ArticleRequestDSO articleRequestBody = new ArticleRequestDSO();

            ArticleRequestBodyDSO article = articleRequestBody.Article;

            article.Description = articleEntity.Description;
            article.Body = articleEntity.Body;
            article.Title = articleEntity.Title;

            IRestResponse response = articleRestClient.createArticle(articleRequestBody, userEntity);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ArgumentException("Creation of new article was unsuccessful");
            }

            ArticleResponseDSO articleResponse = JsonConvert.DeserializeObject<ArticleResponseDSO>(response.Content);

            articleEntity.Slug = articleResponse.Article.Slug;

            return articleResponse;
        }

        /*
         * Method for triggering comment creation request
         */
        public CommentResponseDSO addCommentToArticle(UserEntity user)
        {

            ArticleEntity articleEntity = storageData().Article;

            CommentRequestDSO commentRequestBody = new CommentRequestDSO();

            CommentRequestBodyDSO comment = commentRequestBody.Comment;

            comment.Body = "AutoTestComment";

            IRestResponse response = articleRestClient.addComment(commentRequestBody, user, articleEntity);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ArgumentException("Adding comment to newly created article was unsuccessful");
            }

            CommentResponseDSO commentResponse = JsonConvert.DeserializeObject<CommentResponseDSO>(response.Content);

            return commentResponse;

        }

    }
}
