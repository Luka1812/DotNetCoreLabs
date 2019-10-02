using System;
using DotNetCoreLabs.Data.Context;
using DotNetCoreLabs.Data.Entities;

namespace DotNetCoreLabs.Data.Seed.Seeders
{
    public class UserSeeder : SeederBase
    {

        public UserSeeder(DotNetCoreLabsContext context) : base(context)
        {
        }

        public override void Seed()
        {
            var user = new User 
            {
                Firstname = "Luka",
                Lastname = "Vavetić",
                Username = "Lukaku",
                BirthDate = new DateTime(1994, 12, 18, 0, 0, 0),
            };

            context.Users.Add(user);
            
            context.SaveChanges();
        }
    }
}