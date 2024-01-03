using P10_714220070.controller;
using P10_714220070.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P10_714220070.view
{
    public partial class FormBarang : Form
    {
    
            Koneksi koneksi = new Koneksi();
            M_barang m_brg = new M_barang();
        string id_brg;
        public FormBarang()
        {
            InitializeComponent();
        }
        public void Tampil()
        {
            //Query DB Get MGS
            Databarang.DataSource = koneksi.ShowData("Select * From t_barang");
            Databarang.Columns[0].HeaderText = "ID";
            Databarang.Columns[1].HeaderText = "Nama_Barang";
            Databarang.Columns[2].HeaderText = "Haga";
        }
        public void ResetForm()
        {
            tbnama_barang.Text = "";
            tbharga.Text = "";
            tbCariData.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbnama_barang.Text == "" || tbharga.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang brg = new Barang();
                m_brg.Nama_barang = tbnama_barang.Text;
                m_brg.Harga = tbharga.Text;

                brg.Insert(m_brg);

                ResetForm();
                Tampil();
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbnama_barang.Text) || (tbnama_barang.Text).All(Char.IsNumber) || string.IsNullOrEmpty(tbharga.Text) || (tbharga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                m_brg.Nama_barang = tbnama_barang.Text;
                m_brg.Harga = tbharga.Text;
                barang.Update(m_brg, id_brg);

                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
             "Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_brg);
                ResetForm();
                Tampil();
            }

        }

        private void Databarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_brg = Databarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbnama_barang.Text = Databarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbharga.Text = Databarang.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            Databarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void Databarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Databarang.Columns[e.ColumnIndex].Name == "harga")
            {

                if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                {

                    e.Value = string.Format("Rp. {0:N0}", cellValue);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
