using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class TeslaSUV : ITesla
    {
        public void Start()
        {
            Console.WriteLine("Tesla Suv starting");
        }
        public void Stop()
        {
            Console.WriteLine("Tesla Suv stoppng");
        }

        
    }
}
