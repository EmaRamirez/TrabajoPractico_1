

using System.ComponentModel;
using Practico1.Models;

namespace Practico1.Services;
public static class AlumnoServices
{
    static List<Alumno> ListadoAlumno { get; set; }

    static AlumnoServices()
    {
        ListadoAlumno = new List<Alumno>(){
    new Alumno(1,"Emanuel","Ramirez",22546588,new DateTime(1995,11,18),"25 de Mayo 255"),
    new Alumno(2,"Juan","Dominguez",84951112,new DateTime(1995,11,01),"Viena 5877"),
    new Alumno(3,"Daiana","Quiroga",46523111,new DateTime(1997,07,13),"Siempre Viva 255"),
    new Alumno(4,"Miguel","Peña",54697702,new DateTime(1992,08,30),"Marchena 8999")
    };
    }

    public static List<Alumno> GetAll() => ListadoAlumno.OrderBy(x => x.Id).ToList();

    public static Alumno? Get(string value) => ListadoAlumno.FirstOrDefault(x => (x.Nombre).ToLower() == value.ToLower());

    public static void Delete(string value)
    {
        if (value == null)
        {
            return;
        }
        var borrar = Get(value);
        ListadoAlumno.Remove(borrar);
    }

    public static void Agregar(Alumno value) => ListadoAlumno.Add(value);


    public static void Update(Alumno value)
    {
        if (value != null)
        {
            var valor = ListadoAlumno.Where(x => x.Id == value.Id).First();
            ListadoAlumno.Remove(valor);
            ListadoAlumno.Add(value);
        }

    }
}