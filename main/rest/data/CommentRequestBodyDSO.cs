using System;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class CommentRequestBodyDSO
    {
        private String body;

        public string Body { get => body; set => body = value; }
    }
}
