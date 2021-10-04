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
    public class ArticleStepDefinition
    {
        ArticleProxy articleProxy = new ArticleProxy();

        /**
         * Method used for creating new article
         */
        public void createNewArticle()
        {
            ArticleEntity article = new ArticleEntity();


            article.Description = "AutoTestDescription";
            article.Title = "AutoTestTitle";
            article.Body = "AutoTestBody";

            storageData().AddArticle(article);

            ArticleResponseDSO articleResponse = articleProxy.createArticle();

            //Article creation validations
            Assert.That(articleResponse.Article.Body, Is.Not.Null);
            Assert.That(articleResponse.Article.Body, Is.EqualTo(article.Body));

            Logger.LogMessage("Article with slug: {0} was successfully created!", article.Slug);
        }

        //Method used for adding comment to newly created article
        public void addNewComment()
        {
            UserEntity user = storageData().User;

            CommentResponseDSO commentResponse = articleProxy.addCommentToArticle(user);

            //Comment creation validations
            Assert.That(commentResponse.Comment.Body, Is.Not.Null);
            Assert.That(commentResponse.Comment.Body, Is.EqualTo("AutoTestComment"));
            Assert.That(commentResponse.Comment.Author.Username, Is.EqualTo(user.Username));

            Logger.LogMessage("Comment was successfully added to newly created aricle!");
        }
    }
}
