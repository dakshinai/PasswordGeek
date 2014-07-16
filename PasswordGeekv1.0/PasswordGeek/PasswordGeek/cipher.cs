using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGeek
{
    [Serializable]
    class cipher
    {
        string cip;
        public cipher()
        {
        }
        public void assign(string s)
        {
            cip=s;
        }
        public string getstring()
        {
            return cip;
        }
    }
}
