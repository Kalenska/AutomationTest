using System;
using System.Collections.Generic;
using System.Text;

namespace RSM_Automation_Test_UI.Models
{
    public class TestUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public TestUser() { }
        public TestUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
