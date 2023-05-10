using Levva.Newbies.Intensivo.Domain.Enums;

namespace Levva.Newbies.Intensivo.Domain.Models
{
    public class Transacao
    {
        public int Id { get; set; } 
        public string Descricao { get; set; }  
        public decimal Valor {get; set; }
        public DateTime Data { get; set; }
        public TipoTransacaoEnum Tipo { get; set; }
        public int CategoriaId { get; set; } 
        public virtual Categoria Categoria { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
