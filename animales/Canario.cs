using System;

public class Canario: Avioticos
{
    public string Orden { get; set; }
    public string Familia { get; set; }

    public void Cantan()
    {
        Console.WriteLine("Cantan y hacen sonidos");
    }

    public void Plumaje()
    {
        DescribirPlumaje();
    }

    private void DescribirPlumaje()
    {
        Console.WriteLine("Colorido en amarillo, azul, naranja ");
    }

}