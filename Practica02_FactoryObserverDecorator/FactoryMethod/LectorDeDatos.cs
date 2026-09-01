namespace Practica02_FactoryObserverDecorator.FactoryMethod
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            return int.Parse(Console.ReadLine());
        }

        public string stringPorTeclado()
        {
            return Console.ReadLine();
        }
    }
}