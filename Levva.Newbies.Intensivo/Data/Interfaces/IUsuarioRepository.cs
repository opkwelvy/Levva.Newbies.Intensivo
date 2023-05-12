using Levva.Newbies.Intensivo.Domain.Models;

namespace Levva.Newbies.Intensivo.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        void Create(Usuario usuario);
        Usuario Get(int id);
        List<Usuario> GetAll();
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
