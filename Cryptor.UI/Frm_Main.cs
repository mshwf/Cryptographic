/*
The source code from docs (with some modifications): 
https://docs.microsoft.com/en-us/dotnet/standard/security/walkthrough-creating-a-cryptographic-application
*/
using System;
using System.Windows.Forms;
using System.IO;
using Cryptor.UI.Utilities;
using Cryptor.Cryptos;

namespace Cryptor.UI
{
    public partial class Frm_Main : Form
    {
        Encryption encryption;


        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        string encrFolder = @"";
        string decrFolder = @"";
        //string SrcFolder = @"D:\Encryption\docs\";

        // Public key file
        string pubKeyFile = @"";

        // Key container name for
        // private/public key value pair.
        const string keyName = "Key01";

        public Frm_Main()
        {
            InitializeComponent();
            SetFoldersPaths();
            encryption = new Encryption(keyName, encrFolder, decrFolder, pubKeyFile);
        }

        private void SetFoldersPaths()
        {
            XMLDoc doc = new XMLDoc(AppConstants.SETTINGS_FILE_NAME);
            encrFolder = doc.GetValueOf(AppConstants.ENC_DIR).AppendSlash();
            decrFolder = doc.GetValueOf(AppConstants.DEC_DIR).AppendSlash();
            pubKeyFile = doc.GetValueOf(AppConstants.PUBKEY_FILE);
            DisableIfPathsNotSet();
        }

        private void DisableIfPathsNotSet()
        {
            if (!(Directory.Exists(encrFolder) && Directory.Exists(decrFolder) && File.Exists(pubKeyFile)))
            {
                groupBox1.Enabled = false;
                MessageBox.Show("Please set required paths in Settings, and make sure all paths are correct.");
                mnuSettings_Click(null, null);
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void buttonCreateAsmKeys_Click(object sender, EventArgs e)
        {
            encryption.CreateAsmKeys();
            if (encryption.Rsa.PublicOnly == true)
                toolStripStatusLabel1.Text = "Key: " + encryption.Cspp.KeyContainerName + " - Public Only";
            else
                toolStripStatusLabel1.Text = "Key: " + encryption.Cspp.KeyContainerName + " - Full Key Pair";
        }

        private void buttonEncryptFile_Click(object sender, EventArgs e)
        {
            if (encryption.Rsa == null)
                MessageBox.Show("Key not set.");
            else
            {
                // Display a dialog box to select a file to encrypt.
                //openFileDialog1.InitialDirectory = SrcFolder;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog1.FileName;
                    if (fName != null)
                    {
                        FileInfo fInfo = new FileInfo(fName);
                        // Pass the file name without the path.
                        string name = fInfo.FullName;
                        encryption.EncryptFile(name);
                    }
                }
            }
        }

        private void buttonDecryptFile_Click(object sender, EventArgs e)
        {
            if (encryption.Rsa == null)
                MessageBox.Show("Key not set.");
            else
            {
                // Display a dialog box to select the encrypted file.
                openFileDialog2.InitialDirectory = encrFolder;
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog2.FileName;
                    if (fName != null)
                    {
                        FileInfo fi = new FileInfo(fName);
                        string name = fi.Name;
                        encryption.DecryptFile(name);
                    }
                }
            }
        }

        void buttonExportPublicKey_Click(object sender, EventArgs e)
        {
            encryption.ExportPublicKey();
        }

        void buttonImportPublicKey_Click(object sender, EventArgs e)
        {
            encryption.ImportPublicKey();
            if (encryption.Rsa.PublicOnly == true)
                toolStripStatusLabel1.Text = "Key: " + encryption.Cspp.KeyContainerName + " - Public Only";
            else
                toolStripStatusLabel1.Text = "Key: " + encryption.Cspp.KeyContainerName + " - Full Key Pair";
        }

        private void buttonGetPrivateKey_Click(object sender, EventArgs e)
        {
            encryption.GetPrivateKey();

            if (encryption.Rsa.PublicOnly == true)
                toolStripStatusLabel1.Text = "Key: " + encryption.Cspp.KeyContainerName + " - Public Only";
            else
                toolStripStatusLabel1.Text = "Key: " + encryption.Cspp.KeyContainerName + " - Full Key Pair";
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            Frm_Settings frm = new Frm_Settings();
            frm.ShowDialog();
            SetFoldersPaths();
        }

        private void mnuExit_Click(object sender, EventArgs e) => Close();

    }
}
