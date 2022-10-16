using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.CipherHandling
{
    internal class CipherSuite
    {
        Decipher deciher = new Decipher();
        Cipher cipher = new Cipher();
        public enum CIPHER_TYPE{
            CEASER
        }

        public CipherSuite() { }
    }
}
