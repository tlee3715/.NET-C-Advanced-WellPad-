using CPRG253.WellPad.Domain;
using CPRG253.WellPad.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG253.FinalProject.WellPad
{
    public partial class AddProductionWell : Form
    {
        IWell production;
        public AddProductionWell()
        {
            InitializeComponent();
            
            PopulateWellPadBox();
            RefreshGridData();
        }

        private void PopulateWellPadBox()
        {
            var display = FacilityManager.FacilityMng.GetData();
            uxWellPad.DisplayMember = "Summary";
            uxWellPad.ValueMember = "Id";
            uxWellPad.DataSource = display;
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            production = IWellFactories.GetFactory(IWellType.Production).CreateIWell();
            production.Id = Convert.ToInt32(uxProductionID.Text);
            production.SpudDate = uxDate.Value.Date;
            ProductionWell prod = production as ProductionWell;
            prod.DailyProduction = new List<IOilProduction>();

            var ID = Convert.ToInt32(uxWellPad.SelectedValue);
            var WellPad = FacilityManager.FacilityMng.FindWell(ID);
            WellPad.Wells.Add(production);
            FacilityManager.FacilityMng.SaveData();
            RefreshGridData();
        }

        private void RefreshGridData()
        {
            uxDataView.DataSource = null;
            uxDataView.DataSource = Display();
        }

        private List<object> Display()
        {
            var ID = Convert.ToInt32(uxWellPad.SelectedValue);
            var WellPad = FacilityManager.FacilityMng.FindWell(ID);
            var prodwell = WellPad.Wells
                .Where(o => o.GetType() == typeof(ProductionWell))
                .Select(o => new { ID = o.Id, Spud_Date = o.SpudDate })
                .ToList<object>();          
            return prodwell;
        }

        private void timer1_Tick(object sender, EventArgs e)  //check if ID = int, if ID != int, ID returns null
        {
            if (Regex.IsMatch(uxProductionID.Text, "^[0-9]{1,}$")) return;
            else
            {
                uxProductionID.Text = null;
            }
        }

        private void uxWellPad_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridData();
        }
    }
}
