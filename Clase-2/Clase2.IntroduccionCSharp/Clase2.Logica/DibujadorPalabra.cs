using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.Logica
{
    public class DibujadorPalabra
    {
        public void DibujarPalabra(string mood,string palabraElegida, List<string> letrasAdivinadas)
        {
            string palabraADibujar = ObtenerDibujoPalabra(mood, palabraElegida, letrasAdivinadas);
            Console.WriteLine(palabraADibujar);
        }

        public string ObtenerDibujoPalabra(string mood,string palabraElegida, List<string> letrasAdivinadas)
        {
            string palabraADibujar = "";

            foreach (char letra in palabraElegida){

                if (mood.ToUpper() == "P"){
                    letrasAdivinadas.Add(palabraElegida[0].ToString());
                }

                
                if (letrasAdivinadas.Contains(letra.ToString(), StringComparer.OrdinalIgnoreCase)){
                    palabraADibujar += $"{letra} ";
                }
                else{
                    palabraADibujar += "_ ";
                }
            }
            return palabraADibujar.Trim();
        }

    }
}
