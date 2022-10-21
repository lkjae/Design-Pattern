using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton01
{
    public class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;

        //멀티스레드에서 Lock걸기 위해
        private static readonly object _lock = new object();

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                //Thread in safe
                lock(_lock)
                {
                    _instance = new Singleton();
                }
                
            }
            return _instance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
                Console.WriteLine("같다");
         
            else
                Console.WriteLine("다르다");

        }
    }
}
