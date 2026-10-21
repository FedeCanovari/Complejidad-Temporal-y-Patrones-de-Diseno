namespace Practica02_Decorator.Objetos
{
    public abstract class Perfil
    {
        private string nombre;
        private int id;

        public Perfil(string n, int i)
        {
            nombre = n;
            id = i;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getId()
        {
            return id;
        }

    }
}
