using CipherSuite.AlphabetGeneration;
using CipherSuite.KeyGeneration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CipherSuite.CipherHandling
{
    internal class Decipher
    {
        private static readonly Regex whitespaces = new Regex(@"\s+");

        public static string caeser(Alphabet alphabet, string input)
        {
            string result = "";
            foreach (char x in input){
                int char_index = alphabet.alphabet.IndexOf(x);
                if (!char_index.Equals(-1)) result += alphabet.original_alphabet[char_index];
                else result += x;
            }
            return result;
        }
        public static string vigenere(Key key, string input)
        {
            return vigenere(key, input, CipherSuite.MODE.DECRYPT);
        }
        public static string vigenere(Key key, string input, CipherSuite.MODE vigenere_mode)
        {
            ArrayList result = new ArrayList();
            ArrayList space_indecies = new ArrayList();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') space_indecies.Add(i);
            }

            string modified_input = whitespaces.Replace(input, "");

            for(int i = 0; i < modified_input.Length; i++)
            {
                Alphabet a = AlphabetFactory.generate_alphabet(new string[] {Alphabet.uppercase_characters}, key.getCharAt(i) - 65);
                if (vigenere_mode.Equals(CipherSuite.MODE.ENCRYPT)) result.Add(Cipher.caeser(a, char.ToString(modified_input.ToUpper()[i])));
                else if(vigenere_mode.Equals(CipherSuite.MODE.DECRYPT)) result.Add(Decipher.caeser(a, char.ToString(modified_input.ToUpper()[i])));
            }

            if(space_indecies.Count > 0)
            {
                for(int i = 0; i < input.Length; i++)
                {
                    if (space_indecies.Contains(i)) result.Insert(i, ' ');
                }
            }
            return CipherSuite.CharListToString(result);
        }
        public static string autokey(Key key, string input)
        {
            key.Value += input.ToUpper();
            return vigenere(key, input);
        }
    }
}
