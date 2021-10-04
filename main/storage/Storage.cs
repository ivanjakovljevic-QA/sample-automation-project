/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.storage
{
    public class Storage
    {
        public UserEntity User { get; set; } = new UserEntity();
        public ArticleEntity Article { get; set; } = new ArticleEntity();

        public void AddUser(UserEntity userEntity)
        {

            User.Email = userEntity.Email;
            User.Password = userEntity.Password;
            User.Username = userEntity.Username;
        }

        public void AddArticle(ArticleEntity articleEntity)
        {
            Article.Body = articleEntity.Body;
            Article.Description = articleEntity.Description;
            Article.Title = articleEntity.Title;
            Article.Slug = articleEntity.Slug;
        }
    }
}
