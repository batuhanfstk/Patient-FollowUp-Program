namespace PatientFollowUpProgram.Forms
{
    partial class Registerform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kayittctextbox = new Guna.UI.WinForms.GunaTextBox();
            this.kayitsifretextbox = new Guna.UI.WinForms.GunaTextBox();
            this.kayitbutton = new Guna.UI.WinForms.GunaGradientButton();
            this.backtologinbutton = new Guna.UI.WinForms.GunaGradientButton();
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
            this.panel1.Size = new System.Drawing.Size(935, 100);
            this.panel1.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(404, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "KAYIT EKRANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(175, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC KİMLİK NO : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(258, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "ŞİFRE : ";
            // 
            // kayittctextbox
            // 
            this.kayittctextbox.AcceptsReturn = true;
            this.kayittctextbox.BaseColor = System.Drawing.Color.White;
            this.kayittctextbox.BorderColor = System.Drawing.Color.CadetBlue;
            this.kayittctextbox.BorderSize = 3;
            this.kayittctextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayittctextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.kayittctextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.kayittctextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.kayittctextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayittctextbox.Location = new System.Drawing.Point(340, 258);
            this.kayittctextbox.Name = "kayittctextbox";
            this.kayittctextbox.PasswordChar = '\0';
            this.kayittctextbox.SelectedText = "";
            this.kayittctextbox.Size = new System.Drawing.Size(385, 35);
            this.kayittctextbox.TabIndex = 5;
            // 
            // kayitsifretextbox
            // 
            this.kayitsifretextbox.AcceptsReturn = true;
            this.kayitsifretextbox.BaseColor = System.Drawing.Color.White;
            this.kayitsifretextbox.BorderColor = System.Drawing.Color.CadetBlue;
            this.kayitsifretextbox.BorderSize = 3;
            this.kayitsifretextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayitsifretextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.kayitsifretextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.kayitsifretextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.kayitsifretextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitsifretextbox.Location = new System.Drawing.Point(340, 308);
            this.kayitsifretextbox.Name = "kayitsifretextbox";
            this.kayitsifretextbox.PasswordChar = '\0';
            this.kayitsifretextbox.SelectedText = "";
            this.kayitsifretextbox.Size = new System.Drawing.Size(385, 35);
            this.kayitsifretextbox.TabIndex = 6;
            // 
            // kayitbutton
            // 
            this.kayitbutton.AnimationHoverSpeed = 0.07F;
            this.kayitbutton.AnimationSpeed = 0.03F;
            this.kayitbutton.BaseColor1 = System.Drawing.Color.CadetBlue;
            this.kayitbutton.BaseColor2 = System.Drawing.SystemColors.Control;
            this.kayitbutton.BorderColor = System.Drawing.Color.CadetBlue;
            this.kayitbutton.BorderSize = 3;
            this.kayitbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kayitbutton.FocusedColor = System.Drawing.Color.Empty;
            this.kayitbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitbutton.ForeColor = System.Drawing.Color.Black;
            this.kayitbutton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.kayitbutton.Image = null;
            this.kayitbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.kayitbutton.Location = new System.Drawing.Point(498, 381);
            this.kayitbutton.Name = "kayitbutton";
            this.kayitbutton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.kayitbutton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.kayitbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.kayitbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.kayitbutton.OnHoverImage = null;
            this.kayitbutton.OnPressedColor = System.Drawing.Color.Black;
            this.kayitbutton.Size = new System.Drawing.Size(227, 49);
            this.kayitbutton.TabIndex = 7;
            this.kayitbutton.Text = "KAYIT OLUŞTUR";
            this.kayitbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kayitbutton.Click += new System.EventHandler(this.kayitbutton_Click);
            // 
            // backtologinbutton
            // 
            this.backtologinbutton.AnimationHoverSpeed = 0.07F;
            this.backtologinbutton.AnimationSpeed = 0.03F;
            this.backtologinbutton.BaseColor1 = System.Drawing.Color.CadetBlue;
            this.backtologinbutton.BaseColor2 = System.Drawing.SystemColors.Control;
            this.backtologinbutton.BorderColor = System.Drawing.Color.CadetBlue;
            this.backtologinbutton.BorderSize = 3;
            this.backtologinbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backtologinbutton.FocusedColor = System.Drawing.Color.Empty;
            this.backtologinbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backtologinbutton.ForeColor = System.Drawing.Color.Black;
            this.backtologinbutton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.backtologinbutton.Image = null;
            this.backtologinbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.backtologinbutton.Location = new System.Drawing.Point(199, 381);
            this.backtologinbutton.Name = "backtologinbutton";
            this.backtologinbutton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.backtologinbutton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.backtologinbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backtologinbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.backtologinbutton.OnHoverImage = null;
            this.backtologinbutton.OnPressedColor = System.Drawing.Color.Black;
            this.backtologinbutton.Size = new System.Drawing.Size(261, 49);
            this.backtologinbutton.TabIndex = 8;
            this.backtologinbutton.Text = "GİRİŞ EKRANINA DÖN";
            this.backtologinbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backtologinbutton.Click += new System.EventHandler(this.backtologinbutton_Click);
            // 
            // Registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 554);
            this.Controls.Add(this.backtologinbutton);
            this.Controls.Add(this.kayitbutton);
            this.Controls.Add(this.kayitsifretextbox);
            this.Controls.Add(this.kayittctextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registerform";
            this.Text = "Registerform";
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
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox kayittctextbox;
        private Guna.UI.WinForms.GunaTextBox kayitsifretextbox;
        private Guna.UI.WinForms.GunaGradientButton kayitbutton;
        private Guna.UI.WinForms.GunaGradientButton backtologinbutton;
    }
}