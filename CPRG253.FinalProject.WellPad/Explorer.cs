using CPRG253.WellPad.Domain;
using CPRG253.WellPad.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CPRG253.FinalProject.WellPad
{
    #region Explorer Form Class
    public partial class Explorer : Form
    {
        public Explorer()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxTreeView.ExpandAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxTreeView.CollapseAll();
        }

        #region Populate Tree View
        private void PopulateTreeView()
        {
            var WellPadsExplorer = fileaccess_explorerForm.Getwells();
            TreeNode root = new TreeNode("Facilities");
            root.Tag = WellPadsExplorer;
            uxTreeView.Nodes.Add(root);

            TreeNode province_Node = null;
            foreach(wellpad_listview province in WellPadsExplorer)
            {
                province_Node = new TreeNode(province.Province);
                province_Node.Tag = province;
                root.Nodes.Add(province_Node);

                TreeNode location = null;
                foreach(WellPads well_location in province.wells)
                {
                    location = new TreeNode(well_location.Location);
                    location.Tag = well_location;
                    province_Node.Nodes.Add(location);

                    TreeNode iwell = null;
                    foreach(IWell iwell_pad in well_location.Wells)
                    {
                        iwell = new TreeNode(iwell_pad.SpudDate.ToShortDateString());
                        iwell.Tag = iwell_pad;
                        location.Nodes.Add(iwell);
                    }
                }
            }
        }
        #endregion

        #region TreeView After Select event
        private void uxTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FormatListView(e.Node.Level);
            PopulateListView(e.Node);
        }
        #endregion

        #region Populate List View Data
        private void PopulateListView(TreeNode node)
        {
            uxListView.Items.Clear();
            switch (node.Level)
            {
                case 0:
                    List<wellpad_listview> wells_list = node.Tag as List<wellpad_listview>;
                    int producwellcount = 0, injectcount = 0;
                    foreach (wellpad_listview wellpads in wells_list)
                    {
                        foreach (WellPads Well in wellpads.wells)
                        {
                            injectcount = Well.Wells
                                .Where(o => o.GetType() == typeof(InjectionWell))
                                .Count();
                            producwellcount = Well.Wells
                                .Where(o => o.GetType() == typeof(ProductionWell))
                                .Count();
                        }
                        string[] datas = 
                            new string[] { wellpads.Province.ToString(), producwellcount.ToString(), injectcount.ToString() };
                        ListViewItem items = new ListViewItem(datas);
                        uxListView.Items.Add(items);
                    }
                    break;

                case 1:
                    wellpad_listview locations = node.Tag as wellpad_listview;
                    foreach(WellPads Well in locations.wells)
                    {
                        var productionCount = Well.Wells
                            .Where(o => o.GetType() == typeof(ProductionWell))
                            .Count()
                            .ToString();
                        var injectionCount = Well.Wells
                            .Where(o => o.GetType() == typeof(InjectionWell))
                            .Count()
                            .ToString();
                        string[] datas = new string[] { Well.Location, productionCount, injectionCount };
                        ListViewItem items = new ListViewItem(datas);
                        uxListView.Items.Add(items);
                    }
                    break;

                case 2:
                    WellPads well = node.Tag as WellPads;
                    var productionWells = well.Wells
                        .OrderByDescending(o => o.SpudDate)
                        .Where(o => o.GetType() == typeof(ProductionWell))
                        .ToList();
                    var InjectionWells = well.Wells
                        .OrderByDescending(o => o.SpudDate)
                        .Where(o => o.GetType() == typeof(InjectionWell))
                        .ToList();
                    foreach (ProductionWell productionWell in productionWells)
                    {
                        string[] Datas = new string[] { productionWell.SpudDate.ToShortDateString(), productionWell.DailyProduction
                                                                                          .Select(o => o.BarrelsProduced)
                                                                                          .Sum()
                                                                                          .ToString() };
                        ListViewItem Items = new ListViewItem(Datas);
                        uxListView.Items.Add(Items);
                    }
                    foreach (InjectionWell injectionWell in InjectionWells)
                    {
                        string[] Datas = new string[] { injectionWell.SpudDate.ToShortDateString(), "0 barrels (Injection Well)" };
                        ListViewItem Items = new ListViewItem(Datas);
                        uxListView.Items.Add(Items);
                    }                                                  
                    break;

                case 3:
                    IWell iwells = node.Tag as IWell;
                    ProductionWell productwells = iwells as ProductionWell;
                    try
                    {//get a collection of oil production from production wells (with production dates sorted in descending order)
                        var Production = productwells.DailyProduction.OrderByDescending(o => o.ProductionDate).ToList();
                        foreach (OilProduction production in Production)
                        {
                            string[] productions = 
                                new string[] { production.ProductionDate.ToShortDateString(), production.BarrelsProduced.ToString() };
                            ListViewItem producItems = new ListViewItem(productions);
                            uxListView.Items.Add(producItems);
                        }
                    }
                    catch
                    {
                        string[] InjectionData = new string[] { "N/A", "0 barrels" };
                        ListViewItem items = new ListViewItem(InjectionData);
                        uxListView.Items.Add(items);
                        return;
                    }
                    break;
            }
        }
        #endregion

        #region ListView Column Titles
        private void FormatListView(int level)
        {
            switch (level)
            {
                case 0:
                    //"Facilities" is selected
                    uxListView.Columns.Clear();
                    uxListView.Columns.Add("Province", 120);
                    uxListView.Columns.Add("Producing Well Count", 160);
                    uxListView.Columns.Add("Injection Well Count", 160);
                    break;
                case 1:
                    //When a province node is selected
                    uxListView.Columns.Clear();
                    uxListView.Columns.Add("Location", 120);
                    uxListView.Columns.Add("Producing Well Count", 160);
                    uxListView.Columns.Add("Injection Well Count", 160);
                    break;
                case 2:
                    //when a well pad location is selected                
                    uxListView.Columns.Clear();
                    uxListView.Columns.Add("Spud Date", 160);
                    uxListView.Columns.Add("Barrels Produced", 180);
                    break;
                case 3:
                    //when an IWell (Injection well or Production well) is selected              
                    uxListView.Columns.Clear();
                    uxListView.Columns.Add("Production Date", 160);
                    uxListView.Columns.Add("Barrels Produced", 120);
                    break;
            }
        }
        #endregion
    }
    #endregion


    #region Collection to populate TreeView/ListView
    public class wellpad_listview
    {
        public string Province { get; set; }

        public List<WellPads> wells { get; set; }
    }
    #endregion

    #region Get Data to Populate TreeView/ListView
    public class fileaccess_explorerForm
    {
        const string path = "Province.csv";

        public static List<wellpad_listview> Getwells()
        {
            List<wellpad_listview> wells = new List<wellpad_listview>();
            wellpad_listview well = null;
            string[] provinces = File.ReadAllLines(path);
            foreach(string items in provinces)
            {
                well = new wellpad_listview();
                string[] item = items.Split(',');
                well.Province = item[0];
                well.wells = new List<WellPads>();
                wells.Add(well);
                GetWellPadsByProvince(well);
            }
            return wells;
        }

        public static void GetWellPadsByProvince(wellpad_listview well)
        {
            var Wellpads = FacilityManager.FacilityMng.GetData();
            foreach(WellPads Well in Wellpads)
            {
                if(Well.Province == well.Province)
                {
                    well.wells.Add(Well); //group together all wellpads locate in the same province 
                }
            }
        }      
    }
    #endregion
}
