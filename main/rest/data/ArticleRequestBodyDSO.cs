using System;
using System.Collections.Generic;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class ArticleRequestBodyDSO
    {
        private String body;
        private String description;
        private List<String> taglist;
        private String title;

        public string Body { get => body; set => body = value; }
        public string Description { get => description; set => description = value; }
        public List<string> Taglist { get => taglist; set => taglist = value; }
        public string Title { get => title; set => title = value; }
    }
}
