using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.KeyGeneration
{
    internal abstract class Key
    {
        public enum TYPE
        {
            VIGENERE
        }
        public string key_value { get; }
        public Key (string val)
        {
            this.key_value = val;
        }
    }
}
