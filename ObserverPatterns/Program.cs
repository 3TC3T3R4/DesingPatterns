namespace ObserverPatterns{
    class Program
    {
        private static void Main(string[] args)
        {
           
            
            Stock newstock = new("Trainig", 13.2);
            Investor newinvestor = new();
            Investor investorSara = new("Sara");
            Investor investorEstevan = new("Estevan");
         
            
            Investor investorX = new("X");
            Investor investorY = new("Y");

            newstock.Subscribe(investorSara);
            newstock.Subscribe(investorEstevan);
     
            newstock.Subscribe(investorX);
            newstock.Subscribe(investorY);

            newinvestor.Update(newstock);

            newstock.Price = 20.1;
            newstock.Price = 20.5;
            

            newstock.Unsubscribe(investorX);
            investorY.Unsubscribe(investorY, newstock);

            newinvestor.Update(newstock);

        }
    }
}

