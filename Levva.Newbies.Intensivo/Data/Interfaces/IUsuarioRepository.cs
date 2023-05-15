using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;

namespace Levva.Newbies.Intensivo.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        void Create(UsuarioDto usuario);
        UsuarioDto Get(int id);
        List<UsuarioDto> GetAll();
        void Update(UsuarioDto usuario);
        void Delete(int id);
        void Create(Usuario usuario);
        void Update(UsuarioDto usuario);
        void Update(Usuario usuario);
    }
}
