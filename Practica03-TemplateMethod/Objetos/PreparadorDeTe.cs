namespace Practica03_TemplateMethod;

public class PreparadorDeTe : PreparadorDeBebida
{
    public override void agregarBaseDeSaborizante()
    {
        Console.WriteLine("Agregando té");
    }

    public override void agregarCondimentos()
    {
        Console.WriteLine("Agregando miel y limón");
    }
}

