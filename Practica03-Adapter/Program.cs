using Practica03_Adapter.Interfaces;
using Practica03_Adapter.Objetos;

namespace Practica03_Adapter;

public class Program
{
    static void ReproducirArchivo(IReproductor reproductor, string archivo)
    {
        reproductor.reproducir(archivo);
    }

    public static void Main(string[] args)
    {
        ReproductorMp3 reproductorMp3 = new ReproductorMp3();

        ReproductorAvanzadoExterno reproductorExterno =
            new ReproductorAvanzadoExterno();

        AdaptadorReproductorAvanzado adaptador =
            new AdaptadorReproductorAvanzado(reproductorExterno);

        ReproducirArchivo(reproductorMp3, "cancion.mp3");
        ReproducirArchivo(adaptador, "video.avi");
        ReproducirArchivo(adaptador, "pelicula.mp4");
    }
}