using Microsoft.VisualStudio.TestTools.UnitTesting;
using realworld.test.stepdef;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.test.feature

{
    [TestClass]
    public class ArticleFeature
    {
        UserStepDefinition user = new UserStepDefinition();
        ArticleStepDefinition article = new ArticleStepDefinition();

        [TestMethod]
        //Scenario: Add comment newly created article
        //Jelena
        public void WolfExamScenario()
        {

            //Step 1: Create new portal user
            user.createNewUser();

            //Step 2: Login with created user
            user.userLogin();

            //Step 3: Create new article for logged in user
            article.createNewArticle();

            //Step 4: Add comment to newly created article
            article.addNewComment();

        }
    }
}
