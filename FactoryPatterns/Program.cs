namespace FactoryPatterns {

    public class Program {


        public static void Main(string[] args){

            lWeapon choose1 = EstadosUnidos.CreateWeapon("ak47");

            choose1.attack();
    
        }
    }
}