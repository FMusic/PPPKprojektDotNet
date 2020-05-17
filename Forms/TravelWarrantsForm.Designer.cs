namespace PPPKprojektDotNet.Forms
{
    partial class TravelWarrantsForm
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
            this.dgWarrants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDrivers = new System.Windows.Forms.ComboBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWarrantID = new System.Windows.Forms.Label();
            this.cbWarrantState = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWarrants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgWarrants
            // 
            this.dgWarrants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWarrants.Location = new System.Drawing.Point(10, 11);
            this.dgWarrants.Margin = new System.Windows.Forms.Padding(2);
            this.dgWarrants.Name = "dgWarrants";
            this.dgWarrants.RowHeadersWidth = 51;
            this.dgWarrants.RowTemplate.Height = 24;
            this.dgWarrants.Size = new System.Drawing.Size(643, 219);
            this.dgWarrants.TabIndex = 0;
            this.dgWarrants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWarrants_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show only";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(559, 251);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(94, 21);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Driver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vehicle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Travel Warrant";
            // 
            // cbDrivers
            // 
            this.cbDrivers.FormattingEnabled = true;
            this.cbDrivers.Location = new System.Drawing.Point(111, 254);
            this.cbDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.cbDrivers.Name = "cbDrivers";
            this.cbDrivers.Size = new System.Drawing.Size(165, 21);
            this.cbDrivers.TabIndex = 10;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(111, 281);
            this.cbVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(165, 21);
            this.cbVehicle.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 443);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 35);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "New/Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.Location = new System.Drawing.Point(61, 443);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(103, 35);
            this.btnRoutes.TabIndex = 24;
            this.btnRoutes.Text = "See Routes";
            this.btnRoutes.UseVisualStyleBackColor = true;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Travel Warrant ID";
            // 
            // lblWarrantID
            // 
            this.lblWarrantID.AutoSize = true;
            this.lblWarrantID.Location = new System.Drawing.Point(108, 366);
            this.lblWarrantID.Name = "lblWarrantID";
            this.lblWarrantID.Size = new System.Drawing.Size(13, 13);
            this.lblWarrantID.TabIndex = 26;
            this.lblWarrantID.Text = "0";
            // 
            // cbWarrantState
            // 
            this.cbWarrantState.FormattingEnabled = true;
            this.cbWarrantState.Location = new System.Drawing.Point(61, 392);
            this.cbWarrantState.Margin = new System.Windows.Forms.Padding(2);
            this.cbWarrantState.Name = "cbWarrantState";
            this.cbWarrantState.Size = new System.Drawing.Size(148, 21);
            this.cbWarrantState.TabIndex = 27;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(411, 443);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TravelWarrantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 529);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbWarrantState);
            this.Controls.Add(this.lblWarrantID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRoutes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.cbDrivers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgWarrants);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TravelWarrantsForm";
            this.Text = "TravelWarrantsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgWarrants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgWarrants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDrivers;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWarrantID;
        private System.Windows.Forms.ComboBox cbWarrantState;
        private System.Windows.Forms.Button btnUpdate;
    }
}