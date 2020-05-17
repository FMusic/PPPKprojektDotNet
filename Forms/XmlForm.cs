using PPPKprojektDotNet.Datebase;
using PPPKprojektDotNet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPKprojektDotNet.Forms
{
    public partial class XmlForm : Form
    {
        public XmlForm()
        {
            InitializeComponent();
        }

        private void btnChooseXMLFile_Click(object sender, EventArgs e)
        {
            string filepath="";
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofd.FileName;
                }
            }
            lblStatus.Text = "Loading all data...";
            Ishod5.SaveAllDataFromXml(filepath);
            lblStatus.Text = "Data restored";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string res = Ishod5.GetAllDataFromDb();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "xml files (*.xml)|*.xml";
                sfd.DefaultExt = "xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, res);
                }
            }

        }
    }
}
