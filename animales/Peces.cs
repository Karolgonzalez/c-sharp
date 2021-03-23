using System;

public class Pezfrase: Acuaticos
{
    public string Frase { get; set; }

    public void dicho()
    {
        Console.WriteLine("peces quiere la gata, mas no entrar en el agua");
    }

    public void Frase()
    {
        Frasedepez();
    }

    private void Frasedepez()
    {
        Console.WriteLine("“Algunos peces no se dejan pescar. No es que sean más rapidos, o más fuertes que los otros peces. Es solo que han sido como tocados por la gracia. El Bestia era uno de esos peces.");
    }
}