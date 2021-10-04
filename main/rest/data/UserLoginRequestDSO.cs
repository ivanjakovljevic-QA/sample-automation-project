using System;
using System.Collections.Generic;
using System.Text;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class UserLoginRequestDSO
    {
        private UserLoginRequestBodyDSO user = new UserLoginRequestBodyDSO();

        public UserLoginRequestBodyDSO User { get => user; set => user = value; }
    }
}
