using Levva.Newbies.Intensivo.Data.Interfaces;
using Levva.Newbies.Intensivo.Domain.Models;

namespace Levva.Newbies.Intensivo.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Context _context;
        public CategoriaRepository(Context context)
        {
            _context = context;
        }
        public void Create(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var categoria = _context.Categoria.Find(id);
            _context.Categoria.Remove(categoria);
            _context.SaveChanges();

        }

        public Categoria Get(int id)
        {
            return _context.Categoria.Find(id);
        }

        public List<Categoria> GetAll()
        {
            return _context.Categoria.ToList();   
        }

        public void Update(Categoria categoria)
        {
            _context.Categoria.Update(categoria);
            _context.SaveChanges();

        }
    }
}
