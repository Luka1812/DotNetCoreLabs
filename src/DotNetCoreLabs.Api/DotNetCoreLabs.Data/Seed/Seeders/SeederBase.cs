using DotNetCoreLabs.Data.Context;

namespace DotNetCoreLabs.Data.Seed.Seeders
{
    public abstract class SeederBase
    {
        protected readonly DotNetCoreLabsContext context;

        public SeederBase(DotNetCoreLabsContext context)
        {
            this.context = context;
        }

        public abstract void Seed();
    }
}