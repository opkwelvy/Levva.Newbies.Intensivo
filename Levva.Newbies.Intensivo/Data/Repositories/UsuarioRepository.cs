using Levva.Newbies.Intensivo.Data.Interfaces;
using Levva.Newbies.Intensivo.Domain.Models;

namespace Levva.Newbies.Intensivo.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _context;
        public UsuarioRepository(Context context) {
            _context = context;
        }
        public void Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
        }

        public void Delete(int id)
        {
            var usuario = _context.Usuario.Find(id);
            _context.Usuario.Remove(usuario);
        }

        public Usuario Get(int id)
        {
            return _context.Usuario.Find(id);
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuario.Update(usuario);
        }
    }
}
