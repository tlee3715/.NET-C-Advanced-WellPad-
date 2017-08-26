namespace CPRG253.FinalProject.WellPad
{
    partial class AddInjectionWell
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxWellPad = new System.Windows.Forms.ComboBox();
            this.uxInjectionID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uxWaterType = new System.Windows.Forms.ComboBox();
            this.uxDate = new System.Windows.Forms.DateTimePicker();
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.uxSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Well Pad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Injection Well ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spud Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Water Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(209, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "INJECTION WELL";
            // 
            // uxWellPad
            // 
            this.uxWellPad.FormattingEnabled = true;
            this.uxWellPad.Location = new System.Drawing.Point(210, 76);
            this.uxWellPad.Name = "uxWellPad";
            this.uxWellPad.Size = new System.Drawing.Size(231, 21);
            this.uxWellPad.TabIndex = 9;
            this.toolTip1.SetToolTip(this.uxWellPad, "Select a Well Pad");
            this.uxWellPad.SelectedIndexChanged += new System.EventHandler(this.uxWellPad_SelectedIndexChanged);
            // 
            // uxInjectionID
            // 
            this.uxInjectionID.Location = new System.Drawing.Point(210, 118);
            this.uxInjectionID.Name = "uxInjectionID";
            this.uxInjectionID.Size = new System.Drawing.Size(113, 20);
            this.uxInjectionID.TabIndex = 10;
            this.toolTip1.SetToolTip(this.uxInjectionID, "Enter Injection Well ID");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // uxWaterType
            // 
            this.uxWaterType.FormattingEnabled = true;
            this.uxWaterType.Location = new System.Drawing.Point(210, 198);
            this.uxWaterType.Name = "uxWaterType";
            this.uxWaterType.Size = new System.Drawing.Size(113, 21);
            this.uxWaterType.TabIndex = 11;
            this.toolTip1.SetToolTip(this.uxWaterType, "Select a Water Type");
            // 
            // uxDate
            // 
            this.uxDate.Location = new System.Drawing.Point(210, 160);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(231, 20);
            this.uxDate.TabIndex = 12;
            this.toolTip1.SetToolTip(this.uxDate, "Select Spud Date");
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxDataView.Location = new System.Drawing.Point(0, 288);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(530, 150);
            this.uxDataView.TabIndex = 13;
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(236, 237);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(75, 23);
            this.uxSave.TabIndex = 14;
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
            // AddInjectionWell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 438);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxDataView);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxWaterType);
            this.Controls.Add(this.uxInjectionID);
            this.Controls.Add(this.uxWellPad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddInjectionWell";
            this.Text = "Add Injection Well";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxWellPad;
        private System.Windows.Forms.TextBox uxInjectionID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox uxWaterType;
        private System.Windows.Forms.DateTimePicker uxDate;
        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.Timer timer1;
    }
}