namespace Practica03_TemplateMethod;

public class PreparadorDeCafe : PreparadorDeBebida
{
    public override void agregarBaseDeSaborizante()
    {
        Console.WriteLine("Agregando café");
    }
}

