using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class EstadosUnidos
    {


        public static lWeapon CreateWeapon(string typeWeapon) {
            switch (typeWeapon)
            {

                case "ak47":
                    return new ak47();

                    break;


                case "bazuka":
                    return new bazuka();

                    break;

                default:

                    Console.WriteLine("No se encuentra dicha arma en la fabrica");
                    return null;

            }

        }
    }
}
