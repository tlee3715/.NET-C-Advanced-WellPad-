namespace CPRG253.FinalProject.WellPad
{
    partial class AddProductionWell
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxProductionID = new System.Windows.Forms.TextBox();
            this.uxWellPad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uxDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uxDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Production Well ID:";
            // 
            // uxProductionID
            // 
            this.uxProductionID.Location = new System.Drawing.Point(191, 124);
            this.uxProductionID.Name = "uxProductionID";
            this.uxProductionID.Size = new System.Drawing.Size(100, 20);
            this.uxProductionID.TabIndex = 1;
            this.toolTip1.SetToolTip(this.uxProductionID, "Enter Production Well ID");
            // 
            // uxWellPad
            // 
            this.uxWellPad.FormattingEnabled = true;
            this.uxWellPad.Location = new System.Drawing.Point(191, 74);
            this.uxWellPad.Name = "uxWellPad";
            this.uxWellPad.Size = new System.Drawing.Size(210, 21);
            this.uxWellPad.TabIndex = 2;
            this.toolTip1.SetToolTip(this.uxWellPad, "Select a Well Pad");
            this.uxWellPad.SelectedIndexChanged += new System.EventHandler(this.uxWellPad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Well Pad:";
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
            this.uxDate.Location = new System.Drawing.Point(191, 170);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(210, 20);
            this.uxDate.TabIndex = 8;
            this.toolTip1.SetToolTip(this.uxDate, "Select Spud Date");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spud Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(164, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRODUCTION WELL";
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(191, 216);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(75, 23);
            this.uxSave.TabIndex = 9;
            this.uxSave.Text = "&Add";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxDataView.Location = new System.Drawing.Point(0, 257);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(471, 129);
            this.uxDataView.TabIndex = 10;
            // 
            // AddProductionWell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 386);
            this.Controls.Add(this.uxDataView);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxWellPad);
            this.Controls.Add(this.uxProductionID);
            this.Controls.Add(this.label1);
            this.Name = "AddProductionWell";
            this.Text = "Add Production Well";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxProductionID;
        private System.Windows.Forms.ComboBox uxWellPad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker uxDate;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView uxDataView;
    }
}