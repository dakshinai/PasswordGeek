using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PasswordGeek
{
    class Crypography
    {
        public static RSACryptoServiceProvider rsa;
        public string crypt(string text)
        {
            string a;
            //Console.WriteLine(a = EncryptData(text));
            a = EncryptData(text);
            return a;
//            Console.WriteLine(DecryptData(a));
        }
        public void AssignParameter()
        {
            const int PROVIDER_RSA_FULL = 1;
            const string CONTAINER_NAME = "SpiderContainer";
            CspParameters cspParams;
            cspParams = new CspParameters(PROVIDER_RSA_FULL);
            cspParams.KeyContainerName = CONTAINER_NAME;
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";
            rsa = new RSACryptoServiceProvider(cspParams);
        }

        public string EncryptData(string data2Encrypt)
        {
            //MessageBox.Show(data2Encrypt);
            AssignParameter();
            StreamReader reader = new StreamReader("publickey.xml");
            string publicOnlyKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicOnlyKeyXML);
            reader.Close();

            //read plaintext, encrypt it to ciphertext

            byte[] plainbytes = System.Text.Encoding.UTF8.GetBytes(data2Encrypt);
            try
            {
                byte[] cipherbytes = rsa.Encrypt(plainbytes, false);
                return Convert.ToBase64String(cipherbytes);
            }
            catch (Exception e)
            {
                
                return "Illegal Values";
            }
            
        }

        public void AssignNewKey()
        {
            AssignParameter();

            //provide public and private RSA params
            StreamWriter writer = new StreamWriter("privatekey.xml");
            string publicPrivateKeyXML = rsa.ToXmlString(true);
            writer.Write(publicPrivateKeyXML);
            writer.Close();

            //provide public only RSA params
            writer = new StreamWriter("publickey.xml");
            string publicOnlyKeyXML = rsa.ToXmlString(false);
            writer.Write(publicOnlyKeyXML);
            writer.Close();

        }

        public string DecryptData(string data2Decrypt)
        {
            AssignParameter();

            byte[] getpassword = Convert.FromBase64String(data2Decrypt);
            
            StreamReader reader = new StreamReader("privatekey.xml");
            string publicPrivateKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicPrivateKeyXML);
            reader.Close();

            //read ciphertext, decrypt it to plaintext
            byte[] plain = rsa.Decrypt(getpassword, false);
            return System.Text.Encoding.UTF8.GetString(plain);

        }
 
    }
}
