namespace Practica03_ChainOfResponsibility;

public class SolicitudDeGasto
{
    private double monto;
    private string descripcion;

    public SolicitudDeGasto(double monto, string descripcion)
    {
        this.monto = monto;
        this.descripcion = descripcion;
    }

    public double getMonto()
    {
        return monto;
    }

    public string getDescripcion()
    {
        return descripcion;
    }
}