using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Adriana";
            a.SegundoNombre = "Guadalupe";
            
            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Karol";
            b.SegundoNombre = "Giselly";
            
            Alumno c = new Alumno(3);
            c.PrimerNombre = "Dina";

            Alumno d = new Alumno("Billy", "Feranadez");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
