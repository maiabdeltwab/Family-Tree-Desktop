
namespace FamilyTree
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.FormTitleLbl = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToHomeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FatherCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MotherCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MarriageCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.DateError = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderError = new System.Windows.Forms.Label();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.LNameError = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.FNameError = new System.Windows.Forms.Label();
            this.BirthdateLbl = new System.Windows.Forms.Label();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitleLbl
            // 
            this.FormTitleLbl.AutoSize = true;
            this.FormTitleLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(140)))));
            this.FormTitleLbl.Location = new System.Drawing.Point(11, 6);
            this.FormTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormTitleLbl.Name = "FormTitleLbl";
            this.FormTitleLbl.Size = new System.Drawing.Size(244, 24);
            this.FormTitleLbl.TabIndex = 0;
            this.FormTitleLbl.Text = "Add new family member";
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(140)))));
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CreateBtn.Location = new System.Drawing.Point(920, 485);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(128, 43);
            this.CreateBtn.TabIndex = 9;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(226)))), ((int)(((byte)(180)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClearBtn.Location = new System.Drawing.Point(809, 485);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(87, 43);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.FormTitleLbl);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 40);
            this.panel1.TabIndex = 15;
            // 
            // BackToHomeBtn
            // 
            this.BackToHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackToHomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToHomeBtn.FlatAppearance.BorderSize = 0;
            this.BackToHomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackToHomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackToHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(140)))));
            this.BackToHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackToHomeBtn.Image")));
            this.BackToHomeBtn.Location = new System.Drawing.Point(25, 494);
            this.BackToHomeBtn.Name = "BackToHomeBtn";
            this.BackToHomeBtn.Size = new System.Drawing.Size(47, 42);
            this.BackToHomeBtn.TabIndex = 21;
            this.BackToHomeBtn.UseVisualStyleBackColor = false;
            this.BackToHomeBtn.Click += new System.EventHandler(this.BackToHomeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mother";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FatherCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MotherCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(621, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(427, 189);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parents";
            // 
            // FatherCB
            // 
            this.FatherCB.DisplayMember = "Id";
            this.FatherCB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.FatherCB.ForeColor = System.Drawing.Color.Black;
            this.FatherCB.FormattingEnabled = true;
            this.FatherCB.Location = new System.Drawing.Point(24, 123);
            this.FatherCB.Margin = new System.Windows.Forms.Padding(2);
            this.FatherCB.Name = "FatherCB";
            this.FatherCB.Size = new System.Drawing.Size(382, 28);
            this.FatherCB.TabIndex = 18;
            this.FatherCB.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Father";
            // 
            // MotherCB
            // 
            this.MotherCB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.MotherCB.ForeColor = System.Drawing.Color.Black;
            this.MotherCB.FormattingEnabled = true;
            this.MotherCB.Location = new System.Drawing.Point(24, 53);
            this.MotherCB.Margin = new System.Windows.Forms.Padding(2);
            this.MotherCB.Name = "MotherCB";
            this.MotherCB.Size = new System.Drawing.Size(382, 28);
            this.MotherCB.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MarriageCB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(621, 330);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(427, 129);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marriage";
            // 
            // MarriageCB
            // 
            this.MarriageCB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.MarriageCB.ForeColor = System.Drawing.Color.Black;
            this.MarriageCB.FormattingEnabled = true;
            this.MarriageCB.Location = new System.Drawing.Point(25, 62);
            this.MarriageCB.Margin = new System.Windows.Forms.Padding(2);
            this.MarriageCB.Name = "MarriageCB";
            this.MarriageCB.Size = new System.Drawing.Size(381, 28);
            this.MarriageCB.TabIndex = 15;
            this.MarriageCB.Enter += new System.EventHandler(this.MarriageCB_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(21, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Partner";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FNameLbl);
            this.groupBox3.Controls.Add(this.FNameTB);
            this.groupBox3.Controls.Add(this.LNameTB);
            this.groupBox3.Controls.Add(this.DateError);
            this.groupBox3.Controls.Add(this.dateTimePicker);
            this.groupBox3.Controls.Add(this.GenderError);
            this.groupBox3.Controls.Add(this.GenderCB);
            this.groupBox3.Controls.Add(this.LNameError);
            this.groupBox3.Controls.Add(this.GenderLbl);
            this.groupBox3.Controls.Add(this.FNameError);
            this.groupBox3.Controls.Add(this.BirthdateLbl);
            this.groupBox3.Controls.Add(this.LNameLbl);
            this.groupBox3.Location = new System.Drawing.Point(62, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 288);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FNameLbl.Location = new System.Drawing.Point(18, 34);
            this.FNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(88, 19);
            this.FNameLbl.TabIndex = 22;
            this.FNameLbl.Text = "First name";
            // 
            // FNameTB
            // 
            this.FNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FNameTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameTB.ForeColor = System.Drawing.Color.Black;
            this.FNameTB.Location = new System.Drawing.Point(129, 30);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(352, 27);
            this.FNameTB.TabIndex = 15;
            this.FNameTB.TextChanged += new System.EventHandler(this.FNameTB_TextChanged);
            this.FNameTB.Enter += new System.EventHandler(this.FNameTB_Enter);
            this.FNameTB.Leave += new System.EventHandler(this.FNameTB_Leave);
            // 
            // LNameTB
            // 
            this.LNameTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTB.ForeColor = System.Drawing.Color.Black;
            this.LNameTB.Location = new System.Drawing.Point(129, 90);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(352, 27);
            this.LNameTB.TabIndex = 16;
            this.LNameTB.TextChanged += new System.EventHandler(this.LNameTB_TextChanged);
            this.LNameTB.Enter += new System.EventHandler(this.LNameTB_Enter);
            this.LNameTB.Leave += new System.EventHandler(this.LNameTB_Leave);
            // 
            // DateError
            // 
            this.DateError.AutoSize = true;
            this.DateError.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.DateError.ForeColor = System.Drawing.Color.Red;
            this.DateError.Location = new System.Drawing.Point(128, 251);
            this.DateError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateError.Name = "DateError";
            this.DateError.Size = new System.Drawing.Size(207, 16);
            this.DateError.TabIndex = 26;
            this.DateError.Text = "birthdate can\'t be a future date";
            this.DateError.Visible = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(129, 221);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(352, 27);
            this.dateTimePicker.TabIndex = 18;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // GenderError
            // 
            this.GenderError.AutoSize = true;
            this.GenderError.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.GenderError.ForeColor = System.Drawing.Color.Red;
            this.GenderError.Location = new System.Drawing.Point(127, 185);
            this.GenderError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderError.Name = "GenderError";
            this.GenderError.Size = new System.Drawing.Size(246, 16);
            this.GenderError.TabIndex = 25;
            this.GenderError.Text = "please choose one of the two choices";
            this.GenderError.Visible = false;
            // 
            // GenderCB
            // 
            this.GenderCB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCB.ForeColor = System.Drawing.Color.Black;
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCB.Location = new System.Drawing.Point(129, 154);
            this.GenderCB.Margin = new System.Windows.Forms.Padding(2);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(352, 28);
            this.GenderCB.TabIndex = 17;
            this.GenderCB.SelectedIndexChanged += new System.EventHandler(this.GenderCB_SelectedIndexChanged);
            this.GenderCB.TextUpdate += new System.EventHandler(this.GenderCB_TextUpdate);
            this.GenderCB.Enter += new System.EventHandler(this.GenderCB_Enter);
            this.GenderCB.Leave += new System.EventHandler(this.GenderCB_Leave);
            // 
            // LNameError
            // 
            this.LNameError.AutoSize = true;
            this.LNameError.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.LNameError.ForeColor = System.Drawing.Color.Red;
            this.LNameError.Location = new System.Drawing.Point(127, 120);
            this.LNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNameError.Name = "LNameError";
            this.LNameError.Size = new System.Drawing.Size(270, 16);
            this.LNameError.TabIndex = 24;
            this.LNameError.Text = "name must not contain special characters";
            this.LNameError.Visible = false;
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenderLbl.Location = new System.Drawing.Point(21, 152);
            this.GenderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(63, 19);
            this.GenderLbl.TabIndex = 19;
            this.GenderLbl.Text = "Gender";
            // 
            // FNameError
            // 
            this.FNameError.AutoSize = true;
            this.FNameError.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.FNameError.ForeColor = System.Drawing.Color.Red;
            this.FNameError.Location = new System.Drawing.Point(128, 60);
            this.FNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNameError.Name = "FNameError";
            this.FNameError.Size = new System.Drawing.Size(270, 16);
            this.FNameError.TabIndex = 23;
            this.FNameError.Text = "name must not contain special characters";
            this.FNameError.Visible = false;
            // 
            // BirthdateLbl
            // 
            this.BirthdateLbl.AutoSize = true;
            this.BirthdateLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdateLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BirthdateLbl.Location = new System.Drawing.Point(21, 219);
            this.BirthdateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthdateLbl.Name = "BirthdateLbl";
            this.BirthdateLbl.Size = new System.Drawing.Size(76, 19);
            this.BirthdateLbl.TabIndex = 20;
            this.BirthdateLbl.Text = "Birthdate";
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LNameLbl.Location = new System.Drawing.Point(18, 88);
            this.LNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(87, 19);
            this.LNameLbl.TabIndex = 21;
            this.LNameLbl.Text = "Last name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1160, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BackToHomeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CreateBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormTitleLbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox FatherCB;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MotherCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox MarriageCB;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackToHomeBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.Label DateError;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label GenderError;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.Label LNameError;
        public System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label FNameError;
        public System.Windows.Forms.Label BirthdateLbl;
        public System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}