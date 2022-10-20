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
        public static byte[] RandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes, 0 ,length);
            return bytes;
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
            output = ByteArrayToString(RandomBytes(length));
        }
        public static void RandomCharString(int length, out string output)
        {
            output = String.Empty;
            for(int i = 0; i < length; i++)
            {
                output += SecureRandomChar();
            }
        }
        public static uint SecureRandomNumber()
        {
            using(RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] x = new byte[4];
                rng.GetBytes(x);
                //return (int)BitConverter.ToInt32(x, 0);
                return BitConverter.ToUInt32(x, 0);
            }
        }
        public static char SecureRandomChar()
        {
            return (char) (65 + (SecureRandomNumber() % 26) + (RandomBool() ? 32 : 0));
        }

        public static bool RandomBool()
        {
            return new Random().NextDouble() > 0.5;
        }
    }
}
