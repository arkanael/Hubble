using Hubble.Data.Context;
using Hubble.Entities;

namespace Hubble.Data.Repositories
{
    public class TransportadoraRepository : BaseRepository<Transportadora>
    {
        private readonly DataContext dataContext;
        public TransportadoraRepository(DataContext dataContext):base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
