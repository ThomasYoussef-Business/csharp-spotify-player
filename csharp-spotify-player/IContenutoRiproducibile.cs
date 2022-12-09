namespace csharp_spotify_player {
    public interface IContenutoRiproducibile {
        StatoContenutoRiproducibile Stato { get; }
        void Pausa();
        void Play();
        void Stop();
    }

    public enum StatoContenutoRiproducibile {
        Stopped,
        Playing,
        Paused
    }
}