namespace StrategyPatterns
{

    class Program
    {
        private static void Main(string[] args){
  

            contexto con  = new contexto(new advancePlayer());
            con.start();
        
        
        
        }
    }
}
