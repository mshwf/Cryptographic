using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographic.UI.Utilities
{
    class DirectorySettings
    {
        public string EncryptedFilesDirectory { get; private set; }
        public string DecryptedFilesDirectory { get; private set; }
        public string PublicKeyFile { get; private set; }
        public DirectorySettings()
        {
            XMLDoc doc = new XMLDoc(AppConstants.SETTINGS_FILE_NAME);
            EncryptedFilesDirectory = doc.GetValueOf(AppConstants.ENC_DIR) + @"\";
            DecryptedFilesDirectory = doc.GetValueOf(AppConstants.DEC_DIR) + @"\";
            PublicKeyFile = doc.GetValueOf(AppConstants.PUBKEY_FILE);
        }
    }
}
