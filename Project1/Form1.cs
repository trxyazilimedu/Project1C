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

            String[] Urunlist = new string[] {"Araba","Telefon","Saat","Kulaklık","Flash Bellek"};
 

            lbrbaslik.Text = "Ürünler";
            btninsert.Text = "Ekle";
            lblsptbaslik.Text = "Sepet";
            btnsptinsert.Text = "Sepete Ekle";
            btnremovecart.Text = "Sepetten Kaldır";
            txburunset.PlaceholderText = "Ürün ismi";

            btnremovecart.Enabled = false;
            //lbxUrunler.Items.
            btnsptinsert.Enabled = false;




            foreach (String uruns in Urunlist){
                lbxUrunler.Items.Add(uruns);
            }
            lbrcount.Text = lbxUrunler.Items.Count.ToString();


            

        }


        private void makeing_Click(object sender, EventArgs e)
        {

            lbrbaslik.Text = "Products";
            makeing.Text = "English";
            btnremovecart.Text = "Remove To Cart";
            maketurkish.Text = "Turkish";
            lblsptbaslik.Text = "Cart";
            uruncountbaslik.Text = "Total Product:";
            btnsptinsert.Text = "Add to Cart";
            btninsert.Text = "Insert";
            txburunset.PlaceholderText = "Product name";
        }

        private void maketurkish_Click(object sender, EventArgs e)
        {

            lbrbaslik.Text = "Ürünler";
            makeing.Text = "İngilizce";
            maketurkish.Text = "Türkçe";
            btninsert.Text = "Ekle";
            lblsptbaslik.Text = "Sepet";
            btnsptinsert.Text = "Sepete Ekle";
            txburunset.PlaceholderText = "Ürün ismi";
            uruncountbaslik.Text = "Toplam Ürün:";
            btnremovecart.Text = "Sepetten Kaldır";
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            if (txburunset.Text.Length > 1) 
            {
                lbxUrunler.Items.Add(txburunset.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli İsim Girin");
            }
       
            
            lbrcount.Text = lbxUrunler.Items.Count.ToString();
        }

        private void btnsptinsert_Click(object sender, EventArgs e)
        {
            if (lbxUrunler.SelectedItem !=null)
            {
                lbxsepet.Items.Add(lbxUrunler.SelectedItem);
                lbxUrunler.Items.Remove(lbxUrunler.SelectedItem);
                lbrcount.Text = lbxUrunler.Items.Count.ToString();
                btnremovecart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Seçiniz");
            }
            if (lbxUrunler.Items.Count < 1)
            {
                btnsptinsert.Enabled = false;
            }
           
        }

        private void btnremovecart_Click(object sender, EventArgs e)
        {
            if(lbxsepet.SelectedItem != null)
            {
                lbxUrunler.Items.Add(lbxsepet.SelectedItem);
                lbxsepet.Items.Remove(lbxsepet.SelectedItem);
                lbrcount.Text = lbxUrunler.Items.Count.ToString();
                if (lbxsepet.Items.Count < 1)
                {
                    btnremovecart.Enabled = false;
                }

                btnsptinsert.Enabled = true;

            }
            else
            {

                MessageBox.Show("Lütfen Ürün Seçiniz");
            }
     
        }

        private void lbxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxUrunler.SelectedItem != null)
            {
                btnsptinsert.Enabled = true;
            }

        }
    }
}
