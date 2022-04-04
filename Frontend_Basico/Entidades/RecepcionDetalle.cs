using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Frontend_Basico{

    public class RecepcionDetalle{

        [Key]
        public int RecepcionDetalleId {get; set;}

        public string Detalle {get; set;}

    }
    
}