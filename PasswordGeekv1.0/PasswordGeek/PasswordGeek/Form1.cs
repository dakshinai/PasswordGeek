using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security.Cryptography;

namespace PasswordGeek
{
    public partial class PasswordGeek : Form
    {
        Ts_Tree d;
        cipher ob;
        int t; //flag-correct password=>0
        Class1 cnt;
        Crypography cr;
        string master_password;
        char[] arr;
        int count;
        StreamReader fs;
        int i, n;
        int sum, sub;
        int n_char, n_upper, n_lower, n_num, n_sym, n_mid;
        int letter_only, num_only, rep_char, consecutive_upper, consecutive_lower, consecutive_num, seq_char, seq_num;
        public PasswordGeek()
        {
            cr = new Crypography();
            d = new Ts_Tree();
            ob = new cipher();
        //    cnt = new Class1();
            count = 0;
            InitializeComponent();
            arr = new char[50];
            arr[0] = ' ';
            arr[1] = ',';
            arr[2] = '-';
            arr[3] = ';';
            arr[4] = '.';
            arr[5] = '\'';
            arr[6] = '\"';
            arr[7] = '?';
            arr[8] = '=';
            arr[9] = '!';
            arr[10] = '/';
            arr[11] = ':';
            arr[12] = '&';
            arr[13] = '*';
            arr[14] = '%';
            arr[15] = '(';
            arr[16] = '@';
            arr[17] = ')';
            arr[18] = '#';
            arr[19] = '_';
            arr[20] = '^';
            arr[21] = '`';
            arr[22] = '|';
            arr[21] = '[';
            arr[22] = ']';
            arr[23] = '\\';
            arr[24] = '<';
            arr[25] = '>';
            arr[26] = '~';
            arr[27] = '0';
            arr[28] = '1';
            arr[29] = '2';
            arr[30] = '3';
            arr[31] = '4';
            arr[32] = '5';
            arr[33] = '6';
            arr[34] = '7';
            arr[35] = '8';
            arr[36] = '9';
            

        }

        private void PasswordGeek_Load(object sender, EventArgs e)
        {
            //count-serialize
            /*Stream streamc = new FileStream("count", FileMode.Create);
            BinaryFormatter bformatterc = new BinaryFormatter();
            bformatterc.Serialize(streamc, cnt);
            streamc.Close();*/
            //code to deserialize the count class1
            Stream streamc = File.Open("count", FileMode.Open);
            BinaryFormatter bformatterc = new BinaryFormatter();
            cnt = (Class1)bformatterc.Deserialize(streamc);
            streamc.Close();
            //check if the user is logging in for the first time
            if (cnt.count == 0) //first time
            {
                enter.Text = "Enter Master Password:";
            }
            else
            {
                enter.Text = "Master Password:";
            }
            //code to deserialize the dictionary
            Stream stream = File.Open("dict", FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();
            d = (Ts_Tree)bformatter.Deserialize(stream);
            stream.Close();
        }
        
        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter a word in the textbox to add to the dictionary!");
                    return;
                }
                d.Insert(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception ea)
            {
                MessageBox.Show("An error occured while inserting the word into the dictionary");
            }
        }
        //to add words to dictionary
        private void scan(string path)
        {
         //   scandirectories(path);
            foreach (string f in Directory.GetFiles(path))
            {
                //MessageBox.Show("first:"+f);
                if (f.EndsWith(".txt"))
                {
                    fs = File.OpenText(f);
                    String for_dict;
                    string[] wordlist;
                    while ((for_dict = fs.ReadLine()) != null)
                    {
                        wordlist = for_dict.Split(arr);
                        for (i = 0; i < wordlist.Length; i++)
                        {
                            if (wordlist[i].Length > 3)
                            {
                                //MessageBox.Show(wordlist[i]);
                                d.Insert(wordlist[i]);
                            }
                        }
                    }
                }
            }
        
        }
        private void scandirectories(string path)
        {

            foreach (string di in Directory.GetDirectories(path))
            {
                try
                {
                    scandirectories(di);
                    foreach (string f in Directory.GetFiles(di))
                    {
                        if (f.EndsWith(".txt"))
                        {
                            fs = File.OpenText(f);
                            String for_dict;
                            string[] wordlist;
                            while ((for_dict = fs.ReadLine()) != null)
                            {
                                wordlist = for_dict.Split(arr);
                                for (i = 0; i < wordlist.Length; i++)
                                {
                                    if (wordlist[i].Length > 3)
                                    {
                                     //   MessageBox.Show(wordlist[i]);
                                        d.Insert(wordlist[i]);
                                        count++;
                                        if (count > 25)
                                        {
                                            Stream stream = new FileStream("dict", FileMode.Create);
                                            BinaryFormatter bformatter = new BinaryFormatter();
                                            bformatter.Serialize(stream, d);
                                            stream.Close();
                                            count = 0;
                                        }
                                    }
                                }
                            }
                        }
                        // MessageBox.Show("sec:"+f);
                    }
                }
                catch
                {
                }
                finally
                {
                }
            }

        }

