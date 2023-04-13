using Microsoft.VisualBasic;

namespace Clase2.Logica
{
    public class JuegoAhorcado
    {
        private static List<string> PalabrasPosibles = new List<string>()
        {
            //Cosas que pueden estar en la cocina
            "Cuchillo",
            "Cuchara",
            "Tenedor",
            "Plato",
            "Vaso",
            "Mesa",
            "Sarten",
            "Cucharon",
            "Mantel",
            "Copa",
            "Cafetera",
            "Microondas",
            "Refrigerador",
            "Taza",
            "Jarra",
        };
       
        private List<string> LetrasAdivinadas = new List<string>();
        public void Ejecutar()
        {
            var dibujoAhorcado = new DibujoAhorcadoTradicional();
            var dibujadorPalabra = new DibujadorPalabra();
            //Crear lista de palabras posibles con alguna tematica

           
            //usuario ingresa una letra y se valida si pertenece a la palabra, si no pertenece se dibuja una parte del cuerpo del ahorcado

            Console.WriteLine("Elige un modo de juego");
            Console.WriteLine("Ingrese la letra P para principiante / A para avanzado");

            string mood = Console.ReadLine();

            //empezar juego y elegir una palabra

            string palabraElegida = PalabraPosible(mood);

            do
            {
                    //dibujar como se encuentra la palabra ctual con las incognitas y las letras ya descubiertas
                    dibujadorPalabra.DibujarPalabra(mood,palabraElegida, LetrasAdivinadas);
                    Console.WriteLine("Ingrese una letra");
                    string letraIngresada = Console.ReadLine();

                    bool perteneceAPalabra = PerteneceAPalabra(letraIngresada, palabraElegida);
                    if (perteneceAPalabra)
                    {
                        LetrasAdivinadas.Add(letraIngresada);
                        if (!dibujadorPalabra.ObtenerDibujoPalabra(mood,palabraElegida, LetrasAdivinadas).Contains("_"))
                        {
                            Console.WriteLine("Ganaste!");
                            Console.WriteLine($"La palabra era {palabraElegida}");
                            return;
                        }
                    }
                    else
                    {
                        //si no pertenece se dibuja una parte del cuerpo del ahorcado
                        //dibujar parte del cuerpo del ahorcado
                        dibujoAhorcado.DibujarAhorcado();
                        dibujoAhorcado.RestarIntento();
                    }
              
            } while (dibujoAhorcado.QuedanIntentos());
                Console.WriteLine("Has perdido. La palabra era: " + palabraElegida);
            
        }

        public static bool PerteneceAPalabra(string letraIngresada, string palabraElegida)
        {
            return palabraElegida.Contains(letraIngresada, StringComparison.OrdinalIgnoreCase);
        }

        public static string PalabraPosible(string mood){

            string palabraElegida;

            if (mood.ToUpper() == "P"){

                List<string> listaPrincipiante = PalabrasPosibles.Where(palabra => palabra.Length <= 6).ToList();

                palabraElegida = listaPrincipiante[new Random().Next(PalabrasPosibles.Count())];

            }
            else
            {
                List<string> listaPrincipiante = PalabrasPosibles.Where(palabra => palabra.Length > 6).ToList();

                palabraElegida = listaPrincipiante[new Random().Next(PalabrasPosibles.Count())];

            }

            return palabraElegida;
        }
    }
}