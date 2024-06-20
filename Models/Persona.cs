
namespace IPG_MediaBrands.Models;

public class Persona
{
    public Guid Id {get;set;}
    public string Nombre {get;set;}

    public short Edad { get; set; }

    public Genero Genero { get; set;}
    public DateTime FechaIngreso { get; set;}
}

public enum Genero 
{
    Masculino,
    Femenino,
    Otros
}