namespace ObserverPatterns { 

public class Stock : IObservable
{
    private String action;
    private double price;
    private List<Investor> observadores;


    public Stock(String action, double startPrice)
    {
        Action = action;
        Price = startPrice;
        observadores = new List<Investor>();
    }
    public string Action {

            get {return action; }
            set { action = value; }
        
        }

    public double Price{
            get {return price; }

            set { price = value; }
        }


    public List<Investor> Observers{

            get { return observadores; }
            set { observadores = value; }
        }

    public void Subscribe(Investor investor) => observadores.Add(investor);

    public void Unsubscribe(Investor investor) => observadores.Remove(investor);
}
}