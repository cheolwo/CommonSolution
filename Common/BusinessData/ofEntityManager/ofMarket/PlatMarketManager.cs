using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofDataAccessLayer.ofMarket.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofEntityManager.ofMarket.ofIdFactory;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.ofEntityManager.ofMarket
{
    public interface IPlatMarketFileFactory : ICenterFileFactory<PlatMarket>
    {

    }
    public interface IPlatMarketBlobStorage : IEntityBlobStorage<PlatMarket>
    {

    }
    public interface IPlatMarketManager : ICenterManager<PlatMarket>
    {

    }
    public class PlatMarketManager : CenterManager<PlatMarket>, IPlatMarketManager
    {
        private readonly PlatMarketPasswordHasher _platMarketPasswordHasher;
        public PlatMarketManager(IPlatMarketRepository PlatMarketDataRepository,
                               IPlatMarketIdFactory PlatMarketIdFactory,
                               IPlatMarketFileFactory PlatMarketFileFactory,
                               IPlatMarketBlobStorage blobStorage,
                               PlatMarketPasswordHasher platMarketPasswordHasher,                         
                            DicConvertFactory<PlatMarket> dicConvertFactory)
            : base(PlatMarketDataRepository, PlatMarketIdFactory, PlatMarketFileFactory, blobStorage, dicConvertFactory, platMarketPasswordHasher)
        {
            _platMarketPasswordHasher = platMarketPasswordHasher;
        }
        public Dictionary<MarketKey, string> ValidatePassword(PlatMarket platmarket, string Inputpassword)
        {
            var Result = _platMarketPasswordHasher.VerifyHashedPasswordofPlatMarket(platmarket, platmarket.Password, Inputpassword);
            if(Result !=  null)
            {
                return Result;
            }
            throw new ArgumentNullException("Key Value Is Null");
        }
    }
    public enum MarketKey {AccessKey = 0, SecreatKey = 1}
    public class PlatMarketPasswordHasher : CenterPasswordHasher<PlatMarket>
    {
        public PlatMarket HashPassword(PlatMarket platMarket, string password, string AccessKey, string SecreatKey)
        {
            if(platMarket.VendorId is null) { throw new ArgumentNullException("Vendor Id Is Null");}
            if(platMarket.Password is null) { throw new ArgumentNullException("Pasword Is Null");}
            if(platMarket.AccessKey is null) { throw new ArgumentNullException("AccessKey Is null");}
            if(platMarket.SecreatKey is null) { throw new ArgumentNullException("SecreatKey is null");}
            if(password is null) { throw new ArgumentNullException("Password is Null");}

            using (Aes myAes = Aes.Create())
            {
                byte[] AesKeyByPassword = Encoding.UTF8.GetBytes(password);
                myAes.IV = Encoding.UTF8.GetBytes(platMarket.NameofPlatForm);
                // Encrypt the string to an array of bytes.
                byte[] encryptedAccessKey = EncryptStringToBytes_Aes(AccessKey, AesKeyByPassword, myAes.IV);
                byte[] encryptedSecreatKey = EncryptStringToBytes_Aes(SecreatKey, AesKeyByPassword, myAes.IV);

                if(encryptedAccessKey.Length <= 0 || encryptedAccessKey == null) {throw new ArgumentNullException("EnAccessKey is NULL");}
                if(encryptedSecreatKey.Length <= 0 || encryptedSecreatKey == null) { throw new ArgumentNullException("EnSecreatKey is Null");}
                platMarket.AccessKey = encryptedAccessKey;
                platMarket.SecreatKey = encryptedSecreatKey;
                string EnPassword = base.HashPassword(platMarket, password);
                if(EnPassword != null) {platMarket.Password = EnPassword;}
            }
            return platMarket;

        }
        public Dictionary<MarketKey, string> VerifyHashedPasswordofPlatMarket(PlatMarket platMarket, string hashedPassword, string providedPassword)
        {
            var Result = base.VerifyHashedPassword(platMarket, hashedPassword, providedPassword);
            if(Result.Equals(PasswordVerificationResult.Success))
            {
                var password = Encoding.UTF8.GetBytes(providedPassword);
                var IV = Encoding.UTF8.GetBytes(platMarket.NameofPlatForm);
                string DeAccessKey = DecryptStringFromBytes_Aes(platMarket.AccessKey, password, IV);
                string DeSecreatKey = DecryptStringFromBytes_Aes(platMarket.SecreatKey, password, IV);
                Dictionary<MarketKey, string> KeyValue = new();
                KeyValue.Add(MarketKey.AccessKey, DeAccessKey);
                KeyValue.Add(MarketKey.SecreatKey, DeSecreatKey);
                return KeyValue;
            }
            else{
                throw new ArgumentNullException("Password is not correspondence");
            }
        }
        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
                
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
    }
}