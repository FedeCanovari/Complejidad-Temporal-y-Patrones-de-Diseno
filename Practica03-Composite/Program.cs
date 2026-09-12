namespace Practica03_Composite;

public class Program
{
    public static void Main(string[] args)
    {
        Archivo archivo1 = new Archivo("parcial.pdf", 1000);
        Archivo archivo2 = new Archivo("strategy.pdf", 500);
        Archivo archivo3 = new Archivo("iterator.pdf", 400);
        Archivo archivo4 = new Archivo("foto.jpg", 800);

        Carpeta patrones = new Carpeta("Patrones");
        patrones.agregar(archivo2);
        patrones.agregar(archivo3);

        Carpeta fotos = new Carpeta("Fotos");
        fotos.agregar(archivo4);

        Carpeta raiz = new Carpeta("Facultad");
        raiz.agregar(archivo1);
        raiz.agregar(patrones);
        raiz.agregar(fotos);

        raiz.mostrar(0);

        Console.WriteLine("Tamaño total: " + raiz.obtenerTamano() + " bytes");
    }
}