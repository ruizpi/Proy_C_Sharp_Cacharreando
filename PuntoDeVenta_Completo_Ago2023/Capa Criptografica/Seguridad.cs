using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Capa_Criptografica
{
    public static class Seguridad
    {
        // LA ENCRIPTACION DEBE SER FIJA DE 
        // 128, 192, or 256 bits
        // OJO, EL PATRON DEBE DE SER UNA CADENA DE UN TAMAÑO FIJO DE:
        // 32 CARACTERES
        // 24 CARACTERES
        // 16 CARACTERES

        // HERRAMIENTA PARA COMPROBAR
        // https://cifraronline.com/descifrar-aes

        public static string Patron = "44038930440389304403893044038930";

        public static string Encrypt(string textoAEncriptar, string patron)
        {

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(textoAEncriptar);
            using Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(patron);
            aes.GenerateIV();

            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(aes.IV, 0, aes.IV.Length);
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();

                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
        }




        public static string Decrypt(string cadenaCifrada, string patron)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cadenaCifrada);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(patron);
                using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                {
                    byte[] iv = new byte[aes.BlockSize / 8];
                    memoryStream.Read(iv, 0, iv.Length);
                    aes.IV = iv;
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }

        }

        /*
        #region Encriptacion básica
        public static  string Encriptar (string _cadenaAEncriptar)
        {
            string result = string.Empty; 
            byte[] encryted = Encoding.Unicode.GetBytes (_cadenaAEncriptar);    
            result = Convert.ToBase64String (encryted);
            return result;
        }

        #endregion


        #region Desencriptacion básica
        public static string DesEncriptar (static string _cadenaADesencriptar)
        {
            string result = string.Empty;
           
            byte[] decryted = Convert.FromBase64String(_cadenaADesencriptar);
            result = Encoding.Unicode.GetString(decryted);
            
            System.Text.Decoder.


            return result;

        }


        #endregion*/







    }




}
