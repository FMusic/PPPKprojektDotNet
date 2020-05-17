namespace PPPKprojektDotNet.Forms
{
    partial class Menu
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
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnTravelWarrants = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnCarServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.Coral;
            this.btnDrivers.Location = new System.Drawing.Point(12, 12);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(394, 85);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackColor = System.Drawing.Color.Coral;
            this.btnRoutes.Location = new System.Drawing.Point(12, 103);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(394, 85);
            this.btnRoutes.TabIndex = 1;
            this.btnRoutes.Text = "Routes";
            this.btnRoutes.UseVisualStyleBackColor = false;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnTravelWarrants
            // 
            this.btnTravelWarrants.BackColor = System.Drawing.Color.Coral;
            this.btnTravelWarrants.Location = new System.Drawing.Point(12, 194);
            this.btnTravelWarrants.Name = "btnTravelWarrants";
            this.btnTravelWarrants.Size = new System.Drawing.Size(394, 85);
            this.btnTravelWarrants.TabIndex = 2;
            this.btnTravelWarrants.Text = "TravelWarrants";
            this.btnTravelWarrants.UseVisualStyleBackColor = false;
            this.btnTravelWarrants.Click += new System.EventHandler(this.btnTravelWarrants_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.Chocolate;
            this.btnXml.Location = new System.Drawing.Point(12, 285);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(394, 85);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "Xml";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnCarServices
            // 
            this.btnCarServices.BackColor = System.Drawing.Color.Chocolate;
            this.btnCarServices.Location = new System.Drawing.Point(12, 376);
            this.btnCarServices.Name = "btnCarServices";
            this.btnCarServices.Size = new System.Drawing.Size(394, 85);
            this.btnCarServices.TabIndex = 4;
            this.btnCarServices.Text = "Car Services";
            this.btnCarServices.UseVisualStyleBackColor = false;
            this.btnCarServices.Click += new System.EventHandler(this.btnCarServices_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 467);
            this.Controls.Add(this.btnCarServices);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTravelWarrants);
            this.Controls.Add(this.btnRoutes);
            this.Controls.Add(this.btnDrivers);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Button btnTravelWarrants;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnCarServices;
    }
}