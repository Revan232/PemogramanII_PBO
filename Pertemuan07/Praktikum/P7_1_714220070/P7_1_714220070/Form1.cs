using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220070
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.Size = new Size(404, 263);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            string errorMassage = "";

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                errorMassage += "Nama Belum Diisi\n";
            }

            if (string.IsNullOrWhiteSpace(txtProdi.Text))
            {
                errorMassage += "Prodi Belum Diisi\n";
            }

            else if (!Regex.IsMatch(txtProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMassage += "Prodi Harus Berformat [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorMassage += "Kelas Belum Diisi\n";
            }

            if (string.IsNullOrEmpty(errorMassage)) 
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK,MessageBoxIcon.Information
                    );
                    this.Size = new Size(404, 555); 
            }
            else
            {
                MessageBox.Show(
                    errorMassage,
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSenin.Checked) 
            {
                ckKuliah.Enabled = true; ckKuliah.Checked = true;
                ckTraveling.Enabled = false; ckTraveling.Checked = false;
                ckTidur.Enabled = true; ckTidur.Checked = false;
            }
        }

        private void rdMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMinggu.Checked)
            {
                ckKuliah.Enabled = false;
                ckTraveling.Enabled = true;
                ckTidur.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            /*this.Size = new Size(404, 263);
            txtNama.Text = null;
            txtKelas.Text = null;
            txtProdi.Text = null;*/

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                
                    ((TextBox) control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton) control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                /*else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;*/
            }
            this.Size = new Size(404, 263);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtNama.Text != "" && txtProdi.Text != "")
            {
                string pesan = "Nama: " + txtNama.Text + "\n" +
                           "Prodi:" + txtProdi.Text + "\n" +
                           "Kelas:" + txtKelas.Text + "\n" +
                           "List Kegiatan";
                           
                MessageBox.Show(pesan,"Form Kegiatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
