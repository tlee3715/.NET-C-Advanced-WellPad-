using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Interfaces
{
    public enum WaterType { Brackish, Brine, Fresh, Saline }

    public interface IInjectionWell : IWell
    {
        WaterType WaterType { get; set; }
    }
}
