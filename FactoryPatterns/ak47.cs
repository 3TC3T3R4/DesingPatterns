using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class ak47 : lWeapon
    {


        public void attack() {

            Console.WriteLine("Disparando!");

        }

        public string typeWeapon()
        {
            return "ak47";
        }
    }
}
