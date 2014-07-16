namespace PasswordGeek
{
    partial class PasswordGeek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGeek));
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialize = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.Label();
            this.strength = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Label();
            this.master = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.store = new System.Windows.Forms.Button();
            this.retrieve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your password";
            // 
            // password
            // 
            this.password.Enabled = false;
            this.password.Location = new System.Drawing.Point(229, 29);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(253, 20);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 12);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 12);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 12);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(324, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 12);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(392, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 12);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(458, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 12);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(527, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 12);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // insert
            // 
            this.insert.Enabled = false;
            this.insert.Location = new System.Drawing.Point(198, 379);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(151, 23);
            this.insert.TabIndex = 11;
            this.insert.Text = "add to dictionary";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(77, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // serialize
            // 
            this.serialize.Enabled = false;
            this.serialize.Location = new System.Drawing.Point(355, 379);
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(75, 23);
            this.serialize.TabIndex = 13;
            this.serialize.Text = "Save";
            this.serialize.UseVisualStyleBackColor = true;
            this.serialize.Click += new System.EventHandler(this.serialize_Click);
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(628, 31);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(0, 13);
            this.value.TabIndex = 14;
            this.value.Visible = false;
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(46, 95);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(0, 13);
            this.strength.TabIndex = 15;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(226, 52);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(138, 13);
            this.warning.TabIndex = 16;
            this.warning.Text = "Do not use dictionary words";
            this.warning.Visible = false;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.Location = new System.Drawing.Point(226, 65);
            this.warning2.Name = "warning2";
            this.warning2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.warning2.Size = new System.Drawing.Size(103, 13);
            this.warning2.TabIndex = 17;
            this.warning2.Text = "Do not repeat words";
            this.warning2.Visible = false;
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.Location = new System.Drawing.Point(488, 36);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(32, 13);
            this.warning3.TabIndex = 18;
            this.warning3.Text = "Short";
            this.warning3.Visible = false;
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Location = new System.Drawing.Point(223, 199);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(91, 13);
            this.enter.TabIndex = 19;
            this.enter.Text = "Master Password:";
            // 
            // master
            // 
            this.master.Location = new System.Drawing.Point(341, 196);
            this.master.Name = "master";
            this.master.PasswordChar = '*';
            this.master.Size = new System.Drawing.Size(100, 20);
            this.master.TabIndex = 20;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(455, 194);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 21;
            this.ok.Text = "Bingo!";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(186, 168);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(163, 152);
            this.id.TabIndex = 22;
            this.id.Visible = false;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(420, 168);
            this.pwd.Multiline = true;
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(163, 152);
            this.pwd.TabIndex = 23;
            this.pwd.Visible = false;
            // 
            // store
            // 
            this.store.Enabled = false;
            this.store.Location = new System.Drawing.Point(436, 379);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(121, 23);
            this.store.TabIndex = 24;
            this.store.Text = "Store Passwords";
            this.store.UseVisualStyleBackColor = true;
            this.store.Click += new System.EventHandler(this.store_Click);
            // 
            // retrieve
            // 
            this.retrieve.Enabled = false;
            this.retrieve.Location = new System.Drawing.Point(563, 379);
            this.retrieve.Name = "retrieve";
            this.retrieve.Size = new System.Drawing.Size(117, 23);
            this.retrieve.TabIndex = 25;
            this.retrieve.Text = "Retrieve Passwords";
            this.retrieve.UseVisualStyleBackColor = true;
            this.retrieve.Click += new System.EventHandler(this.retrieve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Account  Name*";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password*";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "*Enter every  account and its corresponding password in a new line";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Click \'Store Passwords\' to save any changes";
            this.label5.Visible = false;
            // 
            // PasswordGeek
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.retrieve);
            this.Controls.Add(this.store);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.id);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.master);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.warning3);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.strength);
            this.Controls.Add(this.value);
            this.Controls.Add(this.serialize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGeek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " PasswordGeekv1.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PasswordGeek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button serialize;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Label strength;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.TextBox master;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button store;
        private System.Windows.Forms.Button retrieve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

