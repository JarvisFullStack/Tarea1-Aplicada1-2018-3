using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Capitulo2
{
    class Ejercicios1_3_5
    {
        public static void Ejercicio1()
        {
            float perimetro;
            float longitud;
            float nlados;
            Console.WriteLine("Numero de lados : ");
            nlados = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Logitud de lado : ");
            longitud = Convert.ToSingle(Console.ReadLine());
            perimetro = nlados = longitud;
            Console.WriteLine("Perimetro: {0}", perimetro);

        }

        public static void Ejercicio3() {
            float radianes, grados;
            Console.WriteLine("Grados: ");
            grados = Convert.ToSingle(Console.ReadLine());
            radianes = (Convert.ToSingle(Math.PI / 180)) * grados;
            Console.WriteLine("Radianes: {0}", radianes);
        }

        public static void Ejercicio4() {
            Console.WriteLine("Grados Celcius: ");
            float fahrenheit = (((Convert.ToSingle(Console.ReadLine())) * 1.8f) + 32);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);
        }

        public static void Ejercicio5() {
            Console.WriteLine("Cantidad de dolares: ");
            double dolares = Convert.ToDouble(Console.ReadLine());
            double euro = 0.86f;
            double dolaresEuro = dolares * euro;
            Console.WriteLine("{0} dolares = {1} Euros", dolares, dolaresEuro);

        }
    }
}
