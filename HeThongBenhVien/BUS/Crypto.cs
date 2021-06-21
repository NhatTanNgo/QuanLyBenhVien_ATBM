using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Crypto : RandomGenerator
    {
        protected static String CryptoKey => "VietNamVoDich";

        

        #region Encrytion/Decryption
        TripleDES CreateDES(String key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
            //des.IV = new byte[des.BlockSize / 8];
            return des;
        }
        public String Encryption(String plainText, String key)
        {
            TripleDES des = CreateDES(key);
            String IVString = RandomString(des.BlockSize / 8);
            des.IV = Encoding.ASCII.GetBytes(IVString);

            ICryptoTransform ct = des.CreateEncryptor();
            byte[] input = Encoding.Unicode.GetBytes(plainText);
            String cypherStr = Convert.ToBase64String(ct.TransformFinalBlock(input, 0, input.Length));
            cypherStr = IVString + cypherStr;
            return cypherStr;
        }
        public String Decryption(String cypherText, String key)
        {
            TripleDES des = CreateDES(key);
            String IVString = cypherText.Substring(0, des.BlockSize / 8);
            des.IV = Encoding.ASCII.GetBytes(IVString);

            cypherText = cypherText.Substring(des.BlockSize / 8);
            byte[] b = Convert.FromBase64String(cypherText);

            ICryptoTransform ct = des.CreateDecryptor();
            byte[] output = ct.TransformFinalBlock(b, 0, b.Length);
            return Encoding.Unicode.GetString(output);
        }
        #endregion
    }
}
