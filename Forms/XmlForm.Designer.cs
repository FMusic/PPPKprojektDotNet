namespace PPPKprojektDotNet.Forms
{
    partial class XmlForm
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
            this.btnChooseXMLFile = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseXMLFile
            // 
            this.btnChooseXMLFile.Location = new System.Drawing.Point(9, 10);
            this.btnChooseXMLFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseXMLFile.Name = "btnChooseXMLFile";
            this.btnChooseXMLFile.Size = new System.Drawing.Size(163, 37);
            this.btnChooseXMLFile.TabIndex = 0;
            this.btnChooseXMLFile.Text = "Choose XML file";
            this.btnChooseXMLFile.UseVisualStyleBackColor = true;
            this.btnChooseXMLFile.Click += new System.EventHandler(this.btnChooseXMLFile_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(202, 22);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(9, 51);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(163, 37);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(262, 10);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(163, 37);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // XmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 99);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnChooseXMLFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "XmlForm";
            this.Text = "XmlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseXMLFile;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
    }
}