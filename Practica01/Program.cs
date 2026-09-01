

using Practica01.Interfaces;
using Practica01.Objetos;
using Practica01.Colecciones;

Pila pila = new Pila();
Cola cola = new Cola();
Catalogo catalogo = new Catalogo(pila, cola);

Random random = new Random();

llenarSuscriptores(pila);
llenarSuscriptores(cola);

Console.WriteLine("CATÁLOGO");
informar(catalogo);
void llenar(Coleccionable coleccionable)
{
    try
    {
        for (int i = 0; i < 20; i++)
        {
            Comparable comparable = new Visualizacion(random.Next(1, 101));
            coleccionable.agregar(comparable);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Error en llenar: " + e.Message);
    }
}


void informar(Coleccionable coleccionable)
{
    try
    {
        Console.WriteLine("Cantidad: " + coleccionable.cuantos());

        Console.WriteLine("Mínimo: " + coleccionable.minimo());
        Console.WriteLine("Máximo: " + coleccionable.maximo());

        Console.Write("Ingrese una cantidad de visualizaciones: ");
        int valor = int.Parse(Console.ReadLine());

        Comparable comparable = new Visualizacion(valor);

        if (coleccionable.contiene(comparable))
        {
            Console.WriteLine("El elemento leído está en la colección");
        }
        else
        {
            Console.WriteLine("El elemento leído no está en la colección");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Error en informar: " + e.Message);
    }
}


void llenarSuscriptores(Coleccionable coleccionable)
{
    try
    {
        string[] nombres =
        {
            "Ana", "Bruno", "Carla", "Diego", "Elena",
            "Facundo", "Gisela", "Hugo", "Irene", "Juan"
        };

        for (int i = 0; i < 20; i++)
        {
            string nombre = nombres[random.Next(nombres.Length)];
            int id = random.Next(1000, 10000);
            int meses = random.Next(1, 121);
            int horas = random.Next(1, 2001);

            Comparable suscriptor =
                new Suscriptor(nombre, id, meses, horas);

            coleccionable.agregar(suscriptor);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Error al llenar suscriptores: " + e.Message);
    }
}