
/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class ArticleRequestDSO
    {

        private ArticleRequestBodyDSO article = new ArticleRequestBodyDSO();

        public ArticleRequestBodyDSO Article { get => article; set => article = value; }
    }
}
