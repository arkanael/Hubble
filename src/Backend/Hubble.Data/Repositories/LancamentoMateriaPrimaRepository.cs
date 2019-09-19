using Hubble.Data.Context;
using Hubble.Entities;

namespace Hubble.Data.Repositories
{
    class LancamentoMateriaPrimaRepository : BaseRepository<LancamentoMateriaPrima>
    {
        private readonly DataContext dataContext;

        public LancamentoMateriaPrimaRepository(DataContext dataContext):base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
