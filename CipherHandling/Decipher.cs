using CipherSuite.AlphabetGeneration;
using CipherSuite.KeyGeneration;
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
        public string vigenere (Key key, string input)
        {
            string result = "";
            string key_value = key.key_value.ToUpper();
            int key_length = key_value.Length;

            for(int i = 0; i < input.Length; i++)
            {
                Alphabet a = AlphabetFactory.generate_alphabet(new string[] {Alphabet.uppercase_characters}, (int)key_value[i % (key_length)] - 65);
                result += this.caeser(a, char.ToString(input.ToUpper()[i]));
            }

            return result;
        }
    }
}
