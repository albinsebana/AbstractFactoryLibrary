using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class BmwSUV :IBmw
    {
        

        public void Start()
        {
            Console.WriteLine("Bmw Suv starting");
        }
        public void Stop()
        {
            Console.WriteLine("Bmw Suv stoppng");
        }

       
    }
}
