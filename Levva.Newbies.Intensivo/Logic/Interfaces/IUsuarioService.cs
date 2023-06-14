using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;

namespace Levva.Newbies.Intensivo.Logic.Interfaces
{
    public interface IUsuarioService
    {
        Usuario Create(NovoUsuarioDto usuarioDto);
        UsuarioDto Get(int id);
        List<UsuarioDto> GetAll();
        void Update(UsuarioDto usuarioDto);
        void Delete(int id);
        LoginDto Login(LoginDto loginDto);
    }
}
