using Levva.Newbies.Intensivo.Data.Interfaces;
using Levva.Newbies.Intensivo.Domain.Models;

namespace Levva.Newbies.Intensivo.Data.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly Context _context;
        public TransacaoRepository(Context context)
        {
            _context = context;
        }
        public void Create(TransacaoDto transacao)
        {
            _context.Transacao.Add(transacao);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var transacao = _context.Transacao.Find(id);
            _context.Transacao.Remove(transacao);
            _context.SaveChanges();

        }

        public TransacaoDto Get(int id)
        {
            return _context.Transacao.Find(id);
        }

        public List<TransacaoDto> GetAll()
        {
            return _context.Transacao.ToList();
        }

        public void Update(TransacaoDto transacao)
        {
            _context.Transacao.Update(transacao);
            _context.SaveChanges();

        }
    }
}
