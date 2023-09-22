using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class TeslaSedan : ITesla
    {
        public void Start()
        {
            Console.WriteLine("Tesla Sedan is  starting");
        }
        public void Stop()
        {
            Console.WriteLine("Tesla Sedan is stoppng");
        }
    }
}
