/*
 * Creiamo un’interfaccia IContenutoRiproducibile che definisce un contratto affinché un contenuto sia riproducibile,
 * e che quindi garantisca le seguenti funzionalità:
 *  [x] Play(): metodo che deve permettere di riprodurre un contenuto audio.
 *  [x] Pausa(): metodo che permette di mettere in pausa un contenuto
 *  [x] Stop(): metodo che permette di interrompere la riproduzione dell’audio.
 */

namespace csharp_spotify_player {
    public interface IContenutoRiproducibile {
        public void Play();
        public void Pausa();
        public void Stop();
    }
}
