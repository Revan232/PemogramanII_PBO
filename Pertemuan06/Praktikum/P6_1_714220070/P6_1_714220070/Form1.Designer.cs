namespace P6_1_714220070
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
            this.vbbutton = new System.Windows.Forms.Button();
            this.csbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which do you better, Visual Basic or C#?";
            // 
            // vbbutton
            // 
            this.vbbutton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbbutton.ForeColor = System.Drawing.Color.Green;
            this.vbbutton.Location = new System.Drawing.Point(213, 162);
            this.vbbutton.Name = "vbbutton";
            this.vbbutton.Size = new System.Drawing.Size(117, 24);
            this.vbbutton.TabIndex = 1;
            this.vbbutton.Text = "Visual Basic";
            this.vbbutton.UseVisualStyleBackColor = true;
            this.vbbutton.Click += new System.EventHandler(this.vbbutton_Click);
            this.vbbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbbutton_MouseMove);
            // 
            // csbutton
            // 
            this.csbutton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csbutton.ForeColor = System.Drawing.Color.Red;
            this.csbutton.Location = new System.Drawing.Point(463, 162);
            this.csbutton.Name = "csbutton";
            this.csbutton.Size = new System.Drawing.Size(117, 24);
            this.csbutton.TabIndex = 2;
            this.csbutton.Text = "C#";
            this.csbutton.UseVisualStyleBackColor = true;
            this.csbutton.Click += new System.EventHandler(this.csbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closebutton.Location = new System.Drawing.Point(39, 414);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(117, 24);
            this.closebutton.TabIndex = 3;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.csbutton);
            this.Controls.Add(this.vbbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vbbutton;
        private System.Windows.Forms.Button csbutton;
        private System.Windows.Forms.Button closebutton;
    }
}

