using System;
using System.Collections.Generic;

namespace DotNetCoreLabs.Data.Entities
{
    public partial class User
    {
        public User()
        {
            
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}