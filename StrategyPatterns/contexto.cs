using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    public  class contexto{

        private lNextStep proximoPaso;
        
        public contexto(lNextStep proximoPaso) { 
        
        this.proximoPaso = proximoPaso;
        
        
        }

        public void start() {

            this.proximoPaso.finalStep();
        
        }


    }
}
