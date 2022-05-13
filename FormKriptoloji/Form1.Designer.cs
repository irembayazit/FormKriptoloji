
namespace FormKriptoloji
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtGonderici = new System.Windows.Forms.TextBox();
            this.btmEncrypt = new System.Windows.Forms.Button();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textQ = new System.Windows.Forms.TextBox();
            this.textE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textImza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textSignAlici = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textDesifreliAnahtar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textSifreliAnahtar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImza = new System.Windows.Forms.Button();
            this.textPhi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textAnahtar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonImzaDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gonderici";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGonderici
            // 
            this.txtGonderici.Location = new System.Drawing.Point(133, 290);
            this.txtGonderici.Multiline = true;
            this.txtGonderici.Name = "txtGonderici";
            this.txtGonderici.Size = new System.Drawing.Size(309, 299);
            this.txtGonderici.TabIndex = 1;
            this.txtGonderici.TextChanged += new System.EventHandler(this.txtGonderici_TextChanged);
            // 
            // btmEncrypt
            // 
            this.btmEncrypt.Location = new System.Drawing.Point(130, 713);
            this.btmEncrypt.Name = "btmEncrypt";
            this.btmEncrypt.Size = new System.Drawing.Size(106, 29);
            this.btmEncrypt.TabIndex = 2;
            this.btmEncrypt.Text = "Metni sifrele";
            this.btmEncrypt.UseVisualStyleBackColor = true;
            this.btmEncrypt.Click += new System.EventHandler(this.btmEncrypt_Click);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(133, 620);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(309, 45);
            this.txtEncrypt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifreli Metin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(258, 713);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 29);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Metni Coz";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(583, 290);
            this.txtAlici.Multiline = true;
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(309, 299);
            this.txtAlici.TabIndex = 9;
            this.txtAlici.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alici";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "p: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textP
            // 
            this.textP.Location = new System.Drawing.Point(133, 29);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(90, 27);
            this.textP.TabIndex = 11;
            this.textP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "q: ";
            // 
            // textQ
            // 
            this.textQ.Location = new System.Drawing.Point(289, 29);
            this.textQ.Name = "textQ";
            this.textQ.Size = new System.Drawing.Size(89, 27);
            this.textQ.TabIndex = 13;
            // 
            // textE
            // 
            this.textE.Location = new System.Drawing.Point(733, 21);
            this.textE.Name = "textE";
            this.textE.Size = new System.Drawing.Size(89, 27);
            this.textE.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "e: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(583, 21);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(90, 27);
            this.textN.TabIndex = 15;
            this.textN.TextChanged += new System.EventHandler(this.textN_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "n: ";
            // 
            // textD
            // 
            this.textD.Location = new System.Drawing.Point(583, 64);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(89, 27);
            this.textD.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "d: ";
            // 
            // textImza
            // 
            this.textImza.Location = new System.Drawing.Point(583, 620);
            this.textImza.Multiline = true;
            this.textImza.Name = "textImza";
            this.textImza.Size = new System.Drawing.Size(309, 45);
            this.textImza.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 623);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "İmza";
            // 
            // textSignAlici
            // 
            this.textSignAlici.Location = new System.Drawing.Point(747, 531);
            this.textSignAlici.Multiline = true;
            this.textSignAlici.Name = "textSignAlici";
            this.textSignAlici.Size = new System.Drawing.Size(128, 44);
            this.textSignAlici.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Anahtar Uret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDesifreliAnahtar
            // 
            this.textDesifreliAnahtar.Location = new System.Drawing.Point(583, 198);
            this.textDesifreliAnahtar.Name = "textDesifreliAnahtar";
            this.textDesifreliAnahtar.Size = new System.Drawing.Size(385, 27);
            this.textDesifreliAnahtar.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Desifreli Anahtar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textSifreliAnahtar
            // 
            this.textSifreliAnahtar.Location = new System.Drawing.Point(583, 112);
            this.textSifreliAnahtar.Multiline = true;
            this.textSifreliAnahtar.Name = "textSifreliAnahtar";
            this.textSifreliAnahtar.Size = new System.Drawing.Size(385, 80);
            this.textSifreliAnahtar.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Sifreli Anahtar";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnImza
            // 
            this.btnImza.Location = new System.Drawing.Point(370, 713);
            this.btnImza.Name = "btnImza";
            this.btnImza.Size = new System.Drawing.Size(119, 29);
            this.btnImza.TabIndex = 29;
            this.btnImza.Text = "İmza Oluştur";
            this.btnImza.UseVisualStyleBackColor = true;
            this.btnImza.Click += new System.EventHandler(this.btnImza_Click);
            // 
            // textPhi
            // 
            this.textPhi.Location = new System.Drawing.Point(733, 64);
            this.textPhi.Name = "textPhi";
            this.textPhi.Size = new System.Drawing.Size(89, 27);
            this.textPhi.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(698, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "phi: ";
            // 
            // textAnahtar
            // 
            this.textAnahtar.Location = new System.Drawing.Point(133, 91);
            this.textAnahtar.Name = "textAnahtar";
            this.textAnahtar.Size = new System.Drawing.Size(245, 27);
            this.textAnahtar.TabIndex = 33;
            this.textAnahtar.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Anahtar";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // buttonImzaDogrula
            // 
            this.buttonImzaDogrula.Location = new System.Drawing.Point(507, 713);
            this.buttonImzaDogrula.Name = "buttonImzaDogrula";
            this.buttonImzaDogrula.Size = new System.Drawing.Size(119, 29);
            this.buttonImzaDogrula.TabIndex = 34;
            this.buttonImzaDogrula.Text = "İmza Doğrula";
            this.buttonImzaDogrula.UseVisualStyleBackColor = true;
            this.buttonImzaDogrula.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 768);
            this.Controls.Add(this.buttonImzaDogrula);
            this.Controls.Add(this.textAnahtar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textPhi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnImza);
            this.Controls.Add(this.textDesifreliAnahtar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSifreliAnahtar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSignAlici);
            this.Controls.Add(this.textImza);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmEncrypt);
            this.Controls.Add(this.txtGonderici);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt&Decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGonderici;
        private System.Windows.Forms.Button btmEncrypt;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textQ;
        private System.Windows.Forms.TextBox textE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textImza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSignAlici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textDesifreliAnahtar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSifreliAnahtar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImza;
        private System.Windows.Forms.TextBox textPhi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textAnahtar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonImzaDogrula;
    }
}

