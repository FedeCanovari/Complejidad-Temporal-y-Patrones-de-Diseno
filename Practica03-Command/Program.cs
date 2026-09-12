namespace Practica03_Command;

public class Program
{
    public static void Main(string[] args)
    {
        Luz luz = new Luz();

        ComandoEncenderLuz encender = new ComandoEncenderLuz(luz);
        ComandoApagarLuz apagar = new ComandoApagarLuz(luz);

        ControlRemoto control = new ControlRemoto();

        control.ejecutar(encender);
        control.ejecutar(apagar);

        control.deshacerUltimo();
    }
}