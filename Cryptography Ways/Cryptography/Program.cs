using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Original Name to be used for hashing and encryption
            string Name = "Ghayath Alali";

            // Hashing the name using a hashing method from clsHelper
            Console.WriteLine("Hashing way:");
            Console.WriteLine($"My name before hashing: {Name}");
            Console.WriteLine($"My name after hashing: {clsHelper.ComputeHash(Name)}");

            Console.WriteLine("\n\n");

            // Symmetric encryption and decryption using AES
            string key = "1234567890123456"; // 16 bytes key (128 bits) for AES encryption
            string EncryptName = clsHelper.SymmetricEncrypt(Name, key);  // Encrypt the name
            string DecryptName = clsHelper.SymmetricDecrypt(EncryptName, key); // Decrypt the name

            Console.WriteLine("Symmetric way:");
            Console.WriteLine($"My name before encryption: {Name}");
            Console.WriteLine($"My name after encryption: {EncryptName}");
            Console.WriteLine($"My name after decryption: {DecryptName}");

            Console.WriteLine("\n\n");

            // Asymmetric encryption and decryption using RSA
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Export public and private keys from RSA
                string publicKey = rsa.ToXmlString(false);  // Public key (for encryption)
                string privateKey = rsa.ToXmlString(true);  // Private key (for decryption)

                // Encrypt and decrypt using RSA with the generated keys
                string AEncryptName = clsHelper.ASymmetricEncrypt(Name, publicKey);  // Asymmetric encryption (using public key)
                string ADecryptName = clsHelper.ASymmetricDecrypt(AEncryptName, privateKey);  // Asymmetric decryption (using private key)

                Console.WriteLine("Asymmetric way:");
                Console.WriteLine($"My name before encryption: {Name}");
                Console.WriteLine($"My name after encryption: {AEncryptName}");
                Console.WriteLine($"My name after decryption: {ADecryptName}");
            }


            //Put you image path
            //string inputFile = "C:\\Image\\20210623_211659.jpg";
            //string encryptedFile = "c:\\Image\\encrypted.jpg";
            //string decryptedFile = "c:\\Image\\decrypted.jpg";
            string Ekey = "1234567890123456";

            // Generate a random IV for each encryption operation
            byte[] iv;
            using (Aes aesAlg = Aes.Create())
            {
                iv = aesAlg.IV;
            }
            clsHelper.EncryptFile(inputFile, encryptedFile, Ekey, iv);
            clsHelper.DecryptFile(encryptedFile, decryptedFile, Ekey, iv);



            Console.WriteLine("\n\n\nEncrypt image successfully!");

            Console.ReadKey();
        }
    }
}
