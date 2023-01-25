using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatterns
{
    public class FucionDragonBall
    {
        //private static FucionDragonBall intancia = new FucionDragonBall();
        private static FucionDragonBall instancia;
        private static string valor;

        //Se realiza constructor vacio para no instanciar mediante  como comun mente se hacia "new"
        private FucionDragonBall()
        {

        }


        public static FucionDragonBall getInstance() {

            if (instancia == null) {

               instancia= new FucionDragonBall();

            }
            return instancia;

        }


        public void hacerFucion() {


            Console.WriteLine("FUSION!");
        
        }


        public void deshacerFucion() {

            Console.WriteLine("Se me acabo el kayoken");

        }



    }
}
