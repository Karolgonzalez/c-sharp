using System;
public abstract class Mamifero: Metazoos 
{
    public int Patas { get; set; }

    public void Caminar()
    {
        Console.WriteLine("Caminando, un mamifero va caminando por la playa..");
    }

}