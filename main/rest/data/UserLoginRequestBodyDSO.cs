using System;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class UserLoginRequestBodyDSO
    {
        private String email;
        private String password;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
