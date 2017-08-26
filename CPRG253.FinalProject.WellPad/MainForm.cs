using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG253.FinalProject.WellPad
{
    public partial class MainForm : Form
    {
        Explorer Exp_frm;
        AddWellPad WellPad;
        AddProductionWell ProductionWell;
        AddInjectionWell InjectionWwell;
        Well_OilProduction Oil_Production;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Exp_frm == null || Exp_frm.IsDisposed == true)
            {
                Exp_frm = new Explorer();
                Exp_frm.MdiParent = this;
            }
            Exp_frm.Show();
            Exp_frm.BringToFront();
        }

        private void addWellPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WellPad == null || WellPad.IsDisposed == true)
            {
                WellPad = new AddWellPad();
                WellPad.MdiParent = this;
            }
            WellPad.Show();
            WellPad.BringToFront();
        }

        private void addProductionWellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProductionWell == null || ProductionWell.IsDisposed == true)
            {
                ProductionWell = new AddProductionWell();
                ProductionWell.MdiParent = this;
            }
            ProductionWell.Show();
            ProductionWell.BringToFront();
        }

        private void addInjectionWellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InjectionWwell == null || InjectionWwell.IsDisposed == true)
            {
                InjectionWwell = new AddInjectionWell();
                InjectionWwell.MdiParent = this;
            }
            InjectionWwell.Show();
            InjectionWwell.BringToFront();
        }

        private void wellProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Oil_Production == null || Oil_Production.IsDisposed == true)
            {
                Oil_Production = new Well_OilProduction();
                Oil_Production.MdiParent = this;
            }
            Oil_Production.Show();
            Oil_Production.BringToFront();
        }
    }
}
