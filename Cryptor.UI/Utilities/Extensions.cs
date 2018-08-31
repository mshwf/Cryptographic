using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptor.UI.Utilities
{
    public static class Extensions
    {
        public static string AppendSlash(this string value) =>
            value + "\\";
    }
}
