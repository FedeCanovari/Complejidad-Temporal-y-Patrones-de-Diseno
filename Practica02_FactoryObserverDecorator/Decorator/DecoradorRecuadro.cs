namespace Practica02_FactoryObserverDecorator.Decorator
{
    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(IMostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            string info =
                componente.mostrarInfo();

            string linea =
                new string('*', info.Length + 4);

            return linea + "\n" +
                   "* " + info + " *\n" +
                   linea;
        }
    }
}