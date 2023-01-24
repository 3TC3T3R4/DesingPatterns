using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class WeaponFactory
    {


        public static lWeapon CreateWeapon(string typeWeapon) {
            switch (typeWeapon)
            {

                case "Arco":
                    return new Bow();

                    break;


                case "Espada":
                    return new Sword();

                    break;

                default:

                    Console.WriteLine("No se encuentra dicha arma en la fabrica");
                    return null;

            }

        }
    }
}
