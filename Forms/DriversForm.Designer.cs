namespace PPPKprojektDotNet
{
    partial class DriversForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTeleNum = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDriversLicenseID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgDrivers = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnWarrants = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drivers license ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telephone number";
            // 
            // tbTeleNum
            // 
            this.tbTeleNum.Location = new System.Drawing.Point(112, 402);
            this.tbTeleNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbTeleNum.Name = "tbTeleNum";
            this.tbTeleNum.Size = new System.Drawing.Size(301, 20);
            this.tbTeleNum.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(112, 366);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(301, 20);
            this.tbSurname.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 333);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(301, 20);
            this.tbName.TabIndex = 6;
            // 
            // tbDriversLicenseID
            // 
            this.tbDriversLicenseID.Location = new System.Drawing.Point(112, 438);
            this.tbDriversLicenseID.Margin = new System.Windows.Forms.Padding(2);
            this.tbDriversLicenseID.Name = "tbDriversLicenseID";
            this.tbDriversLicenseID.Size = new System.Drawing.Size(301, 20);
            this.tbDriversLicenseID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(112, 296);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(81, 20);
            this.tbID.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 381);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add/Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(440, 427);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 41);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgDrivers
            // 
            this.dgDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDrivers.Location = new System.Drawing.Point(10, 11);
            this.dgDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.dgDrivers.Name = "dgDrivers";
            this.dgDrivers.RowHeadersWidth = 51;
            this.dgDrivers.RowTemplate.Height = 24;
            this.dgDrivers.Size = new System.Drawing.Size(548, 280);
            this.dgDrivers.TabIndex = 15;
            this.dgDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDrivers_CellContentClick);
            this.dgDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDrivers_CellContentClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(440, 336);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 39);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnWarrants
            // 
            this.btnWarrants.Location = new System.Drawing.Point(440, 296);
            this.btnWarrants.Name = "btnWarrants";
            this.btnWarrants.Size = new System.Drawing.Size(118, 39);
            this.btnWarrants.TabIndex = 17;
            this.btnWarrants.Text = "Warrants screen";
            this.btnWarrants.UseVisualStyleBackColor = true;
            this.btnWarrants.Click += new System.EventHandler(this.btnWarrants_Click);
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 483);
            this.Controls.Add(this.btnWarrants);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgDrivers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDriversLicenseID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbTeleNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DriversForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTeleNum;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDriversLicenseID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgDrivers;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnWarrants;
    }
}

