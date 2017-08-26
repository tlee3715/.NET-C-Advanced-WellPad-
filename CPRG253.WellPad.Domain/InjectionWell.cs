using CPRG253.WellPad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Domain
{
    [Serializable]
    public class InjectionWell : IInjectionWell
    {
        public int Id { get; set; }

        public DateTime SpudDate { get; set; }

        public WaterType WaterType { get; set; }
    }
}
