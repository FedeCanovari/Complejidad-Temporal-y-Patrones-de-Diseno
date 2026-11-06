namespace Practica4.Proxy;

public class ServicioDeAlumnosConCache : IServicioDeAlumnos
{
    private IServicioDeAlumnos servicioReal;
    private Dictionary<int, Alumno> cache;

    public ServicioDeAlumnosConCache(IServicioDeAlumnos servicioReal)
    {
        this.servicioReal = servicioReal;
        cache = new Dictionary<int, Alumno>();
    }

    public Alumno buscarAlumno(int legajo)
    {
        // Si ya lo buscamos antes, lo devolvemos desde la cache.
        if (cache.ContainsKey(legajo))
        {
            return cache[legajo];
        }

        // Si no esta en la cache, lo buscamos en el servicio real.
        Alumno alumno = servicioReal.buscarAlumno(legajo);

        if (alumno != null)
        {
            // Guardamos solo los alumnos que encontramos.
            cache.Add(legajo, alumno);
        }

        return alumno;
    }
}
