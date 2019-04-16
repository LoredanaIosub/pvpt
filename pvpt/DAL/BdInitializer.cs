using pvpt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pvpt.DAL
{
    public class BdInitializer : DropCreateDatabaseIfModelChanges<BdContext>
    {
        protected override void Seed(BdContext context)
        {
            var users = new List<User>
            {
                new User{FirstName="Loredana", LastName="Iosub", Nationality="romana", FeedBack="Un oras superb!"},
                new User{FirstName="Admin", LastName="Admin", Nationality="romana", FeedBack="Un oras superb!"},
                new User{FirstName="Aadmin", LastName="Aadmin", Nationality="romana", FeedBack="Un oras superb!"}
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}