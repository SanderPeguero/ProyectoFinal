using System.ComponentModel.DataAnnotations;

public class Recepcion{

    [Key]
    public int Id {get; set;}

    public DateTime Fecha {get; set;} = DateTime.Now;

    public Cliente Cliente {get; set;}

    public List<string> Problemas {get; set;}

    public string Tecnico {get; set;}

    public Categoria Categoria {get; set;}

    public Producto Producto {get; set;}


}