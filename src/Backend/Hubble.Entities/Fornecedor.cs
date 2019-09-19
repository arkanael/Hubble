using System.Collections.Generic;

namespace Hubble.Entities
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public IList<LancamentoMateriaPrima> LancamentoMateriaPrima { get; set; }
    }
}
