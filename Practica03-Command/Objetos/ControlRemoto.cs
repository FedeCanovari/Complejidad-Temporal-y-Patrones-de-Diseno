namespace Practica03_Command;

public class ControlRemoto
{
    private IComando ultimoComando;

    public void ejecutar(IComando comando)
    {
        comando.ejecutar();
        ultimoComando = comando;
    }

    public void deshacerUltimo()
    {
        if (ultimoComando != null)
        {
            ultimoComando.deshacer();
        }
    }
}