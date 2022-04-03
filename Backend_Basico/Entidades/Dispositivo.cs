using System.ComponentModel.DataAnnotations;

public class Dispositivo{
    
    [Key]
    public int Id {get; set;}

    public string Marca {get; set;}

    public string Modelo {get; set;}

    public string IMEI {get; set;}

    public string Color {get; set;}

    public bool Teclado {get; set;}
}