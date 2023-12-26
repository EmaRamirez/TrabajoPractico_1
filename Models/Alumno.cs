using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practico1.Models;
public class Alumno
{

    public Alumno() { }
    public Alumno(int id, string nom, string ape, int dni, DateTime fecha, string domi)
    {
        this.Id = id;
        this.Nombre = nom;
        this.Apellido = ape;
        this.Dni = dni;
        this.FechaNacimiento = fecha;
        this.Domicilio = domi;
    }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Dni { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Domicilio { get; set; }
}