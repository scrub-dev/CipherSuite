using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.CipherHandling
{
    internal class Decipher
    {
        public string caeser(Alphabet alphabet, string input)
        {
            string result = "";
            foreach (char x in input){
                int char_index = alphabet.alphabet.IndexOf(x);
                if (!char_index.Equals(-1)) result += alphabet.original_alphabet[char_index];
                else result += x;
            }
            return result;
        }
    }
}
