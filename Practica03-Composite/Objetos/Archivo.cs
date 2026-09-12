namespace Practica03_Composite;

public class Archivo : IElementoSistemaArchivos
{
    private string nombre;
    private int tamano;

    public Archivo(string nombre, int tamano)
    {
        this.nombre = nombre;
        this.tamano = tamano;
    }

    public int obtenerTamano()
    {
        return tamano;
    }

    public void mostrar(int nivelDeIndentacion)
    {
        Console.WriteLine(new string(' ', nivelDeIndentacion) + nombre);
    }
}

