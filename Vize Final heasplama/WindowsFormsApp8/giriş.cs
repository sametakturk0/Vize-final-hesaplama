using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class giriş : Form
    {
        public static List<string> kullanıcı_adı = new List<string>();
        public static List<string> Şifreler = new List<string>();
        


        public giriş()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayıtol kyt = new kayıtol();
            kyt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" || textBox1.Text == null && textBox2.Text == null || textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı / şifre hatalı giriş yaptınız ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < kullanıcı_adı.Count; i++)
                {
                    if (textBox1.Text == kullanıcı_adı[i] && textBox2.Text == Şifreler[i])
                    {
                        MessageBox.Show("Giriş Başarılı", "Başarılı");
                        Anasayfa anf = new Anasayfa();
                        anf.Show();
                    }
                }               
              
                
            }
            Anasayfa.isim = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
                
            }
            else if (checkBox1.Checked == false)
            {
                textBox2.PasswordChar = '*';
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
