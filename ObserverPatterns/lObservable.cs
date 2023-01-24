
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns{
    public interface IObservable
    {
        public void Subscribe(Investor investor);

        public void Unsubscribe(Investor investor);
    }
}
