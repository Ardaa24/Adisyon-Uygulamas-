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

namespace coffeApp
{
    public partial class Form2: Form
    {

        //@ARDA24

        //Para 
        public int money = 1000;
        public int lastPaidAmount = 0;
       

        public void UpdateMoneyLabel()
        {
            moneyLabel.Text = money.ToString() + "TL";
        }

        // Fiyat Listesi & Ürün Listesi

        int cheese = 150;
        int cupcake = 200;
        int hamburger = 250;
        int pizza = 250;
        int hotdog = 100;
        int pancake = 100;
        int kahve = 50;
        int patates = 125;
        int tavuksis = 200;
        int eriste = 150;
        int balik = 250;
        int biftek = 550;
        int izgara = 200;
        int mesrubat = 60;
        
        /// ///////////////
       


        // KASA

        int totalPrice = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString() + "TL";
        }

        private void cheesePicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += cheese;
            cardListbox.Items.Add("Peynirli Pizza");
        }

        private void cupcakePicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += cupcake;
            cardListbox.Items.Add("Cupcake");
        }

        private void hotdogPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += hotdog;
            cardListbox.Items.Add("Sosisli");
        }

        private void pancakePicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += pancake;
            cardListbox.Items.Add("Pankek");
        }

        private void hamburgerPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += hamburger;
            cardListbox.Items.Add("Hamburger");
        }

        private void pizzaPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += pizza;
            cardListbox.Items.Add("Karışık Pizza");
        }

        private void kahvePicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += kahve;
            cardListbox.Items.Add("Kahve");
        }

        private void patatesPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += patates;
            cardListbox.Items.Add("Elma Patates");
        }

        private void tavuksisPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += tavuksis;
            cardListbox.Items.Add("Tavuk Şiş");
        }

        private void eristePicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += eriste;
            cardListbox.Items.Add("Erişte");
        }

        private void balikPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += balik;
            cardListbox.Items.Add("Sardalya");
        }

        private void biftekPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += biftek;
            cardListbox.Items.Add("Biftek");
        }

        private void izgaraPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += izgara;
            cardListbox.Items.Add("Izgara Tavuk");
        }
        private void mesrubatPicturebox_Click(object sender, EventArgs e)
        {
            totalPrice += mesrubat;
            cardListbox.Items.Add("Mesrubat");
        }


        /// 24

        private void payButton_Click(object sender, EventArgs e)
        {
            if (totalPrice <= money)
            {
                money -= totalPrice;
                lastPaidAmount = totalPrice; 
                UpdateMoneyLabel();
                cardListbox.Items.Clear();
                totalPrice = 0;

                MessageBox.Show("Ödeme Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cardListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cardListbox.SelectedItem != null)
            {
                string selectedItem = cardListbox.SelectedItem.ToString();

                // Ürünün fiyatını toplamdan çıkar
                if (selectedItem == "Peynirli Pizza")
                    totalPrice -= cheese;
                else if (selectedItem == "Cupcake")
                    totalPrice -= cupcake;
                else if (selectedItem == "Sosisli")
                    totalPrice -= hotdog;
                else if (selectedItem == "Pankek")
                    totalPrice -= pancake;
                else if (selectedItem == "Hamburger")
                    totalPrice -= hamburger;
                else if (selectedItem == "Karışık Pizza")
                    totalPrice -= pizza;
                else if (selectedItem == "Kahve")
                    totalPrice -= kahve;
                else if (selectedItem == "Elma Patates")
                    totalPrice -= patates;
                else if (selectedItem == "Tavuk Şiş")
                    totalPrice -= tavuksis;
                else if (selectedItem == "Erişte")
                    totalPrice -= eriste;
                else if (selectedItem == "Sardalya")
                    totalPrice -= balik;
                else if (selectedItem == "Biftek")
                    totalPrice -= biftek;
                else if (selectedItem == "Izgara Tavuk")
                    totalPrice -= izgara;
                else if (selectedItem == "Mesrubat")
                    totalPrice -= mesrubat;

                // Toplam fiyatı güncelle

                // Öğeyi listeden sil
                cardListbox.Items.Remove(selectedItem);
            }
        }



       //kapat buttonu
       
        private void offButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newCheck_Click(object sender, EventArgs e)
        {

            // temizle
            cardListbox.Items.Clear();

            // Toplam fiyatı sıfırla
            totalPrice = 0;

            // Bakiyeyi yeniden 1000 
            money = 1000;
            moneyLabel.Text = money.ToString() + "TL";

            // Adisyon mesajı
            MessageBox.Show("Yeni siparişe başlandı. Liste Temizlendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bakiye Ekleme Butonu
        public void moneyAddButton_Click(object sender, EventArgs e)
        {
            bakiyePanel panel = new bakiyePanel(this); 
            panel.Show();
        }


        /// Son Adisyon
        private void sonAdisyonButton_Click(object sender, EventArgs e)
        {
            if (lastPaidAmount > 0)
            {
                MessageBox.Show("Son ödeme tutarı: " + lastPaidAmount.ToString() + " TL", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Henüz bir ödeme yapılmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }

}
