using Practica01.Interfaces;

namespace Practica01.Objetos
{
    public abstract class Perfil : Comparable
    {
        protected string nombre;
        protected int id;

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

        public virtual bool sosIgual(Comparable comparable)
        {
            Perfil perfil = (Perfil)comparable;
            return id == perfil.getId();
        }

        public virtual bool sosMenor(Comparable comparable)
        {
            Perfil perfil = (Perfil)comparable;
            return id < perfil.getId();
        }

        public virtual bool sosMayor(Comparable comparable)
        {
            Perfil perfil = (Perfil)comparable;
            return id > perfil.getId();
        }
    }
}