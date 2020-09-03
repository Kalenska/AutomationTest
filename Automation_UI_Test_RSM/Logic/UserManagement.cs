using RSM_Automation_Test_UI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSM_Automation_Test_UI.Logic
{
    public class UserManagement
    {
        // TODO: Implement with HttpClient or WCF
        public void CreateUser(TestUser testUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(TestUser testUser)
        {
            throw new NotImplementedException();
        }

        // TODO: Move all these data classes, like TestUser, DefaultUser, etc. in a different place
        // That is separate data from operations
        // The actual management
        // public class TestUser
        //{
        //   // public string Username { get; } = "MyUser";

        //    //public void DeleteUser()
        //    //{
        //    //    RestClient client = new RestClient(@"http://staging.webiste.com/%22");

        //    //    RestRequest request = new RestRequest("/api/delete?userId=23", Method.POST);

        //    //    var response = client.Execute(request);

        //    //}

        //}

        //public class DefaultUser
        //{
        //    public string Username { get; } = "User";

        //    // Get Username

        //    // Get Password

        //    // Get Email

        //}

        // windows login - api 
    }
}