using Hubble.Data.Context;
using Hubble.Entities;

namespace Hubble.Data.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>
    {
        private readonly DataContext dataContext;

        public FornecedorRepository(DataContext dataContext):base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
