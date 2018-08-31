using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptogrphic.Cryptos
{
    public class Encryption
    {
        public CspParameters Cspp { get; private set; } = new CspParameters();
        public RSACryptoServiceProvider Rsa { get; private set; }

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        string EncrFolder = @"";
        string DecrFolder = @"";
        //string SrcFolder = @"D:\Encryption\docs\";

        // Public key file
        string PubKeyFile = @"";
        private string keyName;

        // Key container name for
        // private/public key value pair.
        //const string keyName = "Key01";

        public Encryption(string _keyName) => this.keyName = _keyName;

        public void EncryptFile()
        {
            //if (rsa == null)
            //    MessageBox.Show("Key not set.");
            //else
            //{
            //    // Display a dialog box to select a file to encrypt.
            //    //openFileDialog1.InitialDirectory = SrcFolder;
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        string fName = openFileDialog1.FileName;
            //        if (fName != null)
            //        {
            //            FileInfo fInfo = new FileInfo(fName);
            //            // Pass the file name without the path.
            //            string name = fInfo.FullName;
            //            EncryptFile(name);
            //        }
            //    }
            //}
        }
    }
}
