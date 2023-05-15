using AutoMapper;
using Levva.Newbies.Intensivo.Data.Interfaces;
using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;
using Levva.Newbies.Intensivo.Logic.Interfaces;

namespace Levva.Newbies.Intensivo.Logic.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;
        public UsuarioService(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(UsuarioDto usuario)
        {
            var _usuario = _mapper.Map<Usuario>(usuario);
            _repository.Create(_usuario);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public UsuarioDto Get(int id)
        {
            var _usuario = _mapper.Map<UsuarioDto>(_repository.Get(id));
            return _usuario;
        }

        public List<UsuarioDto> GetAll()
        {

            var usuarios = _mapper.Map<List<UsuarioDto>>(_repository.GetAll());
            return usuarios;
        }

        public void Update(UsuarioDto usuario)
        {
            var _usuario = _mapper.Map<Usuario>(usuario);
            _repository.Update(_usuario);
        }
    }
}
