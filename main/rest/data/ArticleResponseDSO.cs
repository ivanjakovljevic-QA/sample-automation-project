
/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class ArticleResponseDSO
    {

        private ArticleResponseBodyDSO article = new ArticleResponseBodyDSO();

        public ArticleResponseBodyDSO Article { get => article; set => article = value; }
    }
}
