using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGeek
{
    class encrypt_double
    {
        char[] key, key1, cipher, plain, ans;
        string final;
        int i;

        /*public void (string[] args)
        {
            encrypt_double("sharmi".ToCharArray(), "daks".ToCharArray());
            char[] cipher = encrypt();
            char[] p = decrypt(cipher, "daks".ToCharArray());
            Console.WriteLine(p);
            Console.ReadKey();
        }*/
        public char[] decrypt(char[] cipher, char[] b)
        {
            key1 = new char[cipher.Length + 1];
            for (i = 0; i < b.Length; i++)
                key1[i] = b[i];
            int j;
            int asci = 48;
            int mod = 112 - 48 + 1;
            int inc = -1;
            while (i < cipher.Length)
            {
                inc = (inc + 1) % mod;
                int k = asci + mod;
                for (j = 0; j < b.Length && k != b[j]; j++) ;
                if (j != b.Length)
                    continue;
                else
                {
                    key1[i] = (char)k;
                    i++;
                }
            }
            ans = new char[cipher.Length + 1];
            for (i = 0; cipher[i] != '\0'; i++)
            {
                ans[i] = (char)(cipher[i] - key1[i]);
            }
            return ans;
        }
        public char[] encrypt(char[] a, char[] b)
        {
            key = new char[a.Length + 1];
            plain = new char[a.Length + 1];
            for (i = 0; i < a.Length; i++)
                plain[i] = a[i];
            for (i = 0; i < b.Length; i++)
                key[i] = b[i];

            int j;
            int asci = 48;
            int mod = 112 - 48 + 1;
            int inc = -1;
            while (i < a.Length)
            {
                inc = (inc + 1) % mod;
                int k = asci + mod;
                for (j = 0; j < b.Length && k != b[j]; j++) ;
                if (j != b.Length)
                    continue;
                else
                {
                    key[i] = (char)k;
                    i++;
                }
            }
            cipher = new char[plain.Length + 1];
            for (i = 0; plain[i] != '\0'; i++)
            {
                cipher[i] = (char)(plain[i] + key[i]);
            }
            return cipher;
        }

    }
}
