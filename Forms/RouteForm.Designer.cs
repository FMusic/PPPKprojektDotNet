namespace PPPKprojektDotNet.Forms
{
    partial class RouteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbCity2 = new System.Windows.Forms.TextBox();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.tbAvgV = new System.Windows.Forms.TextBox();
            this.tbGas = new System.Windows.Forms.TextBox();
            this.cbRoutes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnXmlImport = new System.Windows.Forms.Button();
            this.btnXmlExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start date and time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End date and time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "City from:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "City to:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Distance traveled";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Average speed (km/h)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gas consumed";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 173);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 196);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(13, 109);
            this.dtStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(151, 20);
            this.dtStart.TabIndex = 13;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(174, 109);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(151, 20);
            this.dtEnd.TabIndex = 14;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(10, 173);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(76, 20);
            this.tbCity.TabIndex = 15;
            // 
            // tbCity2
            // 
            this.tbCity2.Location = new System.Drawing.Point(95, 173);
            this.tbCity2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCity2.Name = "tbCity2";
            this.tbCity2.Size = new System.Drawing.Size(76, 20);
            this.tbCity2.TabIndex = 16;
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(13, 251);
            this.tbDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(76, 20);
            this.tbDistance.TabIndex = 17;
            // 
            // tbAvgV
            // 
            this.tbAvgV.Location = new System.Drawing.Point(129, 251);
            this.tbAvgV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAvgV.Name = "tbAvgV";
            this.tbAvgV.Size = new System.Drawing.Size(76, 20);
            this.tbAvgV.TabIndex = 18;
            // 
            // tbGas
            // 
            this.tbGas.Location = new System.Drawing.Point(235, 251);
            this.tbGas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGas.Name = "tbGas";
            this.tbGas.Size = new System.Drawing.Size(76, 20);
            this.tbGas.TabIndex = 19;
            // 
            // cbRoutes
            // 
            this.cbRoutes.FormattingEnabled = true;
            this.cbRoutes.Location = new System.Drawing.Point(50, 31);
            this.cbRoutes.Name = "cbRoutes";
            this.cbRoutes.Size = new System.Drawing.Size(149, 21);
            this.cbRoutes.TabIndex = 20;
            this.cbRoutes.SelectedIndexChanged += new System.EventHandler(this.cbRoutes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Route";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(364, 149);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(56, 19);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnXmlImport
            // 
            this.btnXmlImport.Location = new System.Drawing.Point(339, 12);
            this.btnXmlImport.Name = "btnXmlImport";
            this.btnXmlImport.Size = new System.Drawing.Size(75, 23);
            this.btnXmlImport.TabIndex = 23;
            this.btnXmlImport.Text = "Import XML";
            this.btnXmlImport.UseVisualStyleBackColor = true;
            this.btnXmlImport.Click += new System.EventHandler(this.btnXmlImport_Click);
            // 
            // btnXmlExport
            // 
            this.btnXmlExport.Location = new System.Drawing.Point(339, 41);
            this.btnXmlExport.Name = "btnXmlExport";
            this.btnXmlExport.Size = new System.Drawing.Size(75, 23);
            this.btnXmlExport.TabIndex = 24;
            this.btnXmlExport.Text = "Export XML";
            this.btnXmlExport.UseVisualStyleBackColor = true;
            this.btnXmlExport.Click += new System.EventHandler(this.btnXmlExport_Click);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 295);
            this.Controls.Add(this.btnXmlExport);
            this.Controls.Add(this.btnXmlImport);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRoutes);
            this.Controls.Add(this.tbGas);
            this.Controls.Add(this.tbAvgV);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.tbCity2);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RouteForm";
            this.Text = "RouteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCity2;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.TextBox tbAvgV;
        private System.Windows.Forms.TextBox tbGas;
        private System.Windows.Forms.ComboBox cbRoutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnXmlImport;
        private System.Windows.Forms.Button btnXmlExport;
    }
}