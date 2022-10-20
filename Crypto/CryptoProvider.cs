using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CipherSuite.Crypto
{
    internal class CryptoProvider
    {
        public static byte[] SecureRandomBytes(int length)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] x = new byte[length];
                rng.GetBytes(x);
                return x;
            }
        }
        public static string ByteArrayToString(byte[] byte_array)
        {
            string output = String.Empty;
            foreach(byte b in byte_array)
            {
                output += b.ToString();
            }
            return output;
        }
        public static void RandomByteString(int length, out string output)
        {
            output = ByteArrayToString(SecureRandomBytes(length));
        }
        public static void RandomCharString(int length, out string output)
        {
            output = String.Empty;
            for(int i = 0; i < length; i++)
            {
                output += SecureRandomChar();
            }
        }
        public static uint SecureRandomUint32()
        {
            return BitConverter.ToUInt32(SecureRandomBytes(4), 0);
        }
        public static int SecureRandomInt32()
        {
            return BitConverter.ToInt32(SecureRandomBytes(4), 0);
        }
        public static char SecureRandomChar()
        {
            return (char) (65 + (SecureRandomUint32() % 26) + (RandomBool() ? 32 : 0));
        }

        public static bool RandomBool()
        {
            return SecureRandomInt32() > 0;
        }
    }
}
