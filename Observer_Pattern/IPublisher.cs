using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opserver_Pattern
{
    public interface IPublisher
    {
        void add(IObserver observer);
        void delete(IObserver observer);
        void notifyObserver();

    }
}
