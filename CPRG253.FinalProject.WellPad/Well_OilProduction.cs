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
    public partial class Well_OilProduction : Form
    {
        public Well_OilProduction()
        {
            InitializeComponent();

            DisplayWellPads();
            RefreshGridView();
        }

        private void DisplayWellPads()
        {
            var displaywells = FacilityManager.FacilityMng.GetData();
            uxWellPad.DisplayMember = "Summary";
            uxWellPad.ValueMember = "Id";
            uxWellPad.DataSource = displaywells;
        }

        private void uxWellPad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(uxWellPad.SelectedValue);
            var wellpad = FacilityManager.FacilityMng.FindWell(ID);
            var prodwells = wellpad.Wells
                .Where(o => o.GetType() == typeof(ProductionWell))
                .ToList<object>();
            uxProductionWell.DisplayMember = "ShowProdwell";
            uxProductionWell.ValueMember = "Id";
            uxProductionWell.DataSource = prodwells;
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            OilProduction production = new OilProduction();
            production.ProductionDate = uxDate.Value.Date;
            production.BarrelsProduced = Convert.ToInt32(uxBarrels.Text);
            FindProductionWell().DailyProduction.Add(production);
            FacilityManager.FacilityMng.SaveData();
            RefreshGridView();
        }

        private ProductionWell FindProductionWell()
        {
            //var IDprod = Convert.ToInt32(uxProductionWell.SelectedValue);
            //var well = FindIWells().SingleOrDefault(o => o.Id == IDprod);
            //ProductionWell prod = well as ProductionWell;

            var well = (ProductionWell)uxProductionWell.SelectedItem; //this works, shorter and better than above codes
            return well;
        }

        //private List<IWell> FindIWells()
        //{
        //    //var ID = Convert.ToInt32(uxWellPad.SelectedValue);
        //    //var wellpad = FacilityManager.FacilityMng.FindWell(ID);

        //    var wellpad = (WellPads)uxWellPad.SelectedItem; //this works, shorter and better than the above codes
        //    var prodwell = wellpad.Wells
        //        .Where(o => o.GetType() == typeof(ProductionWell))
        //        .ToList();
        //    return prodwell;
        //}
    
        private void RefreshGridView()
        {
            uxDataView.DataSource = null;
            uxDataView.DataSource = ProductionData(); 
        }

        private List<object> ProductionData()
        {
            var Productions = FindProductionWell().DailyProduction
                .OrderByDescending(o => o.ProductionDate)
                .ToList<object>();
            return Productions;
        }

        private void uxProductionWell_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void timer1_Tick(object sender, EventArgs e)  //check if Barrels = int, if Barrels != int, ID returns null
        {
            if (Regex.IsMatch(uxBarrels.Text, "^[0-9]{1,}$")) return;
            else
            {
                uxBarrels.Text = null;
            }
        }
    }
}
