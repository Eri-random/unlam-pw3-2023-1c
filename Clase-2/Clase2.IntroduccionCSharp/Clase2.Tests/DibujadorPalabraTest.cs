using Clase2.Logica;
using Xunit;

namespace Clase2.Tests
{
    public class DibujadorPalabraTest
    {
        [Fact]
        public void DibujarPalabra_DibujaPalabraConGuiones()
        {
            // Arrange
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "microondas";
            var letrasAdivinadas = new List<string>();
            var mood = "A";
            var palabraEsperada = "_ _ _ _ _ _ _ _ _ _";
            // Act
            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(mood,palabraElegida, letrasAdivinadas);
            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }
        [Fact]
        public void DibujarPalabra_DibujaPalabraConGuionesYLetras()
        {
            // Arrange
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "hola";
            var letrasAdivinadas = new List<string> { "o", "a" };
            var palabraEsperada = "h o _ a";
            var mood = "P";
            // Act
            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(mood,palabraElegida, letrasAdivinadas);
            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }

        [Fact]
        public void DibujarPalabra_DibujaPalabraConGuionesYLetrasRepetidas()
        {
            // Arrange
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "tenedor";
            var letrasAdivinadas = new List<string> { "e", "o" };
            var palabraEsperada = "_ e _ e _ o _";
            var mood = "A";
            // Act
            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(mood,palabraElegida, letrasAdivinadas);
            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }

        [Fact]
        public void DibujarPalabra_DibujaPalabraConPrimerLetra()
        {
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "vaso";
            var letrasAdivinadas = new List<string> { };
            var palabraEsperada = "v _ _ _";
            var mood = "P";

            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(mood, palabraElegida, letrasAdivinadas);

            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }

        [Fact]
        public void DibujarPalabra_DibujarPalabraConPrimeraLetraYApariciones()
        {
            var dibujadorPalabra = new DibujadorPalabra();
            var palabraElegida = "cuchara";
            var letrasAdivinadas = new List<string> { };
            var palabraEsperada = "c _ c _ _ _ _";
            var mood = "P";

            var palabraADibujar = dibujadorPalabra.ObtenerDibujoPalabra(mood, palabraElegida, letrasAdivinadas);

            // Assert
            Assert.Equal(palabraEsperada, palabraADibujar);
        }
    }
}