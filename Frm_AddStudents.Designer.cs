namespace FighyGym2
{
    partial class Frm_AddStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddStudents));
            this.txtEmpname = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.typecourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pudprice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtohWhats = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pirthdatepick = new System.Windows.Forms.DateTimePicker();
            this.nationalty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phonNm = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chktrue = new System.Windows.Forms.CheckBox();
            this.chkFalse = new System.Windows.Forms.CheckBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpname
            // 
            this.txtEmpname.FormattingEnabled = true;
            this.txtEmpname.Location = new System.Drawing.Point(521, 31);
            this.txtEmpname.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpname.Name = "txtEmpname";
            this.txtEmpname.Size = new System.Drawing.Size(230, 37);
            this.txtEmpname.TabIndex = 3;
            this.txtEmpname.Text = "اختر المدرب";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(370, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 29);
            this.label11.TabIndex = 127;
            this.label11.Text = "تاريخ الاشتراك";
            // 
            // From
            // 
            this.From.CustomFormat = "dd/MM/yyyy";
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(69, 28);
            this.From.Margin = new System.Windows.Forms.Padding(6);
            this.From.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.From.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(230, 37);
            this.From.TabIndex = 4;
            // 
            // typecourse
            // 
            this.typecourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecourse.FormattingEnabled = true;
            this.typecourse.Items.AddRange(new object[] {
            "موتاي"});
            this.typecourse.Location = new System.Drawing.Point(910, 29);
            this.typecourse.Margin = new System.Windows.Forms.Padding(6);
            this.typecourse.Name = "typecourse";
            this.typecourse.Size = new System.Drawing.Size(230, 37);
            this.typecourse.TabIndex = 0;
            this.typecourse.Text = "اختر اللعبة";
            this.typecourse.SelectedIndexChanged += new System.EventHandler(this.typecourse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1159, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 123;
            this.label3.Text = "نوع اللعبة";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(778, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 29);
            this.label10.TabIndex = 111;
            this.label10.Text = "اسم المدرب";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.typecourse);
            this.groupBox5.Controls.Add(this.pudprice);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.To);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.From);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtEmpname);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(110, 37);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1291, 175);
            this.groupBox5.TabIndex = 129;
            this.groupBox5.TabStop = false;
            // 
            // pudprice
            // 
            this.pudprice.Location = new System.Drawing.Point(910, 105);
            this.pudprice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pudprice.Name = "pudprice";
            this.pudprice.Size = new System.Drawing.Size(230, 37);
            this.pudprice.TabIndex = 1;
            this.pudprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pudprice_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(316, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 29);
            this.label17.TabIndex = 132;
            this.label17.Text = "من";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(318, 123);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 29);
            this.label16.TabIndex = 131;
            this.label16.Text = "الى";
            // 
            // To
            // 
            this.To.CustomFormat = "dd/MM/yyyy";
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(69, 112);
            this.To.Margin = new System.Windows.Forms.Padding(6);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(230, 37);
            this.To.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(1177, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 29);
            this.label14.TabIndex = 129;
            this.label14.Text = "المبلغ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtohWhats);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.pirthdatepick);
            this.groupBox1.Controls.Add(this.nationalty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.phonNm);
            this.groupBox1.Controls.Add(this.adress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(109, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1294, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات الشخصية للاعبين";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(96, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 256);
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 123;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtohWhats
            // 
            this.txtohWhats.Location = new System.Drawing.Point(304, 129);
            this.txtohWhats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtohWhats.Multiline = true;
            this.txtohWhats.Name = "txtohWhats";
            this.txtohWhats.Size = new System.Drawing.Size(304, 36);
            this.txtohWhats.TabIndex = 9;
            this.txtohWhats.TextChanged += new System.EventHandler(this.txtohWhats_TextChanged);
            this.txtohWhats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtohWhats_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(636, 130);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 29);
            this.label20.TabIndex = 32;
            this.label20.Text = "رقم الواتس ";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // pirthdatepick
            // 
            this.pirthdatepick.CustomFormat = "dd/MM/yyyy";
            this.pirthdatepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pirthdatepick.Location = new System.Drawing.Point(770, 180);
            this.pirthdatepick.Margin = new System.Windows.Forms.Padding(6);
            this.pirthdatepick.MaxDate = new System.DateTime(9998, 12, 8, 0, 0, 0, 0);
            this.pirthdatepick.Name = "pirthdatepick";
            this.pirthdatepick.Size = new System.Drawing.Size(304, 35);
            this.pirthdatepick.TabIndex = 7;
            this.pirthdatepick.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // nationalty
            // 
            this.nationalty.Location = new System.Drawing.Point(770, 123);
            this.nationalty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nationalty.Multiline = true;
            this.nationalty.Name = "nationalty";
            this.nationalty.Size = new System.Drawing.Size(304, 36);
            this.nationalty.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(1124, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "الجنسية";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // phonNm
            // 
            this.phonNm.Location = new System.Drawing.Point(304, 59);
            this.phonNm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.phonNm.Multiline = true;
            this.phonNm.Name = "phonNm";
            this.phonNm.Size = new System.Drawing.Size(304, 36);
            this.phonNm.TabIndex = 8;
            this.phonNm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonNm_KeyPress);
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(770, 250);
            this.adress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(304, 36);
            this.adress.TabIndex = 6;
            this.adress.TextChanged += new System.EventHandler(this.adress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(632, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "رقم التلفون ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1124, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "عنوان السكن";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(1124, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "تاريخ الميلاد";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(767, 60);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(304, 36);
            this.firstName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(1126, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "اسم المشترك";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.chktrue);
            this.groupBox3.Controls.Add(this.chkFalse);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(1063, 594);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(340, 102);
            this.groupBox3.TabIndex = 122;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "حالة الطالب";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chktrue
            // 
            this.chktrue.AutoSize = true;
            this.chktrue.Checked = true;
            this.chktrue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chktrue.ForeColor = System.Drawing.Color.DarkBlue;
            this.chktrue.Location = new System.Drawing.Point(200, 43);
            this.chktrue.Margin = new System.Windows.Forms.Padding(6);
            this.chktrue.Name = "chktrue";
            this.chktrue.Size = new System.Drawing.Size(90, 32);
            this.chktrue.TabIndex = 120;
            this.chktrue.Text = "مفعل";
            this.chktrue.UseVisualStyleBackColor = true;
            this.chktrue.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkFalse
            // 
            this.chkFalse.AutoSize = true;
            this.chkFalse.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkFalse.Location = new System.Drawing.Point(39, 43);
            this.chkFalse.Margin = new System.Windows.Forms.Padding(6);
            this.chkFalse.Name = "chkFalse";
            this.chkFalse.Size = new System.Drawing.Size(129, 32);
            this.chkFalse.TabIndex = 121;
            this.chkFalse.Text = "غير مفعل";
            this.chkFalse.UseVisualStyleBackColor = true;
            this.chkFalse.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(580, 708);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(276, 48);
            this.simpleButton3.TabIndex = 123;
            this.simpleButton3.Text = "تعديل";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Controls.Add(this.simpleButton3);
            this.groupBox6.Controls.Add(this.simpleButton5);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.simpleButton2);
            this.groupBox6.Controls.Add(this.simpleButton1);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(1521, 793);
            this.groupBox6.TabIndex = 130;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "بيانات المشترك";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FighyGym2.Properties.Resources.refrsh2;
            this.pictureBox3.Location = new System.Drawing.Point(10, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 124;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(-2, 594);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(196, 43);
            this.simpleButton5.TabIndex = 122;
            this.simpleButton5.Text = "الصورة النهائية";
            this.simpleButton5.Visible = false;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(864, 708);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(276, 48);
            this.simpleButton2.TabIndex = 120;
            this.simpleButton2.Text = "حفظ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(292, 708);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(276, 48);
            this.simpleButton1.TabIndex = 119;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frm_AddStudents
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 793);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.MaximumSize = new System.Drawing.Size(1523, 840);
            this.MinimumSize = new System.Drawing.Size(1523, 840);
            this.Name = "Frm_AddStudents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة بيانات اللاعبين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_AddStudents_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox txtEmpname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.ComboBox typecourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.TextBox pudprice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtohWhats;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker pirthdatepick;
        private System.Windows.Forms.TextBox nationalty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phonNm;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chktrue;
        private System.Windows.Forms.CheckBox chkFalse;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}