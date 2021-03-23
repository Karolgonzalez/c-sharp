using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato g = new Gato();
            Console.WriteLine("- Gato -");
            g.Nombre = "Gordo";
            g.Patas = 4;
            g.Pelaje = "Melena peludo, negra, tigreado";
            g.Raza = "Occidental";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsLindo = true;

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine(g.Pelaje);
            Console.WriteLine(g.Raza);         

            Console.WriteLine();

            Canario c = new canario();
            Console.WriteLine("- Canario -");
            c.Nombre = "canario";
            c.Patas = 2;
            c.Comer();
            c.cantan = true;
            c.volar();
            c.Plumaje();
            Console.WriteLine(c.cantan);
            Console.WriteLine(c.ColorPlumaje);
            Console.WriteLine(c.Pata)s;


            Console.WriteLine(c.Nombre);
            Console.WriteLine();

            Peces p = new Peces();
            Console.WriteLine("- Peces-");
            p.Nombre = "Dorado";
            p.Comer();
            p.nadar();
            p.NumeroAletas = 2;
            p.frase();
            p.dicho();

            Console.WriteLine(p.dicho);
            Console.WriteLine(p.Frase);
            Console.WriteLine();


            Pinguino P = new Pinguino();
            Console.WriteLine("-Pinguino-");
            P.Nombre ="Skipper";
            P.jugar();
            P.investigar();
            P.frase();

           Console.WriteLine(P.Pinguino);
           Console.WriteLine(P.jugar);
           Console.WriteLine(P.investigar);
           Console.WriteLine(P.Frase);

            }
        }
}