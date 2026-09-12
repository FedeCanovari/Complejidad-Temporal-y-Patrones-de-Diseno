namespace Practica03_TemplateMethod;

public abstract class PreparadorDeBebida
{
    public void prepararBebida()
    {
        hervirAgua();
        agregarBaseDeSaborizante();
        verterEnTaza();
        agregarCondimentos();
    }

    public void hervirAgua()
    {
        Console.WriteLine("Hirviendo agua");
    }

    public abstract void agregarBaseDeSaborizante();

    public void verterEnTaza()
    {
        Console.WriteLine("Vertiendo en taza");
    }

    public virtual void agregarCondimentos()
    {
        Console.WriteLine("Agregando condimentos");
    }
}