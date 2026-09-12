namespace Practica03_ChainOfResponsibility;

public class Director : AprobadorDeGastos
{
    public override void aprobar(SolicitudDeGasto solicitud)
    {
        Console.WriteLine("Director aprobó: " + solicitud.getDescripcion());
    }
}
