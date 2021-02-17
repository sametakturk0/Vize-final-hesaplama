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
    
    public partial class Anasayfa : Form
     
    {
        

        public Anasayfa()
        {
            InitializeComponent();
        }
        int vize;
        int final;
        int ortalama = 0;
        public static string isim;
     
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            vize = (40 * 100) / 100;
            final = (60 * 100) / 100;
            vize = int.Parse(textBox2.Text);
            final = int.Parse(textBox3.Text);           
            ortalama = (vize + final) / 2;   
            
          
            if(checkBox1.CheckState==CheckState.Unchecked&&checkBox2.CheckState==CheckState.Unchecked&& checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked
                || checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Unchecked
                || checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("lütfen bir Kız / Erkek cinseyeti secin","Hata");
            }
            else if (checkBox1.Checked)
            {
                listBox1.Items.Add(textBox1.Text + " - " + ortalama + " - " + checkBox1.Text);
            }
            else if (checkBox2.Checked)
            {
                listBox1.Items.Add(textBox1.Text + " - " + ortalama + " - " + checkBox2.Text);
            }
            if(ortalama <50 )
            {
                Detay.kalanlar.Add(ortalama+" - "+textBox1.Text);                            
                Detay.toplam+=ortalama;
                Detay.sayac++;
            }
            else if(ortalama >=50)
            {
                Detay.gecenler.Add(ortalama+" - "+textBox1.Text);
                Detay.toplam += ortalama;
                Detay.sayac++;
            }  
        }
       

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = isim;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detay dty = new Detay();
            dty.Show(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
