using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsLindo { get; set; }

    public Gato() // Polimorfismo
    {
        EsLindo = true;
    }

    public Gato(bool esLindo) // Polimorfismo
    {
        EsLindo = esLindo;
    }
    public void maullar()
    {
        Console.WriteLine("Si un gato hablara, sería para decir cosas como: oye, no veo ningún problema aquí...Roy Blount Jr.");

    }

}