using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            String[] Urunlist = new string[5];
            Urunlist[0] = "Araba";
            Urunlist[1] = "Uçak";
            Urunlist[2] = "Tren";
            Urunlist[3] = "Gemi";
            Urunlist[4] = "Supra";
 

            lbrbaslik.Text = "Ürünler";
            btninsert.Text = "Ekle";
            //lbxUrunler.Items.





            foreach(String uruns in Urunlist){
                lbxUrunler.Items.Add(uruns);
            }
            lbrcount.Text = lbxUrunler.Items.Count.ToString();

        }


        private void makeing_Click(object sender, EventArgs e)
        {

            lbrbaslik.Text = "Products";
            makeing.Text = "English";
            maketurkish.Text = "Turkish";
            uruncountbaslik.Text = "Total Product:";

            btninsert.Text = "Insert";

        }

        private void maketurkish_Click(object sender, EventArgs e)
        {

            lbrbaslik.Text = "Ürünler";
            makeing.Text = "İngilizce";
            maketurkish.Text = "Türkçe";
            btninsert.Text = "Ekle";
            uruncountbaslik.Text = "Toplam Ürün:";
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            lbxUrunler.Items.Add(txburunset.Text);
        }
    }
}
