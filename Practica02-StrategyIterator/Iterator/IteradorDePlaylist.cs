using Practica02_StrategyIterator.Interfaces;
using Practica02_StrategyIterator.Colecciones;

namespace Practica02_StrategyIterator.Iterator
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