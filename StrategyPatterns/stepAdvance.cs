using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    public abstract class stepAdvance: lNextStep 
    {

        public void finalStep()
        {

            twoSmallStep();
            fiveMediunStep();
            nineLargeStep();

        }


        public abstract void twoSmallStep();
        public abstract void fiveMediunStep();
        public abstract void nineLargeStep();




    }
}
