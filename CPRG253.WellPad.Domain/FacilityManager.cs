using CPRG253.WellPad.Interfaces;
using CPRG253.WellPad.Persistance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Domain
{
    public class FacilityManager : IPersistable
    {
        #region Path, Well Pad Collection & fileaccess object
        const string path = "Facilities.dat";
        IFileAccessObject _fileAccess = new FileAccessObject();
        public List<WellPads> wellpads = new List<WellPads>();
        #endregion

        #region Singleton
        private static FacilityManager _facilityMng;
        private FacilityManager() { }//private constuctor for singleton
        public static FacilityManager FacilityMng
        {
            get
            {
                if (_facilityMng == null) _facilityMng = new FacilityManager();
                return _facilityMng;
            }
        }
        #endregion

        #region Save
        public void SaveData()
        {
            _fileAccess.Save(wellpads, path);
        }
        #endregion

        #region Deserialize Data
        public List<WellPads> GetData()
        {
            var wells = _fileAccess.GetData(path);
            wellpads = wells as List<WellPads>;
            return wellpads;
        }
        #endregion

        #region Well Pad Lookup
        public WellPads FindWell(int id)
        {
            return GetData().SingleOrDefault(o => o.Id == id);
        }
        #endregion
    }
}
