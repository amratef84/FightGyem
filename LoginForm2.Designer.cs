namespace FighyGym2
{
    partial class LoginForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm2));
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chekEmp = new System.Windows.Forms.RadioButton();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chekAdmin1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "مرحبا بك في نظام النوادي";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(49, 410);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(262, 27);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(49, 321);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(262, 27);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 36);
            this.label2.TabIndex = 100;
            this.label2.Text = "تسجيل الدخول";
            // 
            // chekEmp
            // 
            this.chekEmp.AutoSize = true;
            this.chekEmp.BackColor = System.Drawing.Color.Transparent;
            this.chekEmp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chekEmp.ForeColor = System.Drawing.Color.Maroon;
            this.chekEmp.Location = new System.Drawing.Point(239, 215);
            this.chekEmp.Name = "chekEmp";
            this.chekEmp.Size = new System.Drawing.Size(99, 33);
            this.chekEmp.TabIndex = 99;
            this.chekEmp.Text = "موظف";
            this.chekEmp.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEnter.Appearance.BackColor2 = System.Drawing.Color.MidnightBlue;
            this.btnEnter.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEnter.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEnter.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Appearance.Options.UseBackColor = true;
            this.btnEnter.Appearance.Options.UseBorderColor = true;
            this.btnEnter.Appearance.Options.UseFont = true;
            this.btnEnter.Appearance.Options.UseForeColor = true;
            this.btnEnter.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEnter.AppearancePressed.Options.UseForeColor = true;
            this.btnEnter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEnter.Location = new System.Drawing.Point(49, 452);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(109, 53);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "دخول";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.DarkCyan;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(204, 452);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 53);
            this.simpleButton1.TabIndex = 97;
            this.simpleButton1.Text = "الغاء";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(116, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // chekAdmin1
            // 
            this.chekAdmin1.AutoSize = true;
            this.chekAdmin1.BackColor = System.Drawing.Color.Transparent;
            this.chekAdmin1.Checked = true;
            this.chekAdmin1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chekAdmin1.ForeColor = System.Drawing.Color.Maroon;
            this.chekAdmin1.Location = new System.Drawing.Point(32, 215);
            this.chekAdmin1.Name = "chekAdmin1";
            this.chekAdmin1.Size = new System.Drawing.Size(80, 33);
            this.chekAdmin1.TabIndex = 104;
            this.chekAdmin1.TabStop = true;
            this.chekAdmin1.Text = "مدير";
            this.chekAdmin1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(40, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 105;
            this.label1.Text = "اسم المستخدم:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(45, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 106;
            this.label4.Text = "كلمة السر:";
            // 
            // LoginForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chekAdmin1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chekEmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.simpleButton1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LoginForm2.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "LoginForm2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton chekEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RadioButton chekAdmin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}