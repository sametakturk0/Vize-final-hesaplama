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
    public partial class kayıtol : Form
    {
        public kayıtol()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""&&textBox2.Text==""||textBox1.Text==null &&textBox2.Text==null ||textBox2.Text==""||textBox1.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı / şifre boş geclemez","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("kayıt başarılı", "başarılı");
                giriş.kullanıcı_adı.Add(textBox1.Text);
                giriş.Şifreler.Add(textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
                kayıtol.ActiveForm.Hide();
            }
         
            
        }

        private void Mause_click_sifre(object sender, MouseEventArgs e)
        {
            
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

        private void kayıtol_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
