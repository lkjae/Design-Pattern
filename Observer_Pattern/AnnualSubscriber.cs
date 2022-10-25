using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opserver_Pattern
{
    public class AnnualSubscriber : IObserver
    {
        private String newsString;
        private IPublisher publisher;

        public AnnualSubscriber(IPublisher publisher)
        {
            this.publisher = publisher;
            publisher.add(this);
        }

        public void update(string title, string news)
        {
            this.newsString = title + "\n -------------- \n" + news;
            display();
        }

        private void display()
        {
            System.Console.WriteLine("\n\n오늘의 뉴스 \n======================\n\n" + newsString);
        }
    }
}
