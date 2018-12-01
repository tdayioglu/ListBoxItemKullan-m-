using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxItemKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolEkle_Click(object sender, EventArgs e)
        {
            if (txtSol.TextLength == 0)
            {
                if (MessageBox.Show("ListBox a boş karakter eklensin mi?", "Onay Penceresi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstSol.Items.Add("");
                }
                else
                {
                    return;
                }
            }
            else
            {
                lstSol.Items.Add(txtSol.Text);
            }
        }

        private void btnSagEkle_Click(object sender, EventArgs e)
        {
            if (txtSag.TextLength == 0)
            {
                if (MessageBox.Show("ListBox a boş karakter eklensin mi?", "Onay Penceresi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstSag.Items.Add("");
                }
                else
                {
                    return;
                }
            }
            else
            {
                lstSag.Items.Add(txtSag.Text);
            }
        }

        private void btnSecileniSilSol_Click(object sender, EventArgs e)
        {
            if (lstSol.SelectedIndex < 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!");
                if (lstSol.Items.Count > 0)
                {
                    lstSol.SelectedIndex = 0;
                }
                return;
            }
            lstSol.Items.RemoveAt(lstSol.SelectedIndex);
        }

        private void btnSecileniSilSag_Click(object sender, EventArgs e)
        {
            if (lstSag.SelectedIndex < 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!");
                if (lstSag.Items.Count > 0)
                {
                    lstSag.SelectedIndex = 0;
                }
                return;
            }
            lstSag.Items.RemoveAt(lstSag.SelectedIndex);
        }

        private void btnSecileniSagaTasi_Click(object sender, EventArgs e)
        {
            if (lstSol.SelectedIndex < 0)
            {
                MessageBox.Show("Taşınacak Satırı Seçiniz!");
                if (lstSol.Items.Count > 0)
                {
                    lstSol.SelectedIndex = 0;
                }
                return;
            }

            lstSag.Items.Add(lstSol.SelectedItem);
            lstSol.Items.RemoveAt(lstSol.SelectedIndex);
        }

        private void btnSecileniSolaTasi_Click(object sender, EventArgs e)
        {
            if (lstSag.SelectedIndex < 0)
            {
                MessageBox.Show("Taşınacak Satırı Seçiniz!");
                if (lstSag.Items.Count > 0)
                {
                    lstSag.SelectedIndex = 0;
                }
                return;
            }

            lstSol.Items.Add(lstSag.SelectedItem);
            lstSag.Items.RemoveAt(lstSag.SelectedIndex);
        }

        private void btnHepsiniSagaTasi_Click(object sender, EventArgs e)
        {

            if (lstSol.Items.Count == 0)
            {
                MessageBox.Show("Taşınabilecek bir değer girmelisiniz!");
                txtSol.Focus();
                return;
            }

            for (; lstSol.Items.Count > 0;)
            {
                lstSag.Items.Add(lstSol.Items[0]);
                lstSol.Items.RemoveAt(0);
            }
        }

        private void btnHepsiniSolaTasi_Click(object sender, EventArgs e)
        {
            if (lstSag.Items.Count == 0)
            {
                MessageBox.Show("Taşınabilecek bir değer girmelisiniz!");
                txtSag.Focus();
                return;
            }

            for (; lstSag.Items.Count > 0;)
            {
                lstSol.Items.Add(lstSag.Items[0]);
                lstSag.Items.RemoveAt(0);
            }
        }


    }
}
