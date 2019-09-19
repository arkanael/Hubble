using System;

namespace Hubble.Entities
{
    public class LancamentoMateriaPrima
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Codigo { get; set; }
        public string RIR { get; set; }
        public string OrdemCompra { get; set; }
        public string NotaFiscal { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public DateTime Validade { get; set; }

        public int IdTransportadora { get; set; }
        public Transportadora Transportadora { get; set; }
    }
}
