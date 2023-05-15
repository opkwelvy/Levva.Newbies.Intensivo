using Levva.Newbies.Intensivo.Logic.Dtos;

namespace Levva.Newbies.Intensivo.Logic.Interfaces
{
    public interface ITransacaoService
    {
        void Create(TransacaoDto transacao);
        TransacaoDto Get(int id);   
        List<TransacaoDto> GetAll();
        void Update(TransacaoDto transacao);
        void Delete(int id);

    }
}
