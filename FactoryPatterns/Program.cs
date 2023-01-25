namespace FactoryPatterns {

    public class Program {


        public static void Main(string[] args){

            lWeapon choose1 = EstadosUnidos.CreateWeapon("bazuka");

            choose1.attack();
    
        }
    }
}