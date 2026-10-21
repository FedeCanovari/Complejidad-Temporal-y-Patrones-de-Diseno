namespace Practica02_Decorator.Decorator
{
    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(IMostrable objetoRecibido)
            : base(objetoRecibido)
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
