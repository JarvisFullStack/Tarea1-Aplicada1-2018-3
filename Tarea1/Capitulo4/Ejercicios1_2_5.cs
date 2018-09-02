using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Capitulo4
{
    class Ejercicios1_2_5
    {
        public static void Ejercicio1()
        {
            int numero;
            Console.WriteLine("Mostrar tabla del numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            int tabla;
            for (int i = 1; i <= 10; ++i)
            {
                tabla = numero * i;
                Console.WriteLine("{0} * {1} = {2}", numero, i, tabla);
            }
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("Base: ");
            int baseNumerica = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite La potencia: ");
            int potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} ^ {1} = {2}", baseNumerica, potencia, Convert.ToInt32(Math.Pow(baseNumerica, potencia)));
        }
        

        public static void Ejercicio5()
        {
            Console.WriteLine("Cantidad de personas: ");
            int nPersonas = Convert.ToInt32(Console.ReadLine());
            int edadMayor = Int32.MinValue;
            int edadMenor = Int32.MaxValue;
            int edad;
            for (int i = 0; i < nPersonas; i++)
            {
                Console.WriteLine("Edad de Persona: {0}", i+1);
                edad = Convert.ToInt32(Console.ReadLine());
                if (edadMayor <= edad)
                    edadMayor = edad;
                if (edadMenor >= edad)
                    edadMenor = edad;
            }

            Console.WriteLine("Mayor es: {0}", edadMayor);
            Console.WriteLine("Menor es: {0}", edadMenor);
        }
    }
}
