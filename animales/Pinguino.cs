using System;

public class Pinguino: Acuaticos
{
    public string Jugar { get; set; }

    public void investigar()
    {
        Console.WriteLine("¡Maniobras evasivas!");
    }

    public void Skipper()
    {
        Frase();
    }

    private void Frase()
    {
        Console.WriteLine("Gorditos y bonitos, gorditos y bonitos, chicos. Sonrían y saluden, sonrían y saluden.");
    }
}