using Practica03_Adapter.Interfaces;

namespace Practica03_Adapter;

public class AdaptadorReproductorAvanzado : IReproductor
{
    private ReproductorAvanzadoExterno reproductorExterno;

    public AdaptadorReproductorAvanzado(ReproductorAvanzadoExterno reproductorExterno)
    {
        this.reproductorExterno = reproductorExterno;
    }

    public void reproducir(string archivo)
    {
        if (archivo.EndsWith(".avi"))
        {
            reproductorExterno.reproducirArchivoAvi(archivo);
        }
        else if (archivo.EndsWith(".mp4"))
        {
            reproductorExterno.reproducirArchivoMp4(archivo);
        }
    }
}