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
            // Bitwise Rule Engine
            //  > Define which ciphers require fields, keys, alphabets, offsets etc.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_main());
        }
    }
}
