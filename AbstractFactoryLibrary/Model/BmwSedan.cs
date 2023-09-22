using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class BmwSedan : IBmw
    {
        public void Start()
        {
            Console.WriteLine("Bmw Sedan is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Bmw Sedan is stoppng");
        }
    }
}
