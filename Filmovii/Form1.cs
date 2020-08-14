using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int x = r.Next(0, 5);

            List<string> film = new List<string>();

            for(int i = 0; i < 3; i++)
            {
                film.Add(lstOne.Items[i].ToString());
                film.Add(lstTwo.Items[i].ToString());
            }

            txtPrikaz.Text = film[x];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnUnesiOne_Click(object sender, EventArgs e)
        {
            if (txtOne.Text == "")
            {
                MessageBox.Show("Unesi ime filma!");
            }
            else if (lstOne.Items.Count >= 3) {
                MessageBox.Show("Limit dosegnut! Uklonite jedan film za ponovan unos!");
            }
            else if (lstOne.Items.Contains(txtOne.Text))
            {
                MessageBox.Show("Film je već unešen!");
                txtOne.Text = "";
            }
            else
            {
                lstOne.Items.Add(txtOne.Text);
                txtOne.Text = "";
            }
        }

        private void btnUnesiTwo_Click(object sender, EventArgs e)
        {
            if (txtTwo.Text == "")
            {
                MessageBox.Show("Unesi ime filma!");
            }
            else if (lstTwo.Items.Count >= 3)
            {
                MessageBox.Show("Limit dosegnut! Uklonite jedan film za ponovan unos!");
            }
            else if (lstOne.Items.Contains(txtOne.Text))
            {
                MessageBox.Show("Film je već unešen!");
                txtTwo.Text = "";
            }
            else
            {
                lstTwo.Items.Add(txtTwo.Text);
                txtTwo.Text = "";
            }
        }

        private void btnBrisiOne_Click(object sender, EventArgs e)
        {
            if (lstOne.SelectedItem == null)
            {
                MessageBox.Show("Odaberi film za ukloniti!");
            }
            else
            {
                lstOne.Items.RemoveAt(lstOne.SelectedIndex);
            }
        }

        private void btnBrisiTwo_Click(object sender, EventArgs e)
        {
            if (lstTwo.SelectedItem == null)
            {
                MessageBox.Show("Odaberi film za ukloniti!");
            }
            else
            {
                lstTwo.Items.RemoveAt(lstTwo.SelectedIndex);
            }
        }
    }
}
