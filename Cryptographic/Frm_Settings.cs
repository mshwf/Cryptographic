using Cryptographic.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptographic
{
    public partial class Frm_Settings : Form
    {
        string encDirectory, decDirectory;
        public Frm_Settings()
        {
            InitializeComponent();
        }

        private void Frm_Settings_Load(object sender, EventArgs e)
        {
            txtEncDir.Text = XMLHelper.GetValueOf("encryptedDir");
            txtDecDir.Text = XMLHelper.GetValueOf("decryptedDir");
        }

        private void btnSelectEncDir_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
