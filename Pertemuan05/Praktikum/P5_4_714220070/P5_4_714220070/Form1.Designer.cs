namespace P5_4_714220070
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxKelamin = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.groupBoxKelas = new System.Windows.Forms.GroupBox();
            this.groupBoxJadwal = new System.Windows.Forms.GroupBox();
            this.senin = new System.Windows.Forms.RadioButton();
            this.selasa = new System.Windows.Forms.RadioButton();
            this.sabtu = new System.Windows.Forms.RadioButton();
            this.minggu = new System.Windows.Forms.RadioButton();
            this.biola = new System.Windows.Forms.CheckBox();
            this.gitar = new System.Windows.Forms.CheckBox();
            this.phone = new System.Windows.Forms.CheckBox();
            this.kondu = new System.Windows.Forms.CheckBox();
            this.piano = new System.Windows.Forms.CheckBox();
            this.drum = new System.Windows.Forms.CheckBox();
            this.vocal = new System.Windows.Forms.CheckBox();
            this.kompo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxKelas.SuspendLayout();
            this.groupBoxJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(408, 106);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(265, 31);
            this.textBoxNama.TabIndex = 4;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // comboBoxKelamin
            // 
            this.comboBoxKelamin.FormattingEnabled = true;
            this.comboBoxKelamin.Items.AddRange(new object[] {
            "PRIA",
            "WANITA"});
            this.comboBoxKelamin.Location = new System.Drawing.Point(408, 179);
            this.comboBoxKelamin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKelamin.Name = "comboBoxKelamin";
            this.comboBoxKelamin.Size = new System.Drawing.Size(265, 34);
            this.comboBoxKelamin.TabIndex = 5;
            this.comboBoxKelamin.SelectedIndexChanged += new System.EventHandler(this.comboBoxKelamin_SelectedIndexChanged);
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(408, 244);
            this.dateTimePickerTanggal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(265, 31);
            this.dateTimePickerTanggal.TabIndex = 6;
            this.dateTimePickerTanggal.ValueChanged += new System.EventHandler(this.dateTimePickerTanggal_ValueChanged);
            // 
            // groupBoxKelas
            // 
            this.groupBoxKelas.Controls.Add(this.kompo);
            this.groupBoxKelas.Controls.Add(this.vocal);
            this.groupBoxKelas.Controls.Add(this.drum);
            this.groupBoxKelas.Controls.Add(this.piano);
            this.groupBoxKelas.Controls.Add(this.kondu);
            this.groupBoxKelas.Controls.Add(this.phone);
            this.groupBoxKelas.Controls.Add(this.gitar);
            this.groupBoxKelas.Controls.Add(this.biola);
            this.groupBoxKelas.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKelas.Location = new System.Drawing.Point(85, 301);
            this.groupBoxKelas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKelas.Name = "groupBoxKelas";
            this.groupBoxKelas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKelas.Size = new System.Drawing.Size(341, 194);
            this.groupBoxKelas.TabIndex = 7;
            this.groupBoxKelas.TabStop = false;
            this.groupBoxKelas.Text = "Pilihan Kelas";
            // 
            // groupBoxJadwal
            // 
            this.groupBoxJadwal.Controls.Add(this.minggu);
            this.groupBoxJadwal.Controls.Add(this.sabtu);
            this.groupBoxJadwal.Controls.Add(this.selasa);
            this.groupBoxJadwal.Controls.Add(this.senin);
            this.groupBoxJadwal.Location = new System.Drawing.Point(475, 301);
            this.groupBoxJadwal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxJadwal.Name = "groupBoxJadwal";
            this.groupBoxJadwal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxJadwal.Size = new System.Drawing.Size(354, 194);
            this.groupBoxJadwal.TabIndex = 8;
            this.groupBoxJadwal.TabStop = false;
            this.groupBoxJadwal.Text = "Pilihan Jadwal";
            // 
            // senin
            // 
            this.senin.AutoSize = true;
            this.senin.Location = new System.Drawing.Point(23, 42);
            this.senin.Name = "senin";
            this.senin.Size = new System.Drawing.Size(292, 30);
            this.senin.TabIndex = 0;
            this.senin.TabStop = true;
            this.senin.Text = "Senin && Rabu, 14:00-16:00";
            this.senin.UseVisualStyleBackColor = true;
            // 
            // selasa
            // 
            this.selasa.AutoSize = true;
            this.selasa.Location = new System.Drawing.Point(23, 78);
            this.selasa.Name = "selasa";
            this.selasa.Size = new System.Drawing.Size(307, 30);
            this.selasa.TabIndex = 1;
            this.selasa.TabStop = true;
            this.selasa.Text = "Selasa && Kamis, 14:00-16:00";
            this.selasa.UseVisualStyleBackColor = true;
            this.selasa.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sabtu
            // 
            this.sabtu.AutoSize = true;
            this.sabtu.Location = new System.Drawing.Point(23, 114);
            this.sabtu.Name = "sabtu";
            this.sabtu.Size = new System.Drawing.Size(311, 30);
            this.sabtu.TabIndex = 2;
            this.sabtu.TabStop = true;
            this.sabtu.Text = "Sabtu && Minggu, 09:00-11:00";
            this.sabtu.UseVisualStyleBackColor = true;
            // 
            // minggu
            // 
            this.minggu.AutoSize = true;
            this.minggu.Location = new System.Drawing.Point(23, 151);
            this.minggu.Name = "minggu";
            this.minggu.Size = new System.Drawing.Size(244, 30);
            this.minggu.TabIndex = 3;
            this.minggu.TabStop = true;
            this.minggu.Text = "Minggu, 13:00 - 17:00";
            this.minggu.UseVisualStyleBackColor = true;
            // 
            // biola
            // 
            this.biola.AutoSize = true;
            this.biola.Location = new System.Drawing.Point(22, 43);
            this.biola.Name = "biola";
            this.biola.Size = new System.Drawing.Size(84, 30);
            this.biola.TabIndex = 4;
            this.biola.Text = "Biola";
            this.biola.UseVisualStyleBackColor = true;
            // 
            // gitar
            // 
            this.gitar.AutoSize = true;
            this.gitar.Location = new System.Drawing.Point(22, 79);
            this.gitar.Name = "gitar";
            this.gitar.Size = new System.Drawing.Size(85, 30);
            this.gitar.TabIndex = 5;
            this.gitar.Text = "Gitar";
            this.gitar.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(22, 115);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(140, 30);
            this.phone.TabIndex = 6;
            this.phone.Text = "Saxophone";
            this.phone.UseVisualStyleBackColor = true;
            // 
            // kondu
            // 
            this.kondu.AutoSize = true;
            this.kondu.Location = new System.Drawing.Point(22, 151);
            this.kondu.Name = "kondu";
            this.kondu.Size = new System.Drawing.Size(136, 30);
            this.kondu.TabIndex = 7;
            this.kondu.Text = "Konduktor";
            this.kondu.UseVisualStyleBackColor = true;
            this.kondu.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // piano
            // 
            this.piano.AutoSize = true;
            this.piano.Location = new System.Drawing.Point(167, 43);
            this.piano.Name = "piano";
            this.piano.Size = new System.Drawing.Size(90, 30);
            this.piano.TabIndex = 8;
            this.piano.Text = "Piano";
            this.piano.UseVisualStyleBackColor = true;
            // 
            // drum
            // 
            this.drum.AutoSize = true;
            this.drum.Location = new System.Drawing.Point(167, 79);
            this.drum.Name = "drum";
            this.drum.Size = new System.Drawing.Size(89, 30);
            this.drum.TabIndex = 9;
            this.drum.Text = "Drum";
            this.drum.UseVisualStyleBackColor = true;
            // 
            // vocal
            // 
            this.vocal.AutoSize = true;
            this.vocal.Location = new System.Drawing.Point(167, 115);
            this.vocal.Name = "vocal";
            this.vocal.Size = new System.Drawing.Size(87, 30);
            this.vocal.TabIndex = 10;
            this.vocal.Text = "Vocal";
            this.vocal.UseVisualStyleBackColor = true;
            // 
            // kompo
            // 
            this.kompo.AutoSize = true;
            this.kompo.Location = new System.Drawing.Point(167, 151);
            this.kompo.Name = "kompo";
            this.kompo.Size = new System.Drawing.Size(131, 30);
            this.kompo.TabIndex = 11;
            this.kompo.Text = "Komposer";
            this.kompo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tampilan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(882, 693);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxJadwal);
            this.Controls.Add(this.groupBoxKelas);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.comboBoxKelamin);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxKelas.ResumeLayout(false);
            this.groupBoxKelas.PerformLayout();
            this.groupBoxJadwal.ResumeLayout(false);
            this.groupBoxJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxKelamin;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.GroupBox groupBoxKelas;
        private System.Windows.Forms.GroupBox groupBoxJadwal;
        private System.Windows.Forms.CheckBox kompo;
        private System.Windows.Forms.CheckBox vocal;
        private System.Windows.Forms.CheckBox drum;
        private System.Windows.Forms.CheckBox piano;
        private System.Windows.Forms.CheckBox kondu;
        private System.Windows.Forms.CheckBox phone;
        private System.Windows.Forms.CheckBox gitar;
        private System.Windows.Forms.CheckBox biola;
        private System.Windows.Forms.RadioButton minggu;
        private System.Windows.Forms.RadioButton sabtu;
        private System.Windows.Forms.RadioButton selasa;
        private System.Windows.Forms.RadioButton senin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

