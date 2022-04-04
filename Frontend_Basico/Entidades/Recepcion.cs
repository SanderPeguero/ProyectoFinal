using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Frontend_Basico{
    
    public class Recepcion{

        [Key]
        public int RecepcionId {get; set;}

        public DateTime Fecha {get; set;} = DateTime.Now;

        public string Cliente {get; set;}

        public string Tecnico {get; set;}

        public Categoria Categoria {get; set;}

        public Producto Producto {get; set;}

        [ForeignKey("RecepcionId")]
        public virtual List<RecepcionDetalle> Problemas {get; set;} = new List<RecepcionDetalle>();

    }
    
}