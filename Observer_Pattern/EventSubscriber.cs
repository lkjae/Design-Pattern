using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opserver_Pattern
{
    public class EventSubscriber : IObserver
    {
        public String newsString;
        private IPublisher publisher;

        public EventSubscriber(IPublisher publiser)
        {
            this.publisher = publiser;
            publisher.add(this);

        }

        public void update(string title, string news)
        {
            newsString = title + "\n----------------------\n" + news;
            display();
        }

        private void display()
        {
            System.Console.WriteLine("\n\n=== 이벤트 유저 ===");
            System.Console.WriteLine("\n\n" + newsString);
        }
    }
}
