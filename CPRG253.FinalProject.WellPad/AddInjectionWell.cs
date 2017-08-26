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
    public partial class AddInjectionWell : Form
    {
        IWell inject;

        public AddInjectionWell()
        {
            InitializeComponent();        
            AddWaterType();
            WellPadBox();
            RefreshGridData();
        }

        private void WellPadBox()
        {
            var display = FacilityManager.FacilityMng.GetData();
            uxWellPad.DisplayMember = "Summary";
            uxWellPad.ValueMember = "Id";
            uxWellPad.DataSource = display;
        }

        private void AddWaterType()
        {
            uxWaterType.Items.AddRange(Enum.GetNames(typeof(WaterType)));
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            inject = IWellFactories.GetFactory(IWellType.Injection).CreateIWell();
            inject.Id = Convert.ToInt32(uxInjectionID.Text);
            inject.SpudDate = uxDate.Value.Date;
            InjectionWell inj = inject as InjectionWell;
            inj.WaterType = (WaterType)uxWaterType.SelectedIndex;

            var ID = Convert.ToInt32(uxWellPad.SelectedValue);
            var wellPad = FacilityManager.FacilityMng.FindWell(ID);
            wellPad.Wells.Add(inject);
            FacilityManager.FacilityMng.SaveData();
     
            RefreshGridData();
        }

        private void RefreshGridData()
        {
            uxDataView.DataSource = null;
            uxDataView.DataSource = DisplayInfo();
        }

        private List<object> DisplayInfo()
        {
            var id = Convert.ToInt32(uxWellPad.SelectedValue);
            var wellPad = FacilityManager.FacilityMng.FindWell(id);
            var injWells = wellPad.Wells
                .Where(o => o.GetType() == typeof(InjectionWell))
                .ToList<object>();
            return injWells;
        }

        private void timer1_Tick(object sender, EventArgs e) //check if ID = int, if ID != int, ID returns null
        {
            if (Regex.IsMatch(uxInjectionID.Text, "^[0-9]{1,}$")) return;
            else
            {
                uxInjectionID.Text = "";
            }
        }

        private void uxWellPad_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridData();
        }
    }
}
