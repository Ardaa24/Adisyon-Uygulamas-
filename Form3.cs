using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeApp
{
    public partial class bakiyePanel : Form
    {
        private Form2 form2Ref;

        public bakiyePanel(Form2 form2)
        {
            InitializeComponent();
            form2Ref = form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Kapat butonu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // miktar al
            if (!int.TryParse(textBox1.Text, out int miktar))
            {
                MessageBox.Show("Geçerli bir miktar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // tip kontrol
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ödeme tipi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Miktar aralığı kontrol
            if (miktar < 200 || miktar > 2000)
            {
                MessageBox.Show("Miktar 200 TL ile 2000 TL arasında olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bakiye ekleme işlemi
            form2Ref.money += miktar;
            form2Ref.UpdateMoneyLabel();

            MessageBox.Show("Ödeme başarılı. " + miktar + " TL yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
