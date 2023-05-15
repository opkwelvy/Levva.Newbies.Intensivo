using Levva.Newbies.Intensivo.Domain.Models;

namespace Levva.Newbies.Intensivo.Data.Interfaces
{
    public interface ITransacaoRepository
    {
        void Create(TransacaoDto transacao);
        TransacaoDto Get(int id);
        List<TransacaoDto> GetAll();   
        void Update(TransacaoDto transacao);
        void Delete(int id);
        void Create(Transacao transacao);
        void Update(Transacao transacao);
    }   
}
