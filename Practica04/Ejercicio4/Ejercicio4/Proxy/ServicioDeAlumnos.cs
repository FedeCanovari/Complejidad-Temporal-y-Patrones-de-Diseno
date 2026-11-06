namespace Practica4.Proxy;

public class ServicioDeAlumnos : IServicioDeAlumnos
{
    private List<Alumno> alumnos;

    public ServicioDeAlumnos(int cantidadDeAlumnos)
    {
        alumnos = new List<Alumno>();

        for (int i = 1; i <= cantidadDeAlumnos; i++)
        {
            alumnos.Add(new Alumno(i, "Alumno " + i));
        }
    }

    public Alumno buscarAlumno(int legajo)
    {
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
