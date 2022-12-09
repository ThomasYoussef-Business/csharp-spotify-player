namespace csharp_spotify_player {
    public interface IContenutoRiproducibile {
        StatoMedia Stato { get; }
        void Pausa();
        void Play();
        void Stop();
    }

    public enum StatoMedia {
        Playing,
        Paused,
        Stopped
    }
}