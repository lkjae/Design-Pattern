using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opserver_Pattern
{
    public interface IObserver
    {
        void update(String title, String news);
    }
}
