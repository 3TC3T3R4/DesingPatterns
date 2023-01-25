namespace SingletonPatterns {

    class Program
    {
        private static void Main(string[] args){


            FucionDragonBall fu = FucionDragonBall.getInstance();

            FucionDragonBall fu2 = FucionDragonBall.getInstance();
            
            FucionDragonBall fu3 = FucionDragonBall.getInstance();

            fu.hacerFucion();

            fu2.deshacerFucion();

            fu3.hacerFucion();

            //Si hicieramos la creacion de la manera normal hariamos esto
            /*
             
            FucionDragonBall fu =  new FucionDragonBall();

            FucionDragonBall fu2 =  new FucionDragonBall();

            FucionDragonBall fu3 =  new FucionDragonBall();

             fu.hacerFucion();

            fu2.deshacerFucion();

            fu3.hacerFucion();

             Tendriamos en memoria 3 instancias en vez de 1 con el patron sigleton

             */

        }

    }
    }