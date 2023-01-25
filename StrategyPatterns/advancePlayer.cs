using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    public class advancePlayer : stepAdvance
    {
        

        public override void nineLargeStep()
        {

            Console.WriteLine("Jugador avanzado dando 9 pasos largos");
        }
        public override void fiveMediunStep()
        {
            Console.WriteLine("Jugador avanzado dando 5 pasos medianos");
        }

        public override void twoSmallStep()
        {

            Console.WriteLine("Jugador avanzado dando 2 pasos cortos y este es el movimiento final");
        }
    }
}
