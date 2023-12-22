using Application.Interfaces;
using Application.Models;

namespace Data
{
    public class OperacoesHistoricoDAO : IOperacoesHistorico, IDisposable
    {
        private readonly CalculadoraDbContext _context;

        public OperacoesHistoricoDAO()
        {
            _context = new CalculadoraDbContext();
        }

        public void Adicionar(OperacoesHistorico historico)
        {
            _context.OperacoesHistoricos.Add(historico);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
