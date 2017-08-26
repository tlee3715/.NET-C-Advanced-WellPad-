using CPRG253.WellPad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPRG253.WellPad.Domain;

namespace CPRG253.WellPad.Domain
{
    [Serializable]
    public class OilProduction : IOilProduction
    {
        public DateTime ProductionDate { get; set; }

        public int BarrelsProduced { get; set; }
    }
}