        private void serialize_Click(object sender, EventArgs e)
        {
            //scan("e:\\");
            try
            {


                Stream stream = new FileStream("dict", FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                //try
                //{
                bformatter.Serialize(stream, d);
                //}
                //catch (Exception ex) { }
                //finally
                //{
                stream.Close();



                MessageBox.Show("UPDATED THE DICTIONARY");
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error while updating");
            }
            //}
        }
        private float calculator() //calculates the strength and returns the percent of strength
        {
            sum += n_char * 4;
            sum += (n - n_upper) * 2;
            sum += (n - n_lower) * 2;
            sum += n_num * 4;
            sum += n_sym * 6;
            sum += n_mid * 2;
            sub += letter_only;
            sub += num_only;
            sub += (rep_char*(rep_char-1));
            sub += consecutive_lower * 2;
            sub += consecutive_upper * 2;
            sub += consecutive_num * 2;
            sub += seq_char * 2 + seq_num * 2;
            float p = sum - sub;
            //check if present in dictionary
            if (string.Compare(d.search(password.Text.ToLower()), "FOUND") == 0)
            {
                warning.Visible = true;
                warning.ForeColor = System.Drawing.Color.Red;
                p /= 2;
            }
            //check if words are repeated
            for (i = 2; i < password.Text.Length-1; i++)
            {
                string substr = password.Text.Substring(i + 1, password.Text.Length - i - 1);
                //MessageBox.Show("substr:" + substr + " ori:" + password.Text.Substring(0, i));
                if(substr.Contains(password.Text.Substring(0,i+1)))
                {
                    //MessageBox.Show(password.Text.Substring(0, i).ToLower());
                    if (string.Compare(d.search(password.Text.Substring(0, i+1).ToLower()), "FOUND") == 0)
                    {
                        warning.Visible = true;
                        warning.ForeColor = System.Drawing.Color.Red;
                        p -= 10;
                    }
                    warning2.Visible=true;
                    warning2.ForeColor=System.Drawing.Color.Red;
                    p /= 2;
                }
            }
            //if password is short
            if (password.Text.Length < 6)
            {
                p -= 10;
                warning3.ForeColor = System.Drawing.Color.Red;
                warning3.Visible = true;
            }
            //MessageBox.Show("p:" + p.ToString()+" sum:"+sum.ToString());
            if (p <= 0)
                return 0;
            if (p > 100) return 100;
            else
                return p;
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            warning.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;
            sum = sub = 0;
            letter_only = num_only = rep_char = consecutive_upper = consecutive_lower = consecutive_num = seq_char = seq_num = 0;
            n_char = n_upper = n_lower = n_num = n_sym = n_mid = 0;
            char[] word;
            n=password.Text.Length;
            word = password.Text.ToCharArray();
            
            string a = password.Text.ToLower();
            char[] sorted = a.ToCharArray();
            //Array.Sort(word);
            Array.Sort(sorted);
            for (i = 1; i < n; i++)
            {
                if (sorted[i - 1] == sorted[i])
                {
                    if (rep_char == 0)
                        rep_char += 2;
                    else
                        rep_char++;
                }
            }
            for (i = 0; i < n; i++)
            {
                int c = word[i];
                if (c > 64 && c < 91)
                {
                    n_char++;
                    n_upper++;
                    if (i > 0)
                    {
                        int q = word[i - 1];
                        if (q > 64 && q < 91)
                        {
                            if (consecutive_upper == 0)
                                consecutive_upper += 2;
                            else consecutive_upper++;
                        }
                    }
                }
                else if (c >= 97 && c <= 112)
                {
                    n_lower++;
                    n_char++;
                    if (i > 0)
                    {
                        int q = word[i - 1];
                        if (q >= 97 && q <= 112)
                        {
                            if (consecutive_lower == 0)
                                consecutive_lower += 2;
                            else consecutive_lower++;
                        }
                        if (q + 1 == c)
                            seq_char++;
                    }
                }
                else if (c >= 48 && c <= 57)
                {
                    if (i > 0)
                    {
                        int q = word[i - 1];
                        if (q >= 48 && q <= 57)
                        {
                            if (consecutive_num == 0)
                                consecutive_num += 2;
                            else consecutive_num++;
                        }
                        if (q + 1 == c)
                            seq_num++;
                    }
                    n_num++;
                }
                else
                    n_sym++;
                if (password.Text.Length > 2)
                {
                    int x = word[n - 2];
                    if (x <= 64 || (x >= 91 && x <= 96) || x > 112)
                        n_mid++;
                }
                if (n == n_char)
                    letter_only = 1;
                else if (n == n_num)
                    num_only = 1;
            }
            float percent = calculator();
            //MessageBox.Show(percent.ToString());
            value.Text = percent.ToString();
            if (percent < 25)
            {
                strength.Text = "Weak";
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button2.BackColor = System.Drawing.Color.Red;
            }
            else if (percent < 50)
            {
                strength.Text = "Fair";
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button2.BackColor = System.Drawing.Color.Orange;
                if (percent > 35)
                {
                    button3.BackColor = System.Drawing.Color.Orange;
                    button3.Visible = true;
                }
                if (percent > 45)
                {
                    button4.BackColor = System.Drawing.Color.Orange;
                    button4.Visible = true;
                }
            }
            else if (percent < 80)
            {
                strength.Text = "Strong";
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button2.BackColor = System.Drawing.Color.Yellow;
                button3.BackColor = System.Drawing.Color.Yellow;
                button4.BackColor = System.Drawing.Color.Yellow;
                button5.BackColor = System.Drawing.Color.Yellow;
                if (percent > 70)
                {
                    button6.BackColor = System.Drawing.Color.Yellow;
                    button6.Visible = true;
                }
            }
            else
            {
                strength.Text = "Very Strong";
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button2.BackColor = System.Drawing.Color.Green;
                button3.BackColor = System.Drawing.Color.Green;
                button4.BackColor = System.Drawing.Color.Green;
                button5.BackColor = System.Drawing.Color.Green;
                button6.BackColor = System.Drawing.Color.Green;
                button7.BackColor = System.Drawing.Color.Green;
                button8.BackColor = System.Drawing.Color.Green;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (master.Text == "")
            {
                MessageBox.Show("Enter a valid password");
                return;
            }
            if (cnt.count == 0)
            {
                char[] plain_pk;
                cnt.count++;
                Stream streamc1 = new FileStream("count", FileMode.Create);
                BinaryFormatter bformatterc1 = new BinaryFormatter();
                bformatterc1.Serialize(streamc1, cnt);
                streamc1.Close();
                string ms = master.Text;
                md5 ob = new md5();
                Byte[] hash = ob.md(ms);
                Stream fi = new FileStream("geeky", FileMode.Create);
                fi.Write(hash, 0, hash.Length);
                fi.Close();
                cr.AssignNewKey();
                //MessageBox.Show("wait!");
                Stream sm = new FileStream("privatekey.xml", FileMode.Open);
                byte[] pvt = new byte[(int)sm.Length + 1];
                sm.Read(pvt, 0, (int)sm.Length);
                sm.Close();
                plain_pk = new char[pvt.Length + 1];
                //convert byte array-pvt to char array and encrypt
                i = 0;
                while (i < pvt.Length)
                {
                    plain_pk[i] = Convert.ToChar(pvt[i]);
                    i++;
                }
                encrypt_double ed = new encrypt_double();
                char[] cipher_pk = ed.encrypt(plain_pk,ms.ToCharArray());
                //convert cipher_pk to byte array and write it
                byte[] towrite=new byte[cipher_pk.Length+1];
                i = 0;
                while (i < cipher_pk.Length)
                {
                    towrite[i] = Convert.ToByte(cipher_pk[i]);
                    i++;
                }
                Stream sm1 = new FileStream("privatekey.xml", FileMode.Create);
                sm1.Write(towrite, 0, towrite.Length);
                sm1.Close();
            }
            else
            {
                string ms = master.Text;
                md5 ob = new md5();
                Byte[] newhash = ob.md(ms);
                Byte[] oldhash=new Byte[newhash.Length+1];
                Stream fi = new FileStream("geeky", FileMode.Open);
                fi.Read(oldhash, 0, newhash.Length);
                fi.Close();
                int i = 0; 
                t = 0;
                while (i < oldhash.Length && i < newhash.Length)
                {
                    if (oldhash[i] != newhash[i])
                    {
                        t = 1;
                        MessageBox.Show("Wrong Password!");
                        break;
                    }
                    i++;
                }
                if (t == 0)
                    MessageBox.Show("Welcome");
                    
            }
            if (t == 0)
            {
                ok.Visible = false;
                master.Visible = false;
                enter.Visible = false;
                textBox1.Enabled = true;
                insert.Enabled = true;
                serialize.Enabled = true;
                password.Enabled = true;
                id.Visible = true;
                pwd.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                store.Enabled = true;
                retrieve.Enabled = true;
                master_password = master.Text;

            }

        }

        private void retrieve_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("success"))
                {
                    MessageBox.Show("No passwords to retrieve!");
                    return;
                }
                //decrypt the privatekey.xml
                Stream sm = new FileStream("privatekey.xml", FileMode.Open);
                byte[] e_pvt = new byte[(int)sm.Length + 1];
                sm.Read(e_pvt, 0, (int)sm.Length);
                sm.Close();
                char[] cp_pk = new char[e_pvt.Length + 1];
                //convert byte array-e_pvt to char array and decrypt
                i = 0;
                while (i < e_pvt.Length)
                {
                    cp_pk[i] = Convert.ToChar(e_pvt[i]);
                    i++;
                }
                encrypt_double ed = new encrypt_double();
                char[] pt_pk = ed.decrypt(cp_pk, master_password.ToCharArray());
                //convert pt_pk to byte array and write it
                byte[] towrite = new byte[pt_pk.Length + 1];
                i = 0;
                while (i < pt_pk.Length)
                {
                    towrite[i] = Convert.ToByte(pt_pk[i]);
                    i++;
                }
                Stream sm1 = new FileStream("privatekey.xml", FileMode.Create);
                sm1.Write(towrite, 0, towrite.Length);
                sm1.Close();



                label5.Visible = true;
                label4.Visible = false;
                //code to deserialize the cipher class1
                Stream stream = File.Open("string", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                ob = (cipher)bformatter.Deserialize(stream);
                stream.Close();
                //MessageBox.Show(cr.DecryptData(ob.getstring()));
                string plain = cr.DecryptData(ob.getstring());
                string[] del ={ "%DELIMITER&" };
                string[] user = plain.Split(del, StringSplitOptions.RemoveEmptyEntries);
                id.Text = user[0];
                pwd.Text = user[1];


                //again encrypt privatekey.xml
                Stream sma = new FileStream("privatekey.xml", FileMode.Open);
                byte[] pvt = new byte[(int)sma.Length + 1];
                sma.Read(pvt, 0, (int)sma.Length);
                sma.Close();
                char[] plain_pka = new char[pvt.Length + 1];
                //convert byte array-pvt to char array and encrypt
                i = 0;
                while (i < pvt.Length)
                {
                    plain_pka[i] = Convert.ToChar(pvt[i]);
                    i++;
                }
                encrypt_double eda = new encrypt_double();
                char[] cipher_pk = ed.encrypt(plain_pka, master_password.ToCharArray());
                //convert cipher_pk to byte array and write it
                byte[] towritea = new byte[cipher_pk.Length + 1];
                i = 0;
                while (i < cipher_pk.Length)
                {
                    towritea[i] = Convert.ToByte(cipher_pk[i]);
                    i++;
                }
                Stream sm1a = new FileStream("privatekey.xml", FileMode.Create);
                sm1a.Write(towritea, 0, towritea.Length);
                sm1a.Close();
            }
            catch (Exception eb)
            {
                MessageBox.Show("An error occured while retrieving the password");
            }
        }

