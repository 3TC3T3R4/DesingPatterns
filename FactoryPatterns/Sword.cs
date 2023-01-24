using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public class Sword : lWeapon
    {

        public void attack() {

            Console.WriteLine("Atacando con Espada!! ");
        
        }

        public string typeWeapon()
        {
            return "Espada";
        }



    }
}
