﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Interfaces
{
    public interface IWellPad
    {
        int Id { get; set; }

        string Province { get; set; }

        string Location { get; set; }

        List<IWell> Wells { get; set; }

        string Summary { get; }
    }
}
