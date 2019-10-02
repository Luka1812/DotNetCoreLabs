using System;
using DotNetCoreLabs.Data.Context;
using DotNetCoreLabs.Data.Seed;

namespace DotNetCoreLabs.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            var seeder = new DotNetCoreLabsSeeder(new DotNetCoreLabsContext());
            seeder.SeedDatabase();
        }
    }
}
