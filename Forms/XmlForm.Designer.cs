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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseXMLFile
            // 
            this.btnChooseXMLFile.Location = new System.Drawing.Point(12, 12);
            this.btnChooseXMLFile.Name = "btnChooseXMLFile";
            this.btnChooseXMLFile.Size = new System.Drawing.Size(217, 46);
            this.btnChooseXMLFile.TabIndex = 0;
            this.btnChooseXMLFile.Text = "Choose XML file";
            this.btnChooseXMLFile.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(269, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save to database";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // XmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnChooseXMLFile);
            this.Name = "XmlForm";
            this.Text = "XmlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseXMLFile;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
    }
}