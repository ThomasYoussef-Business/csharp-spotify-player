namespace csharp_spotify_player {
    public class Brano : ContenutoRiproducibile {

        // ATTRIBUTI


        // PROPRIETÀ
        public string[] Autori { get; private init; }
        public int AnnoDiRilascio { get; private init; }

        // COSTRUTTORI
        public Brano(string nome, uint durata, string[] autori, int annoDiRilascio) : base(nome, durata) {
            Autori = AutoriValidi(autori);
            AnnoDiRilascio = annoDiRilascio;
        }



        // METODI PUBBLICI
        public override void Play() {
            Stato = StatoContenutoRiproducibile.Playing;
            Console.WriteLine($"Riproduzione del brano {Nome}");
        }

        public override void Stop() {
            Stato = StatoContenutoRiproducibile.Stopped;
            Console.WriteLine($"Fermata la riproduzione del brano {Nome}");
        }
        public override void Pausa() {
            Stato = StatoContenutoRiproducibile.Paused;
            Console.WriteLine($"Messa in pausa la riproduzione del brano {Nome}");
        }

        public override string ToString() {
            return $"{Nome}, by {string.Join(", ", Autori)}";
        }

        // METODI PRIVATI
        private static string[] AutoriValidi(string[] autori) {
            if (!autori.Any()) {
                throw new ArgumentException($"{nameof(autori)} non può essere vuoto", nameof(autori));
            }
            else {
                return autori;
            }
        }

    }
}
