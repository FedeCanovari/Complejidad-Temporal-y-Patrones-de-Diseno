namespace Practica4.Strategy;

public class BusquedaLineal : EstrategiaDeBusqueda
{
    public Alumno buscar(List<Alumno> alumnos, int legajo)
    {
        // Recorremos la lista desde el primer alumno hasta encontrar el legajo.
        foreach (Alumno alumno in alumnos)
        {
            Contador.sumar();

            if (alumno.getLegajo() == legajo)
            {
                return alumno;
            }
        }

        return null;
    }
}
