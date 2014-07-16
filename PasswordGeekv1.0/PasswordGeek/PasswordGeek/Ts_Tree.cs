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
    public class Ts_Tree
    {
        Node H;
        public Ts_Tree()
        {
            H = null;
        }
        public Node Head
        {
            get
            {
                return H;
            }
            set
            {
                H = value;
            }
        }
//        public void Insert(string w, string meaning)
        public void Insert(string w)
        {
            w = w.ToLower();
            char[] word;
            word = w.ToCharArray();
            Node trav = H;
            for (int i = 0; i < w.Length; i++)
            {
                Node temp = new Node();
                temp.data = word[i];
                if (H == null)
                {
                    H = temp;
                    trav = H;
                    for (i = i + 1; i < w.Length; i++)
                    {
                        trav.middle = new Node();
                        trav.middle.data = word[i];
                        trav = trav.middle;
                    }
                    if (trav.valid == false)
                    {
                        trav.valid = true;
                        //trav.synonym = meaning;
                    }
                    /*else
                    {
                        trav.synonym += "~";
                        trav.synonym += meaning;
                    }*/

                }
                else
                {
                    while (i < word.Length && trav.data != word[i])
                    {
                        if (trav.data > word[i])
                        {
                            if (trav.left != null)
                            {
                                trav = trav.left;
                            }
                            else
                            {
                                trav.left = new Node();
                                trav.left.data = word[i];
                                trav = trav.left;
                                for (i = i + 1; i < w.Length; i++)
                                {
                                    trav.middle = new Node();
                                    trav.middle.data = word[i];
                                    trav = trav.middle;
                                }
                                if (trav.valid == false)
                                {
                                    trav.valid = true;
                                 //   trav.synonym = meaning;
                                }
                         /*       else
                                {
                                    trav.synonym += "~";
                                    trav.synonym += meaning;
                                }*/
                            }

                        }

                        else if (trav.data < word[i])
                        {
                            if (trav.right != null)
                            {
                                trav = trav.right;
                            }
                            else
                            {
                                trav.right = new Node();
                                trav.right.data = word[i];
                                trav = trav.right;
                                for (i = i + 1; i < w.Length; i++)
                                {
                                    trav.middle = new Node();
                                    trav.middle.data = word[i];
                                    trav = trav.middle;
                                }
                                if (trav.valid == false)
                                {
                                    trav.valid = true;
                                   // trav.synonym = meaning;
                                }
                                /*else
                                {
                                    trav.synonym += "~";
                                    trav.synonym += meaning;
                                }*/
                            }

                        }
                    }

                    if (i == w.Length - 1)
                    {
                        if (trav.valid == false)
                        {
                            trav.valid = true;
                            //trav.synonym = meaning;
                        }
                        /*else
                        {
                            trav.synonym += "~";
                            trav.synonym += meaning;
                        }*/
                        return;
                    }
                    if (trav.middle != null)
                        trav = trav.middle;
                    else
                    {
                        for (i = i + 1; i < w.Length; i++)
                        {
                            trav.middle = new Node();
                            trav.middle.data = word[i];
                            trav = trav.middle;
                        }
                        if (trav.valid == false)
                        {
                            trav.valid = true;
                           // trav.synonym = meaning;
                        }
                        /*else
                        {
                            trav.synonym += "~";
                            trav.synonym += meaning;
                        }*/
                    }
                }
            }
        }

        public string search(string w)
        {
            char[] word = w.ToCharArray();
            Node trav = H;
            if (H == null)
                return "NOT FOUND";
            for (int i = 0; i < w.Length; i++)
            {
                while (trav.data != word[i])
                {
                    if (trav.data > word[i])
                    {
                        if (trav.left != null)
                        {
                            trav = trav.left;
                        }
                        else
                        {
                            return "NOT FOUND";
                        }
                    }
                    if (trav.data < word[i])
                    {
                        if (trav.right != null)
                        {
                            trav = trav.right;
                        }
                        else
                        {
                            return "NOT FOUND";
                        }
                    }
                }
                if (i < w.Length - 1)
                    if (trav.middle != null)
                        trav = trav.middle;
                    else
                        return "NOT FOUND";
                else
                {
                    if (trav.valid == false)
                    {
                        return "NOT FOUND";
                    }
                    else
                    {
                     //   return trav.synonym;
                        return "FOUND";
                    }
                }
            }
            return "NOT FOUND";
        }



    }
}