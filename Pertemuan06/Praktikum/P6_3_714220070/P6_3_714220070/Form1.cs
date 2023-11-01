using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Teksbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {

                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul");
                }
                else
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Imputan hanya boleh huruf !");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtHuruf, "Teksbox Angka tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul");
                }
                else
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Imputan hanya boleh Angka !");
                    epCorrect.SetError(txtAngka, "");
                }
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtHuruf, "Teksbox Email tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {


                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "Format Email salah!\nContoh : a@b.c");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {

            if (txtAngka2.Text == "" && txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Teksbox Angka2 tidak boleh kosong!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");

                epWarning.SetError(txtAngka2, "Teksbox Angka2 tidak boleh kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");
                }
                else
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Imputan hanya boleh Angka !");
                    epCorrect.SetError(txtAngka1, "");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            txtAngka2_TextChanged(sender, e);
            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Teksbox Angka2 tidak boleh kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka2.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul");
                }
                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Imputan hanya boleh Angka !");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int Angka1) && int.TryParse(txtAngka2.Text, out int Angka2))
            {
            
                if (Angka1 > Angka2)
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Angka1 Lebih Besar dari Angka2");
                }
                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Angka1 tidak Lebih Besar dari Angka2");
                    epCorrect.SetError(txtAngka2, "");
                }

            }
            
        }
    }
}
