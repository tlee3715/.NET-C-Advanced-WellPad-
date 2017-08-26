using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPRG253.WellPad.Interfaces;

namespace CPRG253.WellPad.Domain
{
    [Serializable]
    public class WellPads : IWellPad
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public string Province { get; set; }

        public List<IWell> Wells { get; set; }

        public string Summary => $"Id: {Id} ({Location}, {Province}, Canada)";
    }
}
