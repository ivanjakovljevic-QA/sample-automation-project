
/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class CommentRequestDSO
    {

        private CommentRequestBodyDSO comment = new CommentRequestBodyDSO();

        public CommentRequestBodyDSO Comment { get => comment; set => comment = value; }
    }
}
