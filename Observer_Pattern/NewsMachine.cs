using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opserver_Pattern
{
    public class NewsMachine : IPublisher
    {
        private List<IObserver> observers;
        private string title;
        private string news;

        public NewsMachine()
        {
            observers = new List<IObserver>();
        }
        public void add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void delete(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(title,news);
            }
            
        }

        public void setNewsInfo(string title, string news)
        {
            this.title = title;
            this.news = news;
            notifyObserver();
        }

        public String getTitle()
        {
            return title;
        }

        public String getNews()
        {
            return news;
        }
    }
}