        private void store_Click(object sender, EventArgs e)
        {
            try
            {
                string s1, s2;
                label4.Visible = true;
                s1 = id.Text;
                s2 = pwd.Text;
                if (s1 == "" || s2 == "")
                {
                    MessageBox.Show("Incorrect format. Empty values are not allowed!");
                    return;
                }
                string final = s1 + "%DELIMITER&" + s2;
                //decrypt the privatekey.xml
                Stream sm = new FileStream("privatekey.xml", FileMode.Open);
                byte[] e_pvt = new byte[(int)sm.Length + 1];
                sm.Read(e_pvt, 0, (int)sm.Length);
                sm.Close();
                char[] cp_pk = new char[e_pvt.Length + 1];
                //convert byte array-e_pvt to char array and decrypt
                i = 0;
                while (i < e_pvt.Length)
                {
                    cp_pk[i] = Convert.ToChar(e_pvt[i]);
                    i++;
                }
                encrypt_double ed = new encrypt_double();
                char[] pt_pk = ed.decrypt(cp_pk, master_password.ToCharArray());
                //convert pt_pk to byte array and write it
                byte[] towrite = new byte[pt_pk.Length + 1];
                i = 0;
                while (i < pt_pk.Length)
                {
                    towrite[i] = Convert.ToByte(pt_pk[i]);
                    i++;
                }
                Stream sm1 = new FileStream("privatekey.xml", FileMode.Create);
                sm1.Write(towrite, 0, towrite.Length);
                sm1.Close();





                //code to encrypt and serialize the objects
                cr = new Crypography();
                string cipher = cr.crypt(final);
                if (cipher.CompareTo("Illegal Values") != 0)
                {
                    //code to deserialize the cipher class1
                    Stream stream = File.Open("string", FileMode.Open);
                    BinaryFormatter bformatter = new BinaryFormatter();
                    ob = (cipher)bformatter.Deserialize(stream);
                    stream.Close();
                    ob.assign(cipher);
                    //serialize the cipher object
                    Stream streamc = new FileStream("string", FileMode.Create);
                    BinaryFormatter bformatterc = new BinaryFormatter();
                    bformatterc.Serialize(streamc, ob);
                    streamc.Close();
                    id.Text = "";
                    pwd.Text = "";
                }
                else
                {
                    MessageBox.Show("Illegal Values. Click 'Retrieve Passwords' to retrieve your old values.");
                }
                //again encrypt privatekey.xml
                Stream sma = new FileStream("privatekey.xml", FileMode.Open);
                byte[] pvt = new byte[(int)sma.Length + 1];
                sma.Read(pvt, 0, (int)sma.Length);
                sma.Close();
                char[] plain_pka = new char[pvt.Length + 1];
                //convert byte array-pvt to char array and encrypt
                i = 0;
                while (i < pvt.Length)
                {
                    plain_pka[i] = Convert.ToChar(pvt[i]);
                    i++;
                }
                encrypt_double eda = new encrypt_double();
                char[] cipher_pk = ed.encrypt(plain_pka, master_password.ToCharArray());
                //convert cipher_pk to byte array and write it
                byte[] towritea = new byte[cipher_pk.Length + 1];
                i = 0;
                while (i < cipher_pk.Length)
                {
                    towritea[i] = Convert.ToByte(cipher_pk[i]);
                    i++;
                }
                Stream sm1a = new FileStream("privatekey.xml", FileMode.Create);
                sm1a.Write(towritea, 0, towritea.Length);
                sm1a.Close();
                Stream sss = new FileStream("success", FileMode.Create);
                sss.Close();
            }
            catch (Exception ed)
            {
                MessageBox.Show("An error occured while storing the passwords");
            }
        
        }
    
    }
}