namespace PPPKprojektDotNet.Forms
{
    partial class CarServices
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
            this.dgVehicles = new System.Windows.Forms.DataGridView();
            this.dgServices = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgServiceItems = new System.Windows.Forms.DataGridView();
            this.dtService = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveService = new System.Windows.Forms.Button();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVehicles
            // 
            this.dgVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehicles.Location = new System.Drawing.Point(12, 34);
            this.dgVehicles.Name = "dgVehicles";
            this.dgVehicles.Size = new System.Drawing.Size(312, 184);
            this.dgVehicles.TabIndex = 0;
            this.dgVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehicles_CellContentClick);
            this.dgVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehicles_CellContentClick);
            // 
            // dgServices
            // 
            this.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServices.Location = new System.Drawing.Point(12, 243);
            this.dgServices.Name = "dgServices";
            this.dgServices.Size = new System.Drawing.Size(312, 184);
            this.dgServices.TabIndex = 1;
            this.dgServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServices_CellContentClick);
            this.dgServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServices_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehicles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car services:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service items:";
            // 
            // dgServiceItems
            // 
            this.dgServiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServiceItems.Location = new System.Drawing.Point(12, 448);
            this.dgServiceItems.Name = "dgServiceItems";
            this.dgServiceItems.Size = new System.Drawing.Size(312, 184);
            this.dgServiceItems.TabIndex = 5;
            // 
            // dtService
            // 
            this.dtService.Location = new System.Drawing.Point(360, 256);
            this.dtService.Name = "dtService";
            this.dtService.Size = new System.Drawing.Size(183, 20);
            this.dtService.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of service:";
            // 
            // btnSaveService
            // 
            this.btnSaveService.Location = new System.Drawing.Point(437, 291);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(106, 23);
            this.btnSaveService.TabIndex = 10;
            this.btnSaveService.Text = "Add new service";
            this.btnSaveService.UseVisualStyleBackColor = true;
            this.btnSaveService.Click += new System.EventHandler(this.btnSaveService_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(360, 344);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(183, 20);
            this.tbItemName.TabIndex = 11;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(360, 383);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(183, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Service item name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price:";
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(431, 409);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(112, 23);
            this.btnSaveItem.TabIndex = 15;
            this.btnSaveItem.Text = "Save service item";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chosen vehicle";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(371, 34);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(35, 13);
            this.lblVehicle.TabIndex = 17;
            this.lblVehicle.Text = "NULL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Chosen Service";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(371, 90);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(35, 13);
            this.lblService.TabIndex = 19;
            this.lblService.Text = "NULL";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(330, 619);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status";
            // 
            // CarServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 647);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.btnSaveService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtService);
            this.Controls.Add(this.dgServiceItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgServices);
            this.Controls.Add(this.dgVehicles);
            this.Name = "CarServices";
            this.Text = "CarServices";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServiceItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVehicles;
        private System.Windows.Forms.DataGridView dgServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgServiceItems;
        private System.Windows.Forms.DateTimePicker dtService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveService;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblStatus;
    }
}