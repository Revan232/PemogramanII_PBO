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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P6_4_714220070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                epWarning.SetError(textBox1, "Teksbox no telepon tidak boleh kosong!");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");
            }
            else
            {
                if ((textBox4.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(textBox4, "");
                    epWrong.SetError(textBox4, "");
                    epCorrect.SetError(textBox4, "Betul");
                }
                else
                {
                    epWarning.SetError(textBox4, "");
                    epWrong.SetError(textBox4, "Imputan hanya boleh Angka !");
                    epCorrect.SetError(textBox4, "");
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Teksbox Huruf tidak boleh kosong!");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError( textBox1, "");
            }
            else
            {

                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Betul");
                }
                else
                {
                    epWarning.SetError(textBox1 , "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Imputan hanya boleh huruf !");
                }
                
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                epWarning.SetError(textBox2, "Teksbox Email tidak boleh kosong!");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");
            }
            else
            {


                if (Regex.IsMatch(textBox2.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                    epCorrect.SetError(textBox2, "Betul!");
                }
                else
                {
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "Format Email salah!\nContoh : a@b.c");
                    epCorrect.SetError(textBox2, "");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {

                epWarning.SetError(textBox3, "Nama tidak boleh kosong !");
                epWrong.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "");
            }
            else
            {
                if ((textBox3.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(textBox3, "");
                    epWrong.SetError(textBox3, "");
                    epCorrect.SetError(textBox3, "Betul");

                }
                else if ((textBox3.Text).Any(char.IsLower))
                {
                    epWarning.SetError(textBox3, "");
                    epWrong.SetError(textBox3, "Harus menggunakan huruf besar");
                    epCorrect.SetError(textBox3, "");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string groupBox1 = "";
            string groupBox2 = "";

            if (jas.Checked == true)
            {
                groupBox1 += "Jas,";
            }
            if (kebaya.Checked == true)
            {
                groupBox1 += "kebaya,";
            }
            if (s.Checked)
            {
                groupBox2 += "Ukuran Baju anda S";
            }
            else if (m.Checked)
            {
                groupBox2 += "Ukuran Baju anda M";
            }
            else if (l.Checked)
            {
                groupBox2 += "Ukuran Baju anda L";
            }
            else if (xl.Checked)
            {
                groupBox2 += "Ukuran Baju anda XL";
            }

            if (groupBox1 != "" && groupBox2 != "")
            {
                string pesan = "Nama: " + textBox1.Text + "\n" +
                           "Nomer Telepon:" + textBox4.Text + "\n" +
                           "Email anda:" + textBox2.Text + "\n" +
                           "Jenis Kelamin: " + comboBox1.Text + "\n" +
                           "Alamat:" + textBox3.Text + "\n" +
                           "Tanggal Pemesanan: " + dateTimePicker1.Text + "\n" +
                           "Pilihan Penyewaan: " + groupBox1 + "\n" +
                           "Pilihan Ukuran: " + groupBox2 ;
                           ;
                MessageBox.Show(pesan, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Masukkan Nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Masukkan Kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (groupBox1 == "")
            {
                MessageBox.Show("Masukkan Kelas anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (groupBox2 == "")
            {
                MessageBox.Show("Masukkan Jadwal anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
