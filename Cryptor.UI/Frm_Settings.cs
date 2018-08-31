using Cryptor.UI.Utilities;
using System;
using System.Windows.Forms;

namespace Cryptor.UI
{
    public partial class Frm_Settings : Form
    {
        XMLDoc doc;
        public Frm_Settings()
        {
            InitializeComponent();
        }

        private void Frm_Settings_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnSelectEncDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.SetValueOf(AppConstants.ENC_DIR, folderBrowserDialog1.SelectedPath);
                doc.SaveDoc();
                Init();
            }
        }

        private void btnSelectDecDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.SetValueOf(AppConstants.DEC_DIR, folderBrowserDialog1.SelectedPath);
                doc.SaveDoc();
                Init();
            }
        }

        private void Init()
        {
            doc = new XMLDoc(AppConstants.SETTINGS_FILE_NAME);
            txtEncDir.Text = doc.GetValueOf(AppConstants.ENC_DIR);
            txtDecDir.Text = doc.GetValueOf(AppConstants.DEC_DIR);
            txtPubKeyDir.Text = doc.GetValueOf(AppConstants.PUBKEY_FILE);
        }

        private void btnSelectPubKeyDir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files| *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.SetValueOf(AppConstants.PUBKEY_FILE, openFileDialog1.FileName);
                doc.SaveDoc();
                Init();
            }
        }
    }
}
