using System;
using System.Collections.Generic;
using System.Text;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class UserResponseBodyDSO
    {
        private String bio;
        private String createdAt;
        private String email;
        private int id;
        private String image;
        private String token;
        private String updatedAt;
        private String username;

        public string Bio { get => bio; set => bio = value; }
        public string CreatedAt { get => createdAt; set => createdAt = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }
        public string Image { get => image; set => image = value; }
        public string Token { get => token; set => token = value; }
        public string UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public string Username { get => username; set => username = value; }
    }
}
