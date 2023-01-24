using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class Bow : lWeapon
    {


        public void attack() {

            Console.WriteLine("Atacando con Arco!");

        }

        public string typeWeapon()
        {
            return "Arco";
        }
    }
}
