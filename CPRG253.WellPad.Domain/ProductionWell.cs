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
    public class ProductionWell : IProductionWell
    {
        public List<IOilProduction> DailyProduction { get; set; }

        public int Id { get; set; }

        public DateTime SpudDate { get; set; }

        public string ShowProdwell => $"ID: {Id} (Spud Date: {SpudDate})"; 
    }
}
