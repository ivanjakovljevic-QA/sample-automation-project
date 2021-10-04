using System;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class CommentAuthorDSO
    {

        private String bio;
        private Boolean following;
        private String image;
        private String username;

        public string Bio { get => bio; set => bio = value; }
        public bool Following { get => following; set => following = value; }
        public string Image { get => image; set => image = value; }
        public string Username { get => username; set => username = value; }
    }
}
