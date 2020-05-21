using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class clsEncryption
    {
        public byte[] salt = { 0, 0, 0, 0, 0, 0, 0, 0 };
        public byte[] V = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string Encrypt(string Text, byte[] key, byte[] VectorBytes)
        {
            try
            {

                byte[] TextBytes = Encoding.UTF8.GetBytes(Text);
                RijndaelManaged rijKey = new RijndaelManaged();
                rijKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = rijKey.CreateEncryptor(key, VectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(TextBytes, 0, TextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                string cipherText = Convert.ToBase64String(cipherTextBytes);
                return cipherText;
            }
            catch
            {
                //MessageBox.Show("Error " + e.Message.ToString());
                string t = "";
                return t;
            }
        }

        public string Decrypt(string Text, byte[] keyBytes, byte[] VectorBytes)
        {
            try
            {
                byte[] TextBytes = Convert.FromBase64String(Text);
                RijndaelManaged rijKey = new RijndaelManaged();
                rijKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = rijKey.CreateDecryptor(keyBytes, VectorBytes);
                MemoryStream memoryStream = new MemoryStream(TextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] pTextBytes = new byte[TextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(pTextBytes, 0, pTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                string plainText = Encoding.UTF8.GetString(pTextBytes, 0, decryptedByteCount);
                return plainText;
            }
            catch
            {
                //MessageBox.Show(" Error " + a.Message.ToString());
                string t = "";
                return t;
            }
        }

        public string Encrypt(string Text)
        {
            try
            {
                byte[] byteKey;
                byte[] byteIV = { 22, 240, 1, 8, 13, 174, 11, 39, 255, 91, 44, 77, 15, 201, 72, 63 };

                string vstrEncryptionKey = @"3378rqklwo$52#$hhklppppp55698qwklgsxcbm,<=-)534*-\dasow@1";
                int iLength = vstrEncryptionKey.Length;
                if (iLength >= 32)
                    vstrEncryptionKey = vstrEncryptionKey.Substring(0, 32);

                byteKey = Encoding.ASCII.GetBytes(vstrEncryptionKey.ToCharArray());

                byte[] TextBytes = Encoding.UTF8.GetBytes(Text);
                RijndaelManaged rijKey = new RijndaelManaged();
                rijKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = rijKey.CreateEncryptor(byteKey, byteIV);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(TextBytes, 0, TextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                string cipherText = Convert.ToBase64String(cipherTextBytes);
                return cipherText;
            }
            catch
            {
                //MessageBox.Show("Error " + e.Message.ToString());
                string t = "";
                return t;
            }
        }

        public string Decrypt(string Text)
        {
            try
            {
                byte[] byteKey;
                byte[] byteIV = { 22, 240, 1, 8, 13, 174, 11, 39, 255, 91, 44, 77, 15, 201, 72, 63 };

                string vstrEncryptionKey = @"3378rqklwo$52#$hhklppppp55698qwklgsxcbm,<=-)534*-\dasow@1";
                int iLength = vstrEncryptionKey.Length;
                if (iLength >= 32)
                    vstrEncryptionKey = vstrEncryptionKey.Substring(0, 32);

                byteKey = Encoding.ASCII.GetBytes(vstrEncryptionKey.ToCharArray());

                byte[] TextBytes = Convert.FromBase64String(Text);
                RijndaelManaged rijKey = new RijndaelManaged();
                rijKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = rijKey.CreateDecryptor(byteKey, byteIV);
                MemoryStream memoryStream = new MemoryStream(TextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] pTextBytes = new byte[TextBytes.Length];
                    int decryptedByteCount = cryptoStream.Read(pTextBytes, 0, pTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                string plainText = Encoding.UTF8.GetString(pTextBytes, 0, decryptedByteCount);
                return plainText;
            }
            catch
            {
                //MessageBox.Show(" Error " + a.Message.ToString());
                string t = "";
                return t;
            }
        }
    }
}
