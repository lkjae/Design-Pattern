using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opserver_Pattern
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsMachine newsMachine = new NewsMachine();
            AnnualSubscriber anSub = new AnnualSubscriber(newsMachine);
            EventSubscriber evSub = new EventSubscriber(newsMachine);

            newsMachine.setNewsInfo("오늘 한파", "전국 영하 18도 입니다.");
            newsMachine.setNewsInfo("벛꽃 축제합니다.", "다같이 벛꽃보러~");

        }
    }  
   

}
