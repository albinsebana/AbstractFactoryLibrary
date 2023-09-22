using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class SedanFactory : IAutoFactory
    {


        public IAudi CreateAudi()
        {
            return new AudiSedan();
        }

        public IBmw CreateBmw()
        {
            return new BmwSedan();
        }

        public ITesla CreateTesla()
        {
            return new TeslaSedan();
        }
    }
}