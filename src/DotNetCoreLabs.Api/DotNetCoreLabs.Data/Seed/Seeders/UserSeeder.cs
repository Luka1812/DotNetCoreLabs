using System;
using System.Collections.Generic;
using DotNetCoreLabs.Data.Entities;

namespace DotNetCoreLabs.Data.Seed.Seeders
{
    public class UserSeeder 
    {
        public List<User> UsersData()
        {
            var users = new List<User>() {
                new User 
                {
                    Id = 1,
                    Firstname = "Luka",
                    Email = "luka.vavetic@gmail.com",
                    Lastname = "Vavetić",
                    Username = "Lukaku",
                    BirthDate = new DateTime(1994, 12, 18, 0, 0, 0),
                },
                new User 
                {
                    Id = 2,
                    Firstname = "Frano",
                    Email = "frano.sasavi@gmail.com",
                    Lastname = "Sasvari",
                    Username = "Fusari",
                    BirthDate = new DateTime(1989, 11, 22, 0, 0, 0),
                }
            };
            
            return users;
        }
    }
}