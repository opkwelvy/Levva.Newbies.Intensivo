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
        public void Create(UsuarioDto usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var usuario = _context.Usuario.Find(id);
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();

        }

        public UsuarioDto Get(int id)
        {
            return _context.Usuario.Find(id);
        }

        public List<UsuarioDto> GetAll()
        {
            return _context.Usuario.ToList();
        }

        public void Update(UsuarioDto usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();

        }
    }
}
