/*
 * 
 */

using csharp_spotify_player;

List<IContenutoRiproducibile> media = new List<IContenutoRiproducibile> {
    new Brano("Need to Know", 209, new string[]{"Doja Cat"}, 2021),
    new Podcast("Interfacce", 10852, new string[] {"Bryan Lucchetta", "Emanuele Paratore"}, 2022)
};

foreach (IContenutoRiproducibile contenutoRiproducibile in media) {
    Console.WriteLine($"Contenuto selezionato: {contenutoRiproducibile}");
    contenutoRiproducibile.Play();
    contenutoRiproducibile.Pausa();
    contenutoRiproducibile.Stop();
    Console.WriteLine(Environment.NewLine);
}