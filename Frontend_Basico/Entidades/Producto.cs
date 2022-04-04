using System.ComponentModel.DataAnnotations;

namespace Frontend_Basico{
    
    public class Producto{

        [Key]
        public int ProductoId {get; set;}

        public string Nombre {get; set;}

        public int Precio {get; set;}

        public string Descripcion {get; set;}
        
    }
    
}