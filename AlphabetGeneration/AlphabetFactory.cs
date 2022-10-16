using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.AlphabetGeneration
{
    internal class AlphabetFactory
    {
        public static Alphabet generate_alphabet(string[] characters_array, int offset)
        {
            string characters = string.Join("", characters_array);
            Alphabet alphabet = new Alphabet(characters);
            alphabet.apply_offset(offset);
            return alphabet;
        }
    }
}
