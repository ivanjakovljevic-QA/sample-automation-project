using System;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class CommentResponseBodyDSO
    {

        private CommentAuthorDSO author;
        private String body;
        private String createdAt;
        private int id;
        private String updatedAt;

        public CommentAuthorDSO Author { get => author; set => author = value; }
        public string Body { get => body; set => body = value; }
        public string CreatedAt { get => createdAt; set => createdAt = value; }
        public int Id { get => id; set => id = value; }
        public string UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}
