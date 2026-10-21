using Practica02_Iterator.Interfaces;
using Practica02_Iterator.Colecciones;

namespace Practica02_Iterator.Iterator
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
