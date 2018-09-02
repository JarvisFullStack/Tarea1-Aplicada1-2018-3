using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Capitulo1;
using Tarea1.Capitulo2;
using Tarea1.Capitulo3;
using Tarea1.Capitulo4;
namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. C1-E1");
                Console.WriteLine("2. C1-E5");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("3. C2-E1");
                Console.WriteLine("4. C2-E3");
                Console.WriteLine("5. C2-E5");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("6. C3-E1");
                Console.WriteLine("7. C3-E4");
                Console.WriteLine("8. C3-E5");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("9. C4-E1");
                Console.WriteLine("10. C4-E2");
                Console.WriteLine("11. C4-E5");
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Ejercicios1_5.Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Ejercicios1_5.Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 3:
                        Ejercicios1_3_5.Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 4:
                        Ejercicios1_3_5.Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 5:
                        Ejercicios1_3_5.Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Ejercicios1_4_5.Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 7:
                        Ejercicios1_4_5.Ejercicio4();
                        Console.ReadKey();
                        break;
                    case 8:
                        Ejercicios1_4_5.Ejercicio5();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != -1);
        }
    }
}
