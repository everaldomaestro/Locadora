namespace Classes.Entidades
{
    using System;

    public partial class Pagamento
    {
        public int PAGAMENTO_ID { get; set; }
        public DateTime PAGAMENTO_DATA { get; set; }
        public DateTime PAGAMENTO_VENCIMENTO { get; set; }
        public decimal PAGAMENTO_VALORPAGAR { get; set; }
        public decimal PAGAMENTO_VALORPAGO { get; set; }
        public int PAGAMENTO_BENEFICIARIO { get; set; }
        public int PAGAMENTO_PAGADOR { get; set; }
        public int PAGAMENTO_METODOPAG { get; set; }
        public int PAGAMENTO_FORMAPAG { get; set; }
        public int PAGAMENTO_TIPOPAG { get; set; }
    }
}
