using System.Collections.Generic;

namespace Hubble.Entities
{
    public class Transportadora
    {
        public int IdTransportadora { get; set; }
        public string RazaoSocial { get; set; }
        public IList<LancamentoMateriaPrima> LancamentoMateriaPrima { get; set; }
    }
}
