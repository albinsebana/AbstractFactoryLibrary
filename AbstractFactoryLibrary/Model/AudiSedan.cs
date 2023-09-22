using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class AudiSedan : IAudi
    {
        public void Start()
        {
            Console.WriteLine("Audi Sedan is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Audi Sedan is stoppng");
        }
    }
}
