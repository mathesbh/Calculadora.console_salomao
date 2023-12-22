namespace Application.Models
{
    public class OperacoesHistorico
    {
        public OperacoesHistorico(string? operacao, float resultado, DateTime data)
        {
            Id = Guid.NewGuid();
            Operacao = operacao;
            Resultado = resultado;
            Data = data;
        }

        public Guid Id { get; set; }
        public string? Operacao { get; set; }
        public float Resultado { get; set; }
        public DateTime Data { get; set; }
    }
}