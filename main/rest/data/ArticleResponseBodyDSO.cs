using System;
using System.Collections.Generic;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class ArticleResponseBodyDSO
    {
        private String body;
        private String createdAt;
        private String description;
        private Boolean favorited;
        private int favoritesCount;
        private String slug;
        private List<String> tagList;
        private String title;
        private String updatedAt;

        public string Body { get => body; set => body = value; }
        public string CreatedAt { get => createdAt; set => createdAt = value; }
        public string Description { get => description; set => description = value; }
        public bool Favorited { get => favorited; set => favorited = value; }
        public int FavoritesCount { get => favoritesCount; set => favoritesCount = value; }
        public string Slug { get => slug; set => slug = value; }
        public List<string> TagList { get => tagList; set => tagList = value; }
        public string Title { get => title; set => title = value; }
        public string UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}
