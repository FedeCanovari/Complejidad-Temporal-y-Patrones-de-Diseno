namespace Practica03_Composite;

public class Carpeta : IElementoSistemaArchivos
{
    private string nombre;
    private List<IElementoSistemaArchivos> elementos;

    public Carpeta(string nombre)
    {
        this.nombre = nombre;
        elementos = new List<IElementoSistemaArchivos>();
    }

    public void agregar(IElementoSistemaArchivos elemento)
    {
        elementos.Add(elemento);
    }

    public int obtenerTamano()
    {
        int total = 0;

        foreach (IElementoSistemaArchivos elemento in elementos)
        {
            total += elemento.obtenerTamano();
        }

        return total;
    }

    public void mostrar(int nivelDeIndentacion)
    {
        Console.WriteLine(new string(' ', nivelDeIndentacion) + nombre);

        foreach (IElementoSistemaArchivos elemento in elementos)
        {
            elemento.mostrar(nivelDeIndentacion + 2);
        }
    }
}