using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Interfaces
{
    public interface IWell
    {
        int Id { get; set; }

        DateTime SpudDate { get; set; }
    }
}
