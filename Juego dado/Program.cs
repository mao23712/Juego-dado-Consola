using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_dado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de dados!");

            while (true)
            {
                Console.Write("¿Quieres apostar por mayor o menor? (m/M para menor, cualquier otra tecla para mayor): ");
                string opcion = Console.ReadLine();

                int minimo, maximo;
                if (opcion.ToLower() == "m")
                {
                    minimo = 1;
                    maximo = 3;
                }
                else
                {
                    minimo = 4;
                    maximo = 6;
                }

                Console.Write($"Ingresa tu apuesta (entre {minimo * 2} y {maximo * 2}): ");
                int apuesta;
                while (!int.TryParse(Console.ReadLine(), out apuesta) || apuesta < minimo * 2 || apuesta > maximo * 2)
                {
                    Console.Write($"Error. Ingresa una apuesta válida (entre {minimo * 2} y {maximo * 2}): ");
                }

                int dado1 = Dados.Lanzar();
                int dado2 = Dados.Lanzar();
                int suma = dado1 + dado2;
                Console.WriteLine($"Los dados han salido: {dado1} y {dado2}. La suma es: {suma}");

                if (suma == 7)
                {
                    Console.WriteLine("¡La casa gana!");
                }
                else if (suma >= minimo * 2 && suma <= maximo * 2)
                {
                    Console.WriteLine("¡Ganaste!");
                }
                else
                {
                    Console.WriteLine("Perdiste :(");
                }

                Console.Write("¿Quieres jugar de nuevo? (s/n): ");
                string jugarDeNuevo = Console.ReadLine();
                if (!jugarDeNuevo.ToLower().StartsWith("s"))
                {
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("¡Gracias por jugar!");
        }
    }
}
