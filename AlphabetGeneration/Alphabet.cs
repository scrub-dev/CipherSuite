using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CipherSuite
{
    internal class Alphabet
    { 
        public static string uppercase_characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string lowercase_characters = "abcdefghijklmnopqrstuvwxyz";
        public static string numbers = "0123456789";

        public string alphabet, original_alphabet;

        public Alphabet(string alphabet)
        {
            this.alphabet = alphabet;
        }

        public void apply_offset (int offset)
        {
            original_alphabet = alphabet;
            string alphabet_a = alphabet.Substring(offset);
            string alphabet_b = alphabet.Substring(0, offset);

            alphabet = alphabet_a + alphabet_b;
        }
    }

}
