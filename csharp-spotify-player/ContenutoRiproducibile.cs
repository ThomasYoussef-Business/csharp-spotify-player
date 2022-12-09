namespace csharp_spotify_player {
    public class ContenutoRiproducibile : IContenutoRiproducibile {
        public StatoMedia Stato { get; private set; }
        public void Play() {
            Stato = StatoMedia.Playing;
        }
        public void Stop() {
            Stato = StatoMedia.Stopped;
        }
        public void Pausa() {
            Stato = StatoMedia.Paused;
        }
    }
}
