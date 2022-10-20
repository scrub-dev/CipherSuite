using CipherSuite.AlphabetGeneration;
using CipherSuite.CipherHandling;
using CipherSuite.Crypto;
using CipherSuite.KeyGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherSuite
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TODO:
            // AutoKey Cipher
            // Bitwise Rule Engine
            //  > Define which ciphers require fields, keys, alphabets, offsets etc.
            Key k = KeyFactory.generate_key("LEMON", Key.TYPE.VIGENERE);
            string out1 = Cipher.vigenere(k, "HELLO WORLD");
            string out2 = Decipher.vigenere(k, "SIXZB HSDZQ");

            Console.WriteLine(out1);
            Console.WriteLine(out2);
            CryptoProvider.RandomCharString(10, out string out3);
            Console.WriteLine(out3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_main());
        }
    }
}
