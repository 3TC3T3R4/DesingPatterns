using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public class bazuka : lWeapon
    {

        public void attack() {

            Console.WriteLine("Lanzando bombas!! ");
        
        }

        public string typeWeapon()
        {
            return "bazuka";
        }



    }
}
