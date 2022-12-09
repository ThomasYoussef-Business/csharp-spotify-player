

using FluentAssertions;
using Xunit;
namespace csharp_spotify_player.Tests {
    public class ContenutoRiproducibileTests {
        [Theory()]
        [InlineData("mySong", uint.MaxValue)]
        [InlineData("Mysong", 42873847)]
        [InlineData("mYSoNG", 100)]
        [InlineData(".", 1)]
        [InlineData("èèÈéééé'eèe'e'd''daà'à''àò''òù''u", 0)]
        public void ContenutoRiproducibileTest(string nome, uint durataSecondi) {
            // Arrange
            ContenutoRiproducibile myContenuto;
            string nomeAspettato = nome;
            uint durataAspettata = durataSecondi;

            // Act
            myContenuto = new(nome, durataSecondi);

            // Assert
            myContenuto.Nome.Should().Be(nomeAspettato);
            myContenuto.Durata.Should().Be(durataAspettata);
        }

        [Fact()]
        public void PlayTest() {
            // Arrange
            var myContenuto = new ContenutoRiproducibile("MySong", 100);
            var expectedResult = StatoContenutoRiproducibile.Playing;

            // Act
            myContenuto.Play();
            var result = myContenuto.Stato;

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact()]
        public void StopTest() {
            // Arrange
            var myContenuto = new ContenutoRiproducibile("MySong", 100);
            var expectedResult = StatoContenutoRiproducibile.Stopped;

            // Act
            myContenuto.Stop();
            var result = myContenuto.Stato;

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact()]
        public void PausaTest() {
            // Arrange
            var myContenuto = new ContenutoRiproducibile("MySong", 100);
            var expectedResult = StatoContenutoRiproducibile.Paused;

            // Act
            myContenuto.Pausa();
            var result = myContenuto.Stato;

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("Mysong", 100)]
        public void ToStringTest(string nome, uint durataSecondi) {
            // Arrange
            var myContenuto = new ContenutoRiproducibile(nome, durataSecondi);

            // Act
            var result = myContenuto.ToString();

            // Assert
            result.Should().NotBeNullOrWhiteSpace().And.Contain(nome);
        }
    }
}