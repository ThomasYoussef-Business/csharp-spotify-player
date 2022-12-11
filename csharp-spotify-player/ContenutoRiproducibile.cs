namespace csharp_spotify_player {
    public class ContenutoRiproducibile : IContenutoRiproducibile {
        // ATTRIBUTI

        // PROPRIETÀ
        public string Nome { get; init; }
        public uint Durata { get; init; }
        public StatoContenutoRiproducibile Stato { get; protected set; } = StatoContenutoRiproducibile.Stopped;

        // COSTRUTTORI
        public ContenutoRiproducibile(string nome, uint durata) {
            Nome = NomeValido(nome);
            Durata = durata;
        }

        // METODI PUBBLICI
        public virtual void Play() {
            Stato = StatoContenutoRiproducibile.Playing;
            Console.WriteLine($"Riproduzione di {this}");
        }
        public virtual void Stop() {
            Stato = StatoContenutoRiproducibile.Stopped;
            Console.WriteLine($"Fermata la riproduzione di {this}");
        }
        public virtual void Pausa() {
            Stato = StatoContenutoRiproducibile.Paused;
            Console.WriteLine($"Messa in pausa la riproduzione di {this}");
        }
        public override string ToString() {
            return Nome;
        }

        // METODI PRIVATI
        private static string NomeValido(string nome) {
            if (!string.IsNullOrWhiteSpace(nome)) {
                return nome;
            }
            else {
                throw new ArgumentNullException(nameof(nome), $"{nameof(nome)} non può essere nullo o vuoto.");
            }
        }
    }
}
