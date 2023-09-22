using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class AudiSUV: IAudi
    {
       

        public void Start()
        {
            Console.WriteLine("Audi suv is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Audi  Suv stoppng");
        }

       

       
    }
}
