using CPRG253.WellPad.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.WellPad.Persistance
{
    public class FileAccessObject : IFileAccessObject
    {
        #region Binary class object & FileStream class object
        BinaryFormatter Serializer { get; set; }
        FileStream stream { get; set; }
        #endregion

        #region FileAccessObject class default constructor
        public FileAccessObject()
        {
            Serializer = new BinaryFormatter();
        }
        #endregion

        #region Deserialize Data
        public object GetData(string path)
        {
            if (!File.Exists(path)) return null;
            try
            { 
            using (stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                var Data = Serializer.Deserialize(stream);
                return Data;
            }
            }
            catch(Exception e)
            {
                throw new Exception("Error deserilizing data", e);
            }
        }
        #endregion

        #region Serialize Data
        public bool Save(object data, string path)
        {
            try
            {
                using (stream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    Serializer.Serialize(stream, data);
                    return true;
                }                
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error serializing the data", ex);
            }
        }
        #endregion
    }
}
