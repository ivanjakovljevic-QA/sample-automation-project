using System;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.storage
{
    public class ArticleEntity
    {
        private String title;
        private String body;
        private String description;
        private String slug;

        public ArticleEntity()
        {
        }

        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }
        public string Description { get => description; set => description = value; }
        public string Slug { get => slug; set => slug = value; }
    }
}
