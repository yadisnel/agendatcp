using Agenda.ModuloExc.Excepciones;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Agenda.ModeloDatos.Seguridad
{
    public class Criptografia
    {
        private static Criptografia _cripto;
        public string ByteArrayToString(byte[] byteArray)
        {            
            var sb = new StringBuilder(byteArray.Length);           
            foreach (var t in byteArray)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }
        public string EncriptarRijndaelSimple(string plainText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {           
            var initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            var saltValueBytes = Encoding.ASCII.GetBytes(saltValue);          
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);            
            var password = new PasswordDeriveBytes(passPhrase,saltValueBytes, hashAlgorithm, passwordIterations);            
            var keyBytes = password.GetBytes(keySize / 8);          
            var symmetricKey = new RijndaelManaged {Mode = CipherMode.CBC};
            var encryptor = symmetricKey.CreateEncryptor(keyBytes,initVectorBytes);
            var memoryStream = new MemoryStream();           
            var cryptoStream = new CryptoStream(memoryStream,encryptor,CryptoStreamMode.Write);           
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);           
            cryptoStream.FlushFinalBlock();           
            var cipherTextBytes = memoryStream.ToArray();          
            memoryStream.Close();
            cryptoStream.Close();          
            var cipherText = Convert.ToBase64String(cipherTextBytes);           
            return cipherText;
        }
        public string DesencriptarRijndaelSimple(string cipherText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            try
            {
                var initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                var saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
                var cipherTextBytes = Convert.FromBase64String(cipherText);
                var password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
                var keyBytes = password.GetBytes(keySize / 8);
                var symmetricKey = new RijndaelManaged {Mode = CipherMode.CBC};
                var decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                var memoryStream = new MemoryStream(cipherTextBytes);
                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                var plainTextBytes = new byte[cipherTextBytes.Length];
                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                var plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                return plainText;
            }
            catch (FormatException ex)
            {
                throw new EEncriptacion(ex.Message);
            }            
        }
        public  string CalculaHashArchivo(string pRutaArchivo)
        {
            HashAlgorithm hash = new SHA512Managed();
            var fs = new FileStream(pRutaArchivo, FileMode.Open, FileAccess.Read);
            var resul = ByteArrayToString(hash.ComputeHash(fs));
            fs.Close();
            return resul;
        }
        public static Criptografia GetCripto()
        {
            return _cripto ?? (_cripto = new Criptografia());
        }
    }
}
