using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Heletko_Lab07
{
    public static class Encryption
    {
        public static byte[] encryptAes(string str, byte[] key, byte[] IV)
        {
            if (str == null || str.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(str);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static string decryptAes(byte[] cipher, byte[] key, byte[] IV)
        {
            if (cipher == null || cipher.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            string decrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }

        public static byte[] encryptRijndael(string str, byte[] key, byte[] IV)
        {
            if (str == null || str.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (Rijndael rijndael = Rijndael.Create())
            {
                rijndael.Key = key;
                rijndael.IV = IV;

                ICryptoTransform encryptor = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(str);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static string decryptRijndael(byte[] cipher, byte[] key, byte[] IV)
        {
            if (cipher == null || cipher.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            string decrypted;

            using (Rijndael rijndael = Rijndael.Create())
            {
                rijndael.Key = key;
                rijndael.IV = IV;

                ICryptoTransform decryptor = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }

        public static byte[] encryptDES(string str, byte[] key, byte[] IV)
        {
            if (str == null || str.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = IV;

                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(str);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static string decryptDES(byte[] cipher, byte[] key, byte[] IV)
        {
            if (cipher == null || cipher.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            string decrypted;

            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = IV;

                ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }

        public static byte[] encryptTrDES(string str, byte[] key, byte[] IV)
        {
            if (str == null || str.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (TripleDES trDes = TripleDES.Create())
            {
                trDes.Key = key;
                trDes.IV = IV;

                ICryptoTransform encryptor = trDes.CreateEncryptor(trDes.Key, trDes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(str);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static string decrypTrDES(byte[] cipher, byte[] key, byte[] IV)
        {
            if (cipher == null || cipher.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            string decrypted;

            using (TripleDES trDes = TripleDES.Create())
            {
                trDes.Key = key;
                trDes.IV = IV;

                ICryptoTransform decryptor = trDes.CreateDecryptor(trDes.Key, trDes.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }

        public static byte[] encryptRC2(string str, byte[] key, byte[] IV)
        {
            if (str == null || str.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (RC2 rc2 = RC2.Create())
            {
                rc2.Key = key;
                rc2.IV = IV;

                ICryptoTransform encryptor = rc2.CreateEncryptor(rc2.Key, rc2.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(str);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static string decryptRC2(byte[] cipher, byte[] key, byte[] IV)
        {
            if (cipher == null || cipher.Length <= 0) throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            string decrypted;

            using (RC2 rc2 = RC2.Create())
            {
                rc2.Key = key;
                rc2.IV = IV;

                ICryptoTransform decryptor = rc2.CreateDecryptor(rc2.Key, rc2.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }
    }
}
