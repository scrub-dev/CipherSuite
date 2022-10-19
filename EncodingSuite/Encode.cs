using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.EncodingSuite
{
    internal class Encode
    {
        public static string base64(string input, EncodingSuite.TYPE from)
        {
            string outputString = string.Empty;
            if (from.Equals(EncodingSuite.TYPE.UTF8))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                outputString = Convert.ToBase64String(bytes);
            }
            return outputString;
        }
    }
}
