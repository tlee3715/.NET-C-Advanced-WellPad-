using CPRG253.WellPad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Domain
{
    public enum IWellType { Production, Injection }

    public class IWellFactories
    {
        public static IWellFactory GetFactory(IWellType IWellType)
        {
            switch(IWellType)
            {
                case IWellType.Production:
                    return new ProductionWellFactory();
                case IWellType.Injection:
                    return new InjectionWellFactory();
            }
            throw new Exception("IWell Error");
        }
    }
}
