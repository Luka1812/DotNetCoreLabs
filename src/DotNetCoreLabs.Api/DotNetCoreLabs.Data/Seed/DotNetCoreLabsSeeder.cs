using DotNetCoreLabs.Data.Seed.Seeders;
using System.Collections.Generic;
using DotNetCoreLabs.Data.Context;

namespace DotNetCoreLabs.Data.Seed
{
    public class DotNetCoreLabsSeeder
    {
        private readonly DotNetCoreLabsContext context;

        private readonly List<SeederBase> seeders;

        public DotNetCoreLabsSeeder(DotNetCoreLabsContext context)
        {
            this.context = context;
            seeders = new List<SeederBase>
            {
                new UserSeeder(context),
            };
        }

        public void SeedDatabase()
        {
            for (var i = 0; i < seeders.Count; i++)
            {
                seeders[i].Seed();
            }
        }
    }
}