using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographic.Utilities
{
    class DirectorySettings
    {
        public static string EncryptedFilesDirectory { get; }
        public static string DecryptedFilesDirectory { get; }
        public static string PublicKeyFile { get; }
        static DirectorySettings()
        {
            XMLDoc doc = new XMLDoc("initialData.xml");
            EncryptedFilesDirectory = doc.GetValueOf(AppConstants.ENC_DIR) + @"\";
            DecryptedFilesDirectory = doc.GetValueOf(AppConstants.DEC_DIR) + @"\";
            PublicKeyFile = doc.GetValueOf(AppConstants.PUBKEY_FILE);
        }
    }
}
