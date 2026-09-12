namespace Practica03_Command;

public class ComandoApagarLuz : IComando
{
    private Luz luz;

    public ComandoApagarLuz(Luz luz)
    {
        this.luz = luz;
    }

    public void ejecutar()
    {
        luz.apagar();
    }

    public void deshacer()
    {
        luz.encender();
    }
}