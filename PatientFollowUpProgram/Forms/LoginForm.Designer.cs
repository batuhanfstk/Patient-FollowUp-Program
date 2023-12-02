namespace PatientFollowUpProgram
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.giristctextbox = new Guna.UI.WinForms.GunaTextBox();
            this.girissifretexbox = new Guna.UI.WinForms.GunaTextBox();
            this.girisbutton = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backtoregisterbutton = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA BASINÇ TAKİP OTOMASYONU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(135, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC KİMLİK NO : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(218, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE : ";
            // 
            // giristctextbox
            // 
            this.giristctextbox.AcceptsReturn = true;
            this.giristctextbox.BaseColor = System.Drawing.Color.White;
            this.giristctextbox.BorderColor = System.Drawing.Color.CadetBlue;
            this.giristctextbox.BorderSize = 3;
            this.giristctextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.giristctextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.giristctextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.giristctextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.giristctextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giristctextbox.Location = new System.Drawing.Point(300, 233);
            this.giristctextbox.Name = "giristctextbox";
            this.giristctextbox.PasswordChar = '\0';
            this.giristctextbox.SelectedText = "";
            this.giristctextbox.Size = new System.Drawing.Size(385, 35);
            this.giristctextbox.TabIndex = 3;
            this.giristctextbox.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // girissifretexbox
            // 
            this.girissifretexbox.BaseColor = System.Drawing.Color.White;
            this.girissifretexbox.BorderColor = System.Drawing.Color.CadetBlue;
            this.girissifretexbox.BorderSize = 3;
            this.girissifretexbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.girissifretexbox.FocusedBaseColor = System.Drawing.Color.White;
            this.girissifretexbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.girissifretexbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.girissifretexbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girissifretexbox.Location = new System.Drawing.Point(300, 294);
            this.girissifretexbox.Name = "girissifretexbox";
            this.girissifretexbox.PasswordChar = '\0';
            this.girissifretexbox.SelectedText = "";
            this.girissifretexbox.Size = new System.Drawing.Size(385, 35);
            this.girissifretexbox.TabIndex = 4;
            // 
            // girisbutton
            // 
            this.girisbutton.AnimationHoverSpeed = 0.07F;
            this.girisbutton.AnimationSpeed = 0.03F;
            this.girisbutton.BaseColor1 = System.Drawing.Color.CadetBlue;
            this.girisbutton.BaseColor2 = System.Drawing.SystemColors.Control;
            this.girisbutton.BorderColor = System.Drawing.Color.CadetBlue;
            this.girisbutton.BorderSize = 3;
            this.girisbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.girisbutton.FocusedColor = System.Drawing.Color.Empty;
            this.girisbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbutton.ForeColor = System.Drawing.Color.Black;
            this.girisbutton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.girisbutton.Image = null;
            this.girisbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.girisbutton.Location = new System.Drawing.Point(508, 366);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.girisbutton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.girisbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.girisbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.girisbutton.OnHoverImage = null;
            this.girisbutton.OnPressedColor = System.Drawing.Color.Black;
            this.girisbutton.Size = new System.Drawing.Size(177, 49);
            this.girisbutton.TabIndex = 5;
            this.girisbutton.Text = "GİRİŞ";
            this.girisbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.girisbutton.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PatientFollowUpProgram.Properties.Resources.Adsız;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(426, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "GİRİŞ EKRANI";
            // 
            // backtoregisterbutton
            // 
            this.backtoregisterbutton.AnimationHoverSpeed = 0.07F;
            this.backtoregisterbutton.AnimationSpeed = 0.03F;
            this.backtoregisterbutton.BaseColor1 = System.Drawing.Color.CadetBlue;
            this.backtoregisterbutton.BaseColor2 = System.Drawing.SystemColors.Control;
            this.backtoregisterbutton.BorderColor = System.Drawing.Color.CadetBlue;
            this.backtoregisterbutton.BorderSize = 3;
            this.backtoregisterbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backtoregisterbutton.FocusedColor = System.Drawing.Color.Empty;
            this.backtoregisterbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backtoregisterbutton.ForeColor = System.Drawing.Color.Black;
            this.backtoregisterbutton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.backtoregisterbutton.Image = null;
            this.backtoregisterbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.backtoregisterbutton.Location = new System.Drawing.Point(222, 366);
            this.backtoregisterbutton.Name = "backtoregisterbutton";
            this.backtoregisterbutton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.backtoregisterbutton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.backtoregisterbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backtoregisterbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.backtoregisterbutton.OnHoverImage = null;
            this.backtoregisterbutton.OnPressedColor = System.Drawing.Color.Black;
            this.backtoregisterbutton.Size = new System.Drawing.Size(261, 49);
            this.backtoregisterbutton.TabIndex = 9;
            this.backtoregisterbutton.Text = "KAYIT EKRANINA DÖN";
            this.backtoregisterbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backtoregisterbutton.Click += new System.EventHandler(this.backtoregisterbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.backtoregisterbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.girisbutton);
            this.Controls.Add(this.girissifretexbox);
            this.Controls.Add(this.giristctextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox giristctextbox;
        private Guna.UI.WinForms.GunaTextBox girissifretexbox;
        private Guna.UI.WinForms.GunaGradientButton girisbutton;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGradientButton backtoregisterbutton;
    }
}

