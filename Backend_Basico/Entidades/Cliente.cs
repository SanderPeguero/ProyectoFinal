using System.ComponentModel.DataAnnotations;

public class Cliente{

    [Key]
    public int Id {get; set;}

    public string Nombre {get; set;}

    public string Apellido {get; set;}

    public string Cedula {get; set;}

    public string Telefono {get; set;}

    public DateTime Fecha {get; set;} = DateTime.Now;
    
    public List<Dispositivo> Dispositivos {get; set;}


}