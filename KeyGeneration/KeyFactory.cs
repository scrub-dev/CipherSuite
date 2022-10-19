using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.KeyGeneration
{
    internal class KeyFactory
    {
        public static Key generate_key(string key_value, Key.TYPE type)
        {
            Key return_key = null;
            switch (type)
            {
                case Key.TYPE.VIGENERE:
                    return_key = new Key(key_value);
                    return_key.addProperty(Key.PROPERTY.LOOP_TO_INPUT_LENGTH);
                    break;
            }
            return return_key;
        }
    }
}
