using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string groupBoxKelas = "";
            string groupBoxJadwal = "";

            if (biola.Checked == true)
            {
                groupBoxKelas += "Biola, ";
            }
            if (gitar.Checked == true)
            {
                groupBoxKelas += "Gitar,";
            }
            if (piano.Checked == true)
            {
                groupBoxKelas += "Piano,";
            }
            if (drum.Checked == true)
            {
                groupBoxKelas += "Drum,";
            }
            if (vocal.Checked == true)
            {
                groupBoxKelas += "Vokal,";
            }
            if (kompo.Checked == true)
            {
                groupBoxKelas += "Komposer,";
            }
            if (kondu.Checked == true)
            {
                groupBoxKelas += "Konduktor,";
            }
            if (phone.Checked == true)
            {
                groupBoxKelas += "Saxophone,";
            }


            if (senin.Checked)
            {
                groupBoxJadwal += "Senin & Rabu, 14.00-16.00";
            }
            else if (selasa.Checked)
            {
                groupBoxJadwal += "Selasa & Kamis, 14.00-16.00";
            }
            else if (sabtu.Checked)
            {
                groupBoxJadwal += "Sabtu & Minggu, 09.00-11.00 ";
            }

            else if (minggu.Checked)
            {
                groupBoxJadwal += "Minggu, 13.00-17.00";
            }


            if (groupBoxKelas != "" && groupBoxJadwal != "")
            {
                string pesan = "Nama: " + textBoxNama.Text + "\n" +
                           "Jenis Kelamin: " + comboBoxKelamin.Text + "\n" +
                           "Tanggal Lahir: " + dateTimePickerTanggal.Text + "\n" +
                           "Pilihan Kelas: " + groupBoxKelas + "\n" +
                           "Pilihan Jadwal; " + groupBoxJadwal;
                MessageBox.Show(pesan, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxNama.Text == "")
            {
                MessageBox.Show("Masukkan Nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBoxKelamin.Text == "")
            {
                MessageBox.Show("Masukkan Kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (groupBoxKelas == "")
            {
                MessageBox.Show("Masukkan Kelas anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (groupBoxJadwal == "")
            {
                MessageBox.Show("Masukkan Jadwal anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTanggal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
