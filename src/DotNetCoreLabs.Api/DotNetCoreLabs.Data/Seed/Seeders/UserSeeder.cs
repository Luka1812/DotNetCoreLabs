using System;
using System.Linq;
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
                Email = "luka.vavetic@gmail.com",
                Lastname = "Vavetić",
                Username = "Lukaku",
                BirthDate = new DateTime(1994, 12, 18, 0, 0, 0),
            };

            var existingUser = context.Users.Where(u => u.Lastname == user.Lastname).FirstOrDefault();

            if (existingUser == null) {
                context.Users.Add(user);
            
                context.SaveChanges();
            }
        }
    }
}