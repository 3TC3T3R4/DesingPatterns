namespace ObserverPatterns{
    public class Investor : IObserver
    {
        private String investorName;

        public Investor()
        {
        }

        public Investor(String name)
        {
            InvestorName = name;
        }

        public string InvestorName
        {

            get { return investorName; }

            set { investorName = value; }
        }


        public void Unsubscribe(Investor investor, Stock stock)
        {
            stock.Observers.Remove(investor);
        }

        public void Update(Stock stock)
        {
            foreach (var aux in stock.Observers)
            {
            Console.WriteLine($"El Inversor: {aux.InvestorName} Accion realizada: {stock.Action}con unprecio: {stock.Price}");
            }
            
        }
    }
}