namespace Practica03_Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        ConfiguracionDelSistema configuracion1 =
            ConfiguracionDelSistema.obtenerInstancia();

        ConfiguracionDelSistema configuracion2 =
            ConfiguracionDelSistema.obtenerInstancia();

        configuracion1.establecerValor("idioma", "Español");

        Console.WriteLine(configuracion2.obtenerValor("idioma"));

        Console.WriteLine(configuracion1 == configuracion2);
    }
}