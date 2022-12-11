namespace csharp_spotify_player {
    public class Podcast : ContenutoRiproducibile {
        // ATTRIBUTI


        // PROPRIETÀ


        // COSTRUTTORI
        public Podcast(string nome, uint durata, string[] autori, int annoDiRilascio) : base(nome, durata, autori, annoDiRilascio) { }

        // METODI PUBBLICI
        public override void Play() {
            Stato = StatoContenutoRiproducibile.Playing;
            Console.WriteLine($"Riproduzione del podcast {Nome}, da {string.Join(", ", Autori)}");
        }

        public override void Stop() {
            Stato = StatoContenutoRiproducibile.Stopped;
            Console.WriteLine($"Fermata la riproduzione del podcast {Nome}, da {string.Join(", ", Autori)}");
        }
        public override void Pausa() {
            Stato = StatoContenutoRiproducibile.Paused;
            Console.WriteLine($"Messa in pausa la riproduzione del podcast {Nome}, da {string.Join(", ", Autori)}");
        }

        public override string ToString() {
            return $"{Nome}, da {string.Join(", ", Autori)}";
        }

        // METODI PRIVATI
    }
}
