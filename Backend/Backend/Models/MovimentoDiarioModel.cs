namespace Backend.Models
{
    public class MovimentoDiarioModel
    {
        public int Id { get; set; }
        public string Recibo { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; } = "Pendente";
        public DateTime DataMovimento { get; set; }
        public DateTime? DataPrevista { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public int IdMensageiro { get; set; }
        public MensageiroModel Mensageiro { get; set; }
        public int IdTipoPagamento { get; set; }
        public TipoPagamentoModel TipoPagamento { get; set; }
    }
}
