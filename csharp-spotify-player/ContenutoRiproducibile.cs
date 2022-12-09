namespace csharp_spotify_player {
    public class ContenutoRiproducibile : IContenutoRiproducibile {
        // ATTRIBUTI
        
        // PROPRIETÀ
        public string Nome { get; init; }
        public StatoMedia Stato { get; private set; }

        // COSTRUTTORI

        // METODI PUBBLICI
        public void Play() {
            Stato = StatoMedia.Playing;
        }
        public void Stop() {
            Stato = StatoMedia.Stopped;
        }
        public void Pausa() {
            Stato = StatoMedia.Paused;
        }
        public override string ToString() {
            return $"";
        }

        // METODI PRIVATI
    }
}
