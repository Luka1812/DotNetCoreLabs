using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreLabs.Data.Context;
using DotNetCoreLabs.Data.Entities;

namespace DotNetCoreLabs.Data.Repository
{
    public class UserRepository
    {
        protected readonly DotNetCoreLabsContext context;

        public UserRepository(DotNetCoreLabsContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList();
        }
    }
}