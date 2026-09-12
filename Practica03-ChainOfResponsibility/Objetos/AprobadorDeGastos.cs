namespace Practica03_ChainOfResponsibility;

public abstract class AprobadorDeGastos
{
    private AprobadorDeGastos? sucesor;

    public void setSucesor(AprobadorDeGastos sucesor)
    {
        this.sucesor = sucesor;
    }

    public virtual void aprobar(SolicitudDeGasto solicitud)
    {
        if (sucesor != null)
        {
            sucesor.aprobar(solicitud);
        }
        else
        {
            Console.WriteLine("Nadie pudo aprobar la solicitud");
        }
    }
}