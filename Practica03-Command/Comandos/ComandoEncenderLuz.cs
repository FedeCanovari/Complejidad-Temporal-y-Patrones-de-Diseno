namespace Practica03_Command;

public class ComandoEncenderLuz : IComando
{
    private Luz luz;

    public ComandoEncenderLuz(Luz luz)
    {
        this.luz = luz;
    }

    public void ejecutar()
    {
        luz.encender();
    }

    public void deshacer()
    {
        luz.apagar();
    }
}