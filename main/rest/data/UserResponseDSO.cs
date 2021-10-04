using System;
using System.Collections.Generic;
using System.Text;

/**
* @author Ivan Jakovljevic (ivan_jakovljevic@outlook.com)
* @since 7/31/2020
*/
namespace realworld.main.rest.data
{
    public class UserResponseDSO
    {
        private UserResponseBodyDSO user = new UserResponseBodyDSO();

        public UserResponseBodyDSO User { get => user; set => user = value; }
    }
}
