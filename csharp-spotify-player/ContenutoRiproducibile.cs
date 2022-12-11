namespace csharp_spotify_player {
    public class ContenutoRiproducibile : IContenutoRiproducibile {
        // ATTRIBUTI

        // PROPRIETÀ
        public string Nome { get; protected init; }
        public uint Durata { get; protected init; }
        public string[] Autori { get; protected init; }
        public int AnnoDiRilascio { get; private init; }
        public StatoContenutoRiproducibile Stato { get; protected set; } = StatoContenutoRiproducibile.Stopped;

        // COSTRUTTORI
        public ContenutoRiproducibile(string nome, uint durata) {
            Nome = NomeValido(nome);
            Durata = durata;
        }

        public ContenutoRiproducibile(string nome, uint durata, string[] autori) : this(nome, durata) {
            Autori = AutoriValidi(autori);
        }

        public ContenutoRiproducibile(string nome, uint durata, string[] autori, int annoDiRilascio) : this(nome, durata, autori) {
            AnnoDiRilascio = annoDiRilascio;
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
        protected static string NomeValido(string nome) {
            if (!string.IsNullOrWhiteSpace(nome)) {
                return nome;
            }
            else {
                throw new ArgumentNullException(nameof(nome), $"{nameof(nome)} non può essere nullo o vuoto.");
            }
        }
        protected static string[] AutoriValidi(string[] autori) {
            if (!autori.Any()) {
                throw new ArgumentException($"{nameof(autori)} non può essere vuoto", nameof(autori));
            }
            else {
                return autori;
            }
        }
    }
}
