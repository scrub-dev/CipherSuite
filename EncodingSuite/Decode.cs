using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.EncodingSuite
{
    internal class Decode
    {
        public static string base64(string input, EncodingSuite.TYPE to)
        {
            string outputString = string.Empty;
            byte[] bytes = System.Convert.FromBase64String(input);

            switch(to){
                case EncodingSuite.TYPE.UTF8:
                    outputString = System.Text.Encoding.UTF8.GetString(bytes);
                    break;
                case EncodingSuite.TYPE.HEXIDECIMAL:
                    break;
            }
            return outputString;
        }
    }
}
