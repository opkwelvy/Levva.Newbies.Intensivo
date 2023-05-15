using Levva.Newbies.Intensivo.Logic.Dtos;

namespace Levva.Newbies.Intensivo.Logic.Interfaces
{
    public interface IUsuarioService
    {
        void Create(UsuarioDto usuarioDto);
        UsuarioDto Get(int id);
        List<UsuarioDto> GetAll();
        void Update(UsuarioDto usuarioDto);
        void Delete(int id);
    }
}
