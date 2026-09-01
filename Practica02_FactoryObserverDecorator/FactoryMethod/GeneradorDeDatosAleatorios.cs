namespace Practica02_FactoryObserverDecorator.FactoryMethod
{
    public class GeneradorDeDatosAleatorios
    {
        private Random random = new Random();

        public int numeroAleatorio(int max)
        {
            return random.Next(max + 1);
        }

        public string stringAleatorio(int cant = 10)
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string resultado = "";

            for (int i = 0; i < cant; i++)
            {
                resultado += caracteres[random.Next(caracteres.Length)];
            }

            return resultado;
        }
    }
}