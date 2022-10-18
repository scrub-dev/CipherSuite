using CipherSuite.AlphabetGeneration;
using CipherSuite.CipherHandling;
using CipherSuite.KeyGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Cipher c = new Cipher();
            Decipher d = new Decipher();

            Key k = new KeyVigenere("LEMONS");
            string out1 = c.vigenere(k, "HELLO WORLD");
            string out2 = d.vigenere(k, "SIXZB HSDZQ");

            Console.WriteLine(out1);
            Console.WriteLine(out2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_main());
        }
    }
}
