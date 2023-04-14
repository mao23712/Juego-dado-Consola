using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_dado
{
    public class Dados
    {
        private static Random random = new Random();

        public static int Lanzar()
        {
            return random.Next(1, 7);
        }
    }
}
