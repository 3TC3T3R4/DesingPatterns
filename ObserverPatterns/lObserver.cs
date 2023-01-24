

using ObserverPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns{
    public interface IObserver
    {
        public void Unsubscribe(Investor investor, Stock stock);
        public void Update(Stock stock);
    }
}
