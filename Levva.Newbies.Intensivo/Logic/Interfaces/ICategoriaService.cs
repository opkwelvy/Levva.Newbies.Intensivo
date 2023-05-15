using Levva.Newbies.Intensivo.Logic.Dtos;

namespace Levva.Newbies.Intensivo.Logic.Interfaces
{
    public interface ICategoriaService
    {
        void Create(CategoriaDto categoria);
        CategoriaDto Get(int id);
        List<CategoriaDto> GetAll();    
        void Update(CategoriaDto categoria);    
        void Delete(int id);
    }
}
