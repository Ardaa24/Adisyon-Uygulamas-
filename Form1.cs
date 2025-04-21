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
    public partial class LoadScreen: Form
    {

        int i = 0;
        public LoadScreen()
        {
            InitializeComponent();
        }

     

     

        private void LoadScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != 100)
            {
                i++;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
        }

    }

}
