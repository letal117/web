using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Becas.Models;

namespace Becas.Services
{
    public class AlumnosServices
   {
    static List <Alumnos> Alumnos {get;}

    static int nextId = 3;

    static AlumnosServices ()
    {
    Alumnos = new List <Alumnos> {
        new Alumnos {Id = 1, Nombre = "Mayra Esmeralda", A_Paterno = "Medina", A_Materno = "Balan", Matricula = "8521100012", Carrera = "T.S.U en TI", Correo = "JesusBln@gmail.com", Telefono = "982-184-7156", Lugar_Origen = "Haro", Lugar_Estancia = "Candelaria"},
        new Alumnos {Id = 2, Nombre = "Jesus Antonio", A_Paterno = "Velazquez", A_Materno = "Balan", Matricula = "8521100013", Carrera = "T.S.U en TI", Correo = "MayraBln@gmail.com", Telefono = "982-108-8683", Lugar_Origen = "Candelaria", Lugar_Estancia = "Candelaria"},
     };
    }
    public static List <Alumnos> GetAll()=> Alumnos;

    public static Alumnos Get (int Id)=> Alumnos.FirstOrDefault (p => p.Id == Id);

    public static void Add(Alumnos alumnos)
    {
       alumnos.Id = nextId++;
    Alumnos.Add(alumnos);
    }
    public static void Delete(int Id)
    {
       var alumnos = Get(Id);
       if(alumnos is null)
       return;

       Alumnos.Remove(alumnos);
    }
    public static void Update(Alumnos alumnos)
    {
        var index = Alumnos.FindIndex(p => p.Id == alumnos.Id);
        if(index == -1)
        return;

         Alumnos[index] = alumnos;
    }
    }

}