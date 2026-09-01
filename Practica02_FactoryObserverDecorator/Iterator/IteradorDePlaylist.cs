using Practica02_FactoryObserverDecorator.Interfaces;
using Practica02_FactoryObserverDecorator.Colecciones;

namespace Practica02_FactoryObserverDecorator.Iterator
{
    public class IteradorDePlaylist : Iterador
    {
        private Playlist playlist;
        private int posicion;

        public IteradorDePlaylist(Playlist playlist)
        {
            this.playlist = playlist;
            primero();
        }

        public void primero()
        {
            posicion = 0;
        }

        public void siguiente()
        {
            posicion++;
        }

        public bool fin()
        {
            return posicion >= playlist.cuantos();
        }

        public Comparable actual()
        {
            return playlist.getElementos()[posicion];
        }
    }
}
