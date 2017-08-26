namespace CPRG253.FinalProject.WellPad
{
    partial class Well_OilProduction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Well_OilProduction));
            this.label5 = new System.Windows.Forms.Label();
            this.uxWellPad = new System.Windows.Forms.ComboBox();
            this.uxProductionWell = new System.Windows.Forms.ComboBox();
            this.uxBarrels = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uxDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.uxSave = new System.Windows.Forms.Button();
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(245, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "OIL PRODUCTION";
            // 
            // uxWellPad
            // 
            this.uxWellPad.FormattingEnabled = true;
            this.uxWellPad.Location = new System.Drawing.Point(233, 98);
            this.uxWellPad.Name = "uxWellPad";
            this.uxWellPad.Size = new System.Drawing.Size(283, 21);
            this.uxWellPad.TabIndex = 10;
            this.toolTip1.SetToolTip(this.uxWellPad, "Select a Well Pad");
            this.uxWellPad.SelectedIndexChanged += new System.EventHandler(this.uxWellPad_SelectedIndexChanged);
            // 
            // uxProductionWell
            // 
            this.uxProductionWell.FormattingEnabled = true;
            this.uxProductionWell.Location = new System.Drawing.Point(233, 152);
            this.uxProductionWell.Name = "uxProductionWell";
            this.uxProductionWell.Size = new System.Drawing.Size(283, 21);
            this.uxProductionWell.TabIndex = 11;
            this.toolTip1.SetToolTip(this.uxProductionWell, "Select a Production Well");
            this.uxProductionWell.SelectedIndexChanged += new System.EventHandler(this.uxProductionWell_SelectedIndexChanged);
            // 
            // uxBarrels
            // 
            this.uxBarrels.Location = new System.Drawing.Point(233, 243);
            this.uxBarrels.Name = "uxBarrels";
            this.uxBarrels.Size = new System.Drawing.Size(113, 20);
            this.uxBarrels.TabIndex = 12;
            this.toolTip1.SetToolTip(this.uxBarrels, "Enter Number of Barrels Produced");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Well Pad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Production Well:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Barrels Produced:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // uxDate
            // 
            this.uxDate.Location = new System.Drawing.Point(233, 198);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(200, 20);
            this.uxDate.TabIndex = 17;
            this.toolTip1.SetToolTip(this.uxDate, "Select Spud Date");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Production Date:";
            // 
            // uxSave
            // 
            this.uxSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxSave.ImageIndex = 0;
            this.uxSave.ImageList = this.imageList1;
            this.uxSave.Location = new System.Drawing.Point(260, 280);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(69, 39);
            this.uxSave.TabIndex = 18;
            this.uxSave.Text = "&Add";
            this.uxSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxDataView.Location = new System.Drawing.Point(0, 359);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(566, 150);
            this.uxDataView.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "information.png");
            // 
            // Well_OilProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 509);
            this.Controls.Add(this.uxDataView);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxBarrels);
            this.Controls.Add(this.uxProductionWell);
            this.Controls.Add(this.uxWellPad);
            this.Controls.Add(this.label5);
            this.Name = "Well_OilProduction";
            this.Text = "Well Production";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxWellPad;
        private System.Windows.Forms.ComboBox uxProductionWell;
        private System.Windows.Forms.TextBox uxBarrels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker uxDate;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}