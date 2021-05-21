
namespace FamilyTree
{
    partial class PersonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonControl));
            this.personPhoto = new System.Windows.Forms.PictureBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // personPhoto
            // 
            this.personPhoto.Image = ((System.Drawing.Image)(resources.GetObject("personPhoto.Image")));
            this.personPhoto.Location = new System.Drawing.Point(0, 0);
            this.personPhoto.Name = "personPhoto";
            this.personPhoto.Size = new System.Drawing.Size(62, 66);
            this.personPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personPhoto.TabIndex = 0;
            this.personPhoto.TabStop = false;
            this.personPhoto.Click += new System.EventHandler(this.SelectPerson);
            this.personPhoto.MouseEnter += new System.EventHandler(this.PersonControl_MouseEnter);
            this.personPhoto.MouseLeave += new System.EventHandler(this.PersonControl_MouseLeave);
            this.personPhoto.MouseHover += new System.EventHandler(this.PersonControl_MouseEnter);
            // 
            // NameLbl
            // 
            this.NameLbl.AccessibleName = "NameLbl";
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.NameLbl.Location = new System.Drawing.Point(68, 8);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(155, 18);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "First name last name";
            this.NameLbl.Click += new System.EventHandler(this.SelectPerson);
            this.NameLbl.MouseEnter += new System.EventHandler(this.PersonControl_MouseEnter);
            this.NameLbl.MouseLeave += new System.EventHandler(this.PersonControl_MouseLeave);
            this.NameLbl.MouseHover += new System.EventHandler(this.PersonControl_MouseEnter);
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.Location = new System.Drawing.Point(69, 44);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(63, 13);
            this.AgeLbl.TabIndex = 2;
            this.AgeLbl.Text = "1997 (23)";
            this.AgeLbl.Click += new System.EventHandler(this.SelectPerson);
            this.AgeLbl.MouseEnter += new System.EventHandler(this.PersonControl_MouseEnter);
            this.AgeLbl.MouseLeave += new System.EventHandler(this.PersonControl_MouseLeave);
            this.AgeLbl.MouseHover += new System.EventHandler(this.PersonControl_MouseEnter);
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(69, 28);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(33, 13);
            this.GenderLbl.TabIndex = 3;
            this.GenderLbl.Text = "Male";
            this.GenderLbl.Click += new System.EventHandler(this.SelectPerson);
            this.GenderLbl.MouseEnter += new System.EventHandler(this.PersonControl_MouseEnter);
            this.GenderLbl.MouseLeave += new System.EventHandler(this.PersonControl_MouseLeave);
            this.GenderLbl.MouseHover += new System.EventHandler(this.PersonControl_MouseEnter);
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.personPhoto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(238, 66);
            this.Click += new System.EventHandler(this.SelectPerson);
            this.MouseEnter += new System.EventHandler(this.PersonControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PersonControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.PersonControl_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.personPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox personPhoto;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label GenderLbl;
    }
}
