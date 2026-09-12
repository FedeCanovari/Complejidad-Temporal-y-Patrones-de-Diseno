namespace Practica03_ChainOfResponsibility;

public class Gerente : AprobadorDeGastos
{
    public override void aprobar(SolicitudDeGasto solicitud)
    {
        if (solicitud.getMonto() <= 5000)
        {
            Console.WriteLine("Gerente aprobó: " + solicitud.getDescripcion());
        }
        else
        {
            base.aprobar(solicitud);
        }
    }
}