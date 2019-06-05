using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Auth.WebApi.Attributes
{
    public static class Encryption
    {
        const string passKey = "t2s45p7uiy0e3d5f";

        public static string Crypt(string text)
        {
            RijndaelManaged aes256 = new RijndaelManaged();
            aes256.KeySize = 256;
            aes256.BlockSize = 128;
            aes256.Padding = PaddingMode.Zeros;
            aes256.Mode = CipherMode.ECB;
            aes256.Key = Encoding.ASCII.GetBytes(passKey);
            aes256.GenerateIV();

            ICryptoTransform encryptor = aes256.CreateEncryptor();
            using (MemoryStream ms = new MemoryStream())
            {
                CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                StreamWriter mSWriter = new StreamWriter(cs);
                mSWriter.Write(text);
                mSWriter.Flush();
                cs.FlushFinalBlock();
                byte[] cypherTextBytes = ms.ToArray();
                ms.Close();
                return Convert.ToBase64String(cypherTextBytes);
            }
        }
        public static string Decrypt(string text)
        {
            RijndaelManaged aes256 = new RijndaelManaged();
            aes256.KeySize = 256;
            aes256.BlockSize = 128;
            aes256.Padding = PaddingMode.Zeros;
            aes256.Mode = CipherMode.ECB;
            aes256.Key = Encoding.ASCII.GetBytes(passKey);
            aes256.GenerateIV();
            byte[] encryptedData = Convert.FromBase64String(text);
            ICryptoTransform transform = aes256.CreateDecryptor();
            byte[] plainText = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText).TrimEnd('\0');
        }
    }
}
