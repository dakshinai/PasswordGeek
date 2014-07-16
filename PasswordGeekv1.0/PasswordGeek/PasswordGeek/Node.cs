using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace PasswordGeek
{

    [Serializable]
    public class Node
    {
        private char c;
        private Node l;
        private Node r;
        private Node m;
        private Boolean v;
        //private string s;
        public Node()
        {
            l = null;
            r = null;
            m = null;
            v = false;
          //  s = null;

        }

        public Boolean valid
        {
            get
            {
                return v;
            }
            set
            {
                v = value;
            }
        }
        /*public string synonym
        {
            get
            {
                return s;
            }
            set
            {
                s = value;
            }
        }*/

        public char data
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public Node left
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
        public Node right
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public Node middle
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }

    }
}