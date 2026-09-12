namespace Practica03_Singleton;

public class ConfiguracionDelSistema
{
    private static ConfiguracionDelSistema instancia;

    private Dictionary<string, string> valores;

    private ConfiguracionDelSistema()
    {
        valores = new Dictionary<string, string>();
    }

    public static ConfiguracionDelSistema obtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new ConfiguracionDelSistema();
        }

        return instancia;
    }

    public void establecerValor(string clave, string valor)
    {
        valores[clave] = valor;
    }

    public string obtenerValor(string clave)
    {
        return valores[clave];
    }
}