using CipherSuite.AlphabetGeneration;
using CipherSuite.KeyGeneration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.CipherHandling
{
    internal class Cipher
    {
        public static string caeser(Alphabet alphabet, string input)
        {
            string result = "";
            foreach (char x in input)
            {
                int char_index = alphabet.original_alphabet.IndexOf(x);
                if (!char_index.Equals(-1)) result += alphabet.alphabet[char_index];
                else result += x;
            }
            return result;
        }
        public static string vigenere(Key key, string input)
        {
            return Decipher.vigenere(key, input.ToUpper(), CipherSuite.MODE.ENCRYPT);
        }
        public static string substitution(Key k, string input)
        {
            string result = "";
            foreach (char x in input.ToUpper())
            {
                int char_index = Alphabet.uppercase_characters.IndexOf(x);
                if (!char_index.Equals(-1)) result += k.Value.ToUpper()[char_index];
                else result += x;
            }
            return result;
        }
    }
}
