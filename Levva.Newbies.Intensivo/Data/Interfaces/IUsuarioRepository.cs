using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;

namespace Levva.Newbies.Intensivo.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario Get(int id);
        Usuario GetByEmailAndSenha(string email, string senha);
        List<Usuario> GetAll();
        void Delete(int id);
        void Create(Usuario usuario);
        void Update(Usuario usuario);
    }
}
