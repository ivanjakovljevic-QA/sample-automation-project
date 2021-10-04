
/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class CommentResponseDSO
    {

        private CommentResponseBodyDSO comment = new CommentResponseBodyDSO();

        public CommentResponseBodyDSO Comment { get => comment; set => comment = value; }
    }
}
