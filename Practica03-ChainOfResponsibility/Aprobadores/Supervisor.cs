namespace Practica03_ChainOfResponsibility;

public class Supervisor : AprobadorDeGastos
{
    public override void aprobar(SolicitudDeGasto solicitud)
    {
        if (solicitud.getMonto() <= 1000)
        {
            Console.WriteLine("Supervisor aprobó: " + solicitud.getDescripcion());
        }
        else
        {
            base.aprobar(solicitud);
        }
    }
}