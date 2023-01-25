using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    public class noobPlayer : stepSimple
    {
        public override void largestep()
        {
            Console.WriteLine(" Jugador nood dando 1 paso largo");
        }

        public override void mediunstep()
        {
            Console.WriteLine("Jugador noob  dando 1 paso mediano");
        }

        public override void smallstep()
        {
            Console.WriteLine("Jugador noob dando 1 paso corto y este es el movimiento final");
        }
    }
}
