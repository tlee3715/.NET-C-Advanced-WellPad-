using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Interfaces
{
    public interface IFileAccessObject
    {
        object GetData(string path);

        bool Save(object wells,string path);
    }
}
