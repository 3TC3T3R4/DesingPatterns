using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    public abstract class stepSimple: lNextStep
    {



        public void finalStep()
        {

            smallstep();
            mediunstep();
            largestep();

        }


        public abstract void smallstep();
        public abstract void mediunstep();
        public abstract void largestep();





    }
}
