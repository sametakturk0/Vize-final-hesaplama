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
    public partial class Detay : Form
    {
        public static List<string> kalanlar = new List<string>();
        public static List<string> gecenler = new List<string>();
        public static double toplam = 0; 
        public static double ort = 0;
        public static double sayac = 0;


        public Detay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detay.ActiveForm.Hide();
        }

        private void Detay_Load(object sender, EventArgs e)
        {
            ort = toplam  / sayac ;
            
            for (int i = 0; i < kalanlar.Count; i++)
            {
                listBox2.Items.Add(kalanlar[i]);
                
            }
            for (int i = 0; i < gecenler.Count; i++)
            {
                listBox1.Items.Add(gecenler[i]);
              
            }
             label6.Text = toplam.ToString();
             label4.Text = ort.ToString();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int index1 = listBox1.SelectedIndex; 
            int index2 = listBox2.SelectedIndex;
            if (index1 > -1)
            {
                listBox1.Items.RemoveAt(index1);              
                toplam -= int.Parse(label8.Text);
                sayac--;
                label6.Text = toplam.ToString();
                ort = toplam / sayac;
                ort.ToString();
                label4.Text = ort.ToString();
            }
            else if (index2 > -1)
            {
                listBox2.Items.RemoveAt(index2);                
                toplam -= int.Parse(label7.Text);
                sayac--;
                label6.Text = toplam.ToString();
                ort = toplam / sayac;
                label4.Text = ort.ToString();
                
            }
            else
            {
                MessageBox.Show("Öne cıkarılıcak elamanı secmelisiniz.", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

     

        private void listbox1_clisk(object sender, MouseEventArgs e)
        {
            string parcalanort1 =listBox1.SelectedItem.ToString().Substring(0, 2);
            label8.Text = parcalanort1;
        }

       

        private void listbox2_click(object sender, MouseEventArgs e)
        {
            string parcalanort = listBox2.SelectedItem.ToString().Substring(0, 2);
            label7.Text = parcalanort;
        }
    }
}
