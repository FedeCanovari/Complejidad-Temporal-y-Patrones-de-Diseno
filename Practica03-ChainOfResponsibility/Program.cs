namespace Practica03_ChainOfResponsibility;

public class Program
{
    public static void Main(string[] args)
    {
        Supervisor supervisor = new Supervisor();
        Gerente gerente = new Gerente();
        Director director = new Director();

        supervisor.setSucesor(gerente);
        gerente.setSucesor(director);

        SolicitudDeGasto solicitud1 =
            new SolicitudDeGasto(500, "Compra de útiles");

        SolicitudDeGasto solicitud2 =
            new SolicitudDeGasto(3000, "Compra de monitor");

        SolicitudDeGasto solicitud3 =
            new SolicitudDeGasto(10000, "Compra de computadoras");

        supervisor.aprobar(solicitud1);
        supervisor.aprobar(solicitud2);
        supervisor.aprobar(solicitud3);

        Console.WriteLine();

        Supervisor supervisorSolo = new Supervisor();

        SolicitudDeGasto solicitud4 =
            new SolicitudDeGasto(2000, "Compra sin aprobador suficiente");

        supervisorSolo.aprobar(solicitud4);
    }
}

