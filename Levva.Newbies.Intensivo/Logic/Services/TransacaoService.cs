using AutoMapper;
using Levva.Newbies.Intensivo.Data.Interfaces;
using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;
using Levva.Newbies.Intensivo.Logic.Interfaces;

namespace Levva.Newbies.Intensivo.Logic.Services
{

    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _repository;
        private readonly IMapper _mapper;

        public TransacaoService(ITransacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(TransacaoDto transacao)
        {
            var _transacao = _mapper.Map<Transacao>(transacao);
            _repository.Create(_transacao);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public TransacaoDto Get(int id)
        {
            var transacao = _mapper.Map<TransacaoDto>(_repository.Get(id));
            return transacao;
        }

        public List<TransacaoDto> GetAll()
        {
            var transacao = _mapper.Map<List<TransacaoDto>>(_repository.GetAll());
            return transacao;
        }

        public void Update(TransacaoDto transacao)
        {
            var _transacao = _mapper.Map<Transacao>(transacao);
            _repository.Update(_transacao);
        }
    }
}
