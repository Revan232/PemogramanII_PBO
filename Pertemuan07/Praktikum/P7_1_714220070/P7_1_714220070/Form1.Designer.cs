namespace P7_1_714220070
{
    partial class Form
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdSenin = new System.Windows.Forms.RadioButton();
            this.rdMinggu = new System.Windows.Forms.RadioButton();
            this.ckKuliah = new System.Windows.Forms.CheckBox();
            this.ckTraveling = new System.Windows.Forms.CheckBox();
            this.ckTidur = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(121, 25);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(186, 20);
            this.txtNama.TabIndex = 3;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(121, 76);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(186, 20);
            this.txtProdi.TabIndex = 4;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(121, 131);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(186, 20);
            this.txtKelas.TabIndex = 5;
            // 
            // btnCek
            // 
            this.btnCek.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCek.Location = new System.Drawing.Point(121, 183);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(75, 30);
            this.btnCek.TabIndex = 6;
            this.btnCek.Text = "Cek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(211, 183);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(96, 30);
            this.btnTutup.TabIndex = 7;
            this.btnTutup.Text = "Tutup Form";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "List Ke Kegiatan";
            // 
            // rdSenin
            // 
            this.rdSenin.AutoSize = true;
            this.rdSenin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSenin.Location = new System.Drawing.Point(56, 294);
            this.rdSenin.Name = "rdSenin";
            this.rdSenin.Size = new System.Drawing.Size(60, 22);
            this.rdSenin.TabIndex = 9;
            this.rdSenin.TabStop = true;
            this.rdSenin.Text = "Senin";
            this.rdSenin.UseVisualStyleBackColor = true;
            this.rdSenin.CheckedChanged += new System.EventHandler(this.rdSenin_CheckedChanged);
            // 
            // rdMinggu
            // 
            this.rdMinggu.AutoSize = true;
            this.rdMinggu.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMinggu.Location = new System.Drawing.Point(56, 322);
            this.rdMinggu.Name = "rdMinggu";
            this.rdMinggu.Size = new System.Drawing.Size(70, 22);
            this.rdMinggu.TabIndex = 10;
            this.rdMinggu.TabStop = true;
            this.rdMinggu.Text = "Minggu";
            this.rdMinggu.UseVisualStyleBackColor = true;
            this.rdMinggu.CheckedChanged += new System.EventHandler(this.rdMinggu_CheckedChanged);
            // 
            // ckKuliah
            // 
            this.ckKuliah.AutoSize = true;
            this.ckKuliah.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckKuliah.Location = new System.Drawing.Point(56, 370);
            this.ckKuliah.Name = "ckKuliah";
            this.ckKuliah.Size = new System.Drawing.Size(66, 22);
            this.ckKuliah.TabIndex = 11;
            this.ckKuliah.Text = "Kuliah";
            this.ckKuliah.UseVisualStyleBackColor = true;
            // 
            // ckTraveling
            // 
            this.ckTraveling.AutoSize = true;
            this.ckTraveling.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTraveling.Location = new System.Drawing.Point(56, 398);
            this.ckTraveling.Name = "ckTraveling";
            this.ckTraveling.Size = new System.Drawing.Size(84, 22);
            this.ckTraveling.TabIndex = 12;
            this.ckTraveling.Text = "Traveling";
            this.ckTraveling.UseVisualStyleBackColor = true;
            this.ckTraveling.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckTidur
            // 
            this.ckTidur.AutoSize = true;
            this.ckTidur.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTidur.Location = new System.Drawing.Point(56, 426);
            this.ckTidur.Name = "ckTidur";
            this.ckTidur.Size = new System.Drawing.Size(61, 22);
            this.ckTidur.TabIndex = 13;
            this.ckTidur.Text = "Tidur";
            this.ckTidur.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(121, 474);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(211, 474);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 516);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ckTidur);
            this.Controls.Add(this.ckTraveling);
            this.Controls.Add(this.ckKuliah);
            this.Controls.Add(this.rdMinggu);
            this.Controls.Add(this.rdSenin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Praktikum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdSenin;
        private System.Windows.Forms.RadioButton rdMinggu;
        private System.Windows.Forms.CheckBox ckKuliah;
        private System.Windows.Forms.CheckBox ckTraveling;
        private System.Windows.Forms.CheckBox ckTidur;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
    }
}

