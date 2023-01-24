namespace FactoryPatterns {

    public class Program {


        public static void Main(string[] args){

            lWeapon choose1 = WeaponFactory.CreateWeapon("Espada");

            choose1.attack();
    
        }
    }
}