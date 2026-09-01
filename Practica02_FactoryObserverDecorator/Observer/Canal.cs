namespace Practica02_FactoryObserverDecorator.Observer
{
    public class Canal : IObservado
    {
        private string nombre;
        private bool enVivo;
        private List<IObservador> observadores;

        public Canal(string n)
        {
            nombre = n;
            enVivo = false;
            observadores = new List<IObservador>();
        }

        public void publicarContenido()
        {
            enVivo = false;

            Console.WriteLine(nombre + " publicó contenido nuevo");

            notificar();
        }

        public void iniciarEnVivo()
        {
            enVivo = true;

            Console.WriteLine(nombre + " está en vivo");

            notificar();
        }

        public bool estaEnVivo()
        {
            return enVivo;
        }

        public void agregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (IObservador observador in observadores)
            {
                observador.actualizar(this);
            }
        }
    }
}
