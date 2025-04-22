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

       

        public void UpdateMoneyLabel()
        {
            moneyLabel.Text = money.ToString() + "TL";
        }

        // Fiyat Listesi
        int cheese = 150;
        int cupcake = 200;
        int hamburger = 250;
        int pizza = 250;
        int hotdog = 100;
        int pancake = 100;



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

        private void payButton_Click(object sender, EventArgs e)
        {
            if (totalPrice <= money)
            {
                // işlem
                money = money - totalPrice;

                // yazdır
                moneyLabel.Text = money.ToString() + "TL";

                // sepeti temizle
                cardListbox.Items.Clear();
                totalPrice = 0;

                // bilgi
                MessageBox.Show("Ödeme Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // bilgi
                MessageBox.Show("Yetersiz Bakiye", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

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

                // Öğeyi listeden sil
                cardListbox.Items.Remove(selectedItem);
            }
        }




        private void offButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newCheck_Click(object sender, EventArgs e)
        {

            // Öğeleri temizle
            cardListbox.Items.Clear();

            // Toplam fiyatı sıfırla
            totalPrice = 0;

            // Bakiyeyi yeniden 1000 yap
            money = 1000;
            moneyLabel.Text = money.ToString() + "TL";

            // (İsteğe bağlı bilgi mesajı)
            MessageBox.Show("Yeni siparişe başlandı. Liste Temizlendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void moneyAddButton_Click(object sender, EventArgs e)
        {
            bakiyePanel panel = new bakiyePanel(this); 
            panel.Show();
        }
    }

}
