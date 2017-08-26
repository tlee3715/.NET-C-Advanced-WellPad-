namespace CPRG253.FinalProject.WellPad
{
    partial class AddWellPad
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
            this.uxProvince = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uxID = new System.Windows.Forms.TextBox();
            this.uxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxSave = new System.Windows.Forms.Button();
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxProvince
            // 
            this.uxProvince.FormattingEnabled = true;
            this.uxProvince.Location = new System.Drawing.Point(194, 108);
            this.uxProvince.Name = "uxProvince";
            this.uxProvince.Size = new System.Drawing.Size(163, 21);
            this.uxProvince.TabIndex = 0;
            this.toolTip1.SetToolTip(this.uxProvince, "Select Province");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Province:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Well Pad ID:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // uxID
            // 
            this.uxID.Location = new System.Drawing.Point(194, 71);
            this.uxID.Name = "uxID";
            this.uxID.Size = new System.Drawing.Size(100, 20);
            this.uxID.TabIndex = 3;
            this.toolTip1.SetToolTip(this.uxID, "Enter Well Pad ID");
            // 
            // uxLocation
            // 
            this.uxLocation.Location = new System.Drawing.Point(194, 150);
            this.uxLocation.Name = "uxLocation";
            this.uxLocation.Size = new System.Drawing.Size(100, 20);
            this.uxLocation.TabIndex = 5;
            this.toolTip1.SetToolTip(this.uxLocation, "Enter Location");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Well Pad Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(162, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "WELL PAD";
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(166, 192);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(75, 23);
            this.uxSave.TabIndex = 7;
            this.uxSave.Text = "&Add";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxDataView.Location = new System.Drawing.Point(0, 231);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(458, 150);
            this.uxDataView.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddWellPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 381);
            this.Controls.Add(this.uxDataView);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxProvince);
            this.Name = "AddWellPad";
            this.Text = "Add Well Pad";
            this.Load += new System.EventHandler(this.AddWellPad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxID;
        private System.Windows.Forms.TextBox uxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.Timer timer1;
    }
}