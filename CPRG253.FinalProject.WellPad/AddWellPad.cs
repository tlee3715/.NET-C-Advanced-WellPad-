using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPRG253.WellPad.Domain;
using CPRG253.WellPad.Interfaces;
using System.Text.RegularExpressions;

namespace CPRG253.FinalProject.WellPad
{
    public partial class AddWellPad : Form
    {
        public AddWellPad()
        {
            InitializeComponent();
        }

        private void AddWellPad_Load(object sender, EventArgs e)
        {
            PopulateProvince();
            GridViewRefresh();
        }

        private void PopulateProvince()
        {
            const string prov_file = "Province.csv";

            string[] items = File.ReadAllLines(prov_file);

            foreach (string names in items)
            {
                string[] item = names.Split(',');
                uxProvince.Items.Add(item[0]);
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            WellPads well = new WellPads();
            well.Id = Convert.ToInt32(uxID.Text);
            well.Province = uxProvince.SelectedItem.ToString();
            well.Location = uxLocation.Text;
            well.Wells = new List<IWell>();

            FacilityManager.FacilityMng.wellpads.Add(well);
            FacilityManager.FacilityMng.SaveData();

            GridViewRefresh();
        }

        private void GridViewRefresh()
        {
            uxDataView.DataSource = null;

            uxDataView.DataSource = Display();
        }

        private List<object> Display()
        {
            if (FacilityManager.FacilityMng.GetData() == null) return null;
            var display = FacilityManager.FacilityMng.wellpads;
            return display
                .Select(o => new { Id = o.Id, Site = o.Location, Province = o.Province + ", Canada" })
                .ToList<object>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(uxID.Text, "^[0-9]{1,}$")) return;
            else
            {
                uxID.Text = "";
            }
        }
    }
}
