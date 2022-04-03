using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Recepcion{

    [Key]
    public int RecepcionId {get; set;}

    public DateTime Fecha {get; set;} = DateTime.Now;

    public Cliente Cliente {get; set;}

    [ForeignKey("RecepcionId")]
    public virtual List<RecepcionDetalle> Problemas {get; set;} = new List<RecepcionDetalle>();

    public string Tecnico {get; set;}

    public Categoria Categoria {get; set;}

    public Producto Producto {get; set;}


}