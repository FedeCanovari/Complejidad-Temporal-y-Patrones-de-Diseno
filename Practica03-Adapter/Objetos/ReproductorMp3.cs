using Practica03_Adapter.Interfaces;

namespace Practica03_Adapter.Objetos;

public class ReproductorMp3 : IReproductor
{
    public void reproducir(string archivo)
    {
        Console.WriteLine("Reproduciendo archivo MP3: " + archivo);
    }
}