using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace EngineerWebService
{
    public class Common
    {
        /// <summary>
        /// createds salt for password
        /// </summary>
        /// <returns></returns>
        public static string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] byteArr = new byte[30];
            rng.GetBytes(byteArr);

            return Convert.ToBase64String(byteArr);
        }

        /// <summary>
        /// generates hash key for salt+password
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string CreatePasswordHash(string password, string salt)
        {
            string passwrodSalt = String.Concat(password, salt);
            MD5 algorithm = MD5.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwrodSalt));
            string md5 = "";
            for (int i = 0; i < data.Length; i++)
            {
                md5 += data[i].ToString("x2").ToUpperInvariant();
            }
            return md5;
        }

        /// <summary>
        /// Encrypt text
        /// </summary>
        /// <param name="plainText">Text to encrypt</param>
        /// <param name="encryptionPrivateKey">Encryption private key</param>
        /// <returns>Encrypted text</returns>
        //public static string EncryptText(string plainText, string encryptionPrivateKey = "")
        //{
        //    if (string.IsNullOrEmpty(plainText))
        //        return plainText;

        //    if (String.IsNullOrEmpty(encryptionPrivateKey))
        //        encryptionPrivateKey = System.Configuration.ConfigurationSettings.AppSettings["EncryptionKey"];

        //    var tDESalg = new TripleDESCryptoServiceProvider();
        //    tDESalg.Key = new ASCIIEncoding().GetBytes(encryptionPrivateKey.Substring(0, 16));
        //    tDESalg.IV = new ASCIIEncoding().GetBytes(encryptionPrivateKey.Substring(8, 8));

        //    byte[] encryptedBinary = EncryptTextToMemory(plainText, tDESalg.Key, tDESalg.IV);
        //    return Convert.ToBase64String(encryptedBinary);
        //}

        /// <summary>
        /// Decrypt text
        /// </summary>
        /// <param name="cipherText">Text to decrypt</param>
        /// <param name="encryptionPrivateKey">Encryption private key</param>
        /// <returns>Decrypted text</returns>
        //public static string DecryptText(string cipherText, string encryptionPrivateKey = "")
        //{
        //    if (String.IsNullOrEmpty(cipherText))
        //        return cipherText;

        //    if (String.IsNullOrEmpty(encryptionPrivateKey))
        //        encryptionPrivateKey = System.Configuration.ConfigurationSettings.AppSettings["EncryptionKey"];

        //    var tDESalg = new TripleDESCryptoServiceProvider();
        //    tDESalg.Key = new ASCIIEncoding().GetBytes(encryptionPrivateKey.Substring(0, 16));
        //    tDESalg.IV = new ASCIIEncoding().GetBytes(encryptionPrivateKey.Substring(8, 8));

        //    byte[] buffer = Convert.FromBase64String(cipherText);
        //    return DecryptTextFromMemory(buffer, tDESalg.Key, tDESalg.IV);
        //}

        #region Utilies

        private static byte[] EncryptTextToMemory(string data, byte[] key, byte[] iv)
        {
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, new TripleDESCryptoServiceProvider().CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    byte[] toEncrypt = new UnicodeEncoding().GetBytes(data);
                    cs.Write(toEncrypt, 0, toEncrypt.Length);
                    cs.FlushFinalBlock();
                }

                return ms.ToArray();
            }
        }

        private static string DecryptTextFromMemory(byte[] data, byte[] key, byte[] iv)
        {
            using (var ms = new MemoryStream(data))
            {
                using (var cs = new CryptoStream(ms, new TripleDESCryptoServiceProvider().CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    var sr = new StreamReader(cs, new UnicodeEncoding());
                    return sr.ReadLine();
                }
            }
        }

        #endregion

        //public static void SaveHistory(ClaimHistory model)
        //{
        //    claimsiteV2_TestEntities db = new claimsiteV2_TestEntities();
        //    model.Id = Guid.NewGuid();
        //    db.ClaimHistories.AddObject(model);
        //    db.SaveChanges();
        //}
    }
}