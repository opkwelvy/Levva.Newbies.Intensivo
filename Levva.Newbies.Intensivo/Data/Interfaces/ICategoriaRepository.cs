using Levva.Newbies.Intensivo.Domain.Models;
using Levva.Newbies.Intensivo.Logic.Dtos;

namespace Levva.Newbies.Intensivo.Data.Interfaces
{
    public interface ICategoriaRepository
    {
        void Create(Categoria categoria);
        Categoria Get(int id);
        List<Categoria> GetAll();
        void Update(Categoria categoria);
        void Delete(int id);
        void Create(CategoriaDto categoria);
    }
}
