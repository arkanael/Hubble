using System;

namespace Hubble.Entities
{
    public class LancamentoMateriaPrima
    {
        public int IdLancamentoMateriaPrima { get; set; }
        public DateTime Data { get; set; }
        public string CodigoMateriaPrima { get; set; }
        public string RIR { get; set; }
        public string OrdemCompra { get; set; }
        public string NotaFiscal { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public DateTime Validade { get; set; }
        public int IdTransportadora { get; set; }
        public int IdTFornecedor { get; set; }
        public Transportadora Transportadora { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
