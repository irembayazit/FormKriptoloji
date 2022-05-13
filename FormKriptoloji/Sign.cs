using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FormKriptoloji
{
    class Sign
    {
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public byte[] ImzaOlusturma(String mesaj)
        {
            try
            {
                System.Text.ASCIIEncoding stringEnc = new System.Text.ASCIIEncoding();
                byte[] byteMetin = stringEnc.GetBytes(mesaj);

                byte[] hash;                
                using (SHA256 sha256 = SHA256.Create())
                {
                    hash = sha256.ComputeHash(byteMetin);
                }

                RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(RSA);

                RSAFormatter.SetHashAlgorithm("SHA256");

                byte[] SignedHash = RSAFormatter.CreateSignature(hash);          
                
                return SignedHash;
            }
            catch (CryptographicException esc)
            {
                Console.WriteLine("Şifreleme Hatası Oluştu: " + esc.Message);
                return null;
            }
        }
        public String ImzaDogrulama(String mesaj, byte[] SignedHash)
        {
            try
            {
                System.Text.ASCIIEncoding stringEnc = new System.Text.ASCIIEncoding();
                byte[] byteMetin = stringEnc.GetBytes(mesaj);

                byte[] hash;
                using (SHA256 sha256 = SHA256.Create())
                {
                    hash = sha256.ComputeHash(byteMetin);
                }

                RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA);

                RSADeformatter.SetHashAlgorithm("SHA256");

                if (RSADeformatter.VerifySignature(hash, SignedHash))
                {
                   return "İmza Doğrulandı.";
                }
                else
                {
                    return "İmza Doğrulanamadı.";
                }
            }
            catch (CryptographicException esc)
            {
                return  "Şifreleme Hatası Oluştu: " + esc.Message;
            }
        }
        
    }
}
