using CPRG253.WellPad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Domain
{
    public class ProductionWellFactory : IWellFactory
    {
        public IWell CreateIWell()
        {
            return new ProductionWell();
        }
    }
}
