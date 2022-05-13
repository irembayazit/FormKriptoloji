using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKriptoloji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btmEncrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            txtEncrypt.Text = aes.AESsifrele(txtGonderici.Text, this.key);
        }

        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            txtAlici.Text = aes.AESsifre_Coz(txtEncrypt.Text, this.key);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtGonderici_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Sign imza = new Sign();
        byte[] a;
        private void btnImza_Click(object sender, EventArgs e)
        {
            this.a = imza.ImzaOlusturma(txtGonderici.Text);
            for (int i = 0; i < a.Length; i++)
                textSignAlici.Text += a[i];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textImza.Text = imza.ImzaDogrulama(txtGonderici.Text, a);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        String key="";
        private void button1_Click(object sender, EventArgs e)
        {
            int n, ee, d, phi;
            RSA rsa = new RSA();
            rsa.desgiskenTanımla(Convert.ToInt32(textP.Text), Convert.ToInt32(textQ.Text), out n, out ee, out d, out phi);
            textD.Text = Convert.ToString(d);
            textE.Text = Convert.ToString(ee);
            textN.Text = Convert.ToString(n);
            textPhi.Text = Convert.ToString(phi);
            textSifreliAnahtar.Text = rsa.RsaHesapla(textAnahtar.Text, n, ee);
            this.key = rsa.Desifreleme(textSifreliAnahtar.Text, d, n);
            textDesifreliAnahtar.Text = key;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
