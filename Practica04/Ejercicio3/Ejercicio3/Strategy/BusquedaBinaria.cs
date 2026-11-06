namespace Practica4.Strategy;

public class BusquedaBinaria : EstrategiaDeBusqueda
{
    public Alumno buscar(List<Alumno> alumnos, int legajo)
    {
        // La lista tiene que estar ordenada por legajo.
        int primeraPosicion = 0;
        int ultimaPosicion = alumnos.Count - 1;

        while (primeraPosicion <= ultimaPosicion)
        {
            int posicionDelMedio = (primeraPosicion + ultimaPosicion) / 2;
            Alumno alumnoDelMedio = alumnos[posicionDelMedio];
            int legajoDelMedio = alumnoDelMedio.getLegajo();

            Contador.sumar();

            if (legajoDelMedio == legajo)
            {
                return alumnoDelMedio;
            }
            else if (legajoDelMedio < legajo)
            {
                // Si el legajo buscado es mayor, seguimos por la derecha.
                primeraPosicion = posicionDelMedio + 1;
            }
            else
            {
                // Si es menor, seguimos por la izquierda.
                ultimaPosicion = posicionDelMedio - 1;
            }
        }

        return null;
    }
}
