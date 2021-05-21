
namespace FamilyTree
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.CreateBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CreateBtn.FlatAppearance.BorderSize = 0;
            this.CreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(140)))));
            this.CreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateBtn.Image")));
            this.CreateBtn.Location = new System.Drawing.Point(137, 0);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(51, 47);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            this.CreateBtn.MouseEnter += new System.EventHandler(this.CreateBtn_MouseEnter);
            this.CreateBtn.MouseLeave += new System.EventHandler(this.CreateBtn_MouseLeave);
            this.CreateBtn.MouseHover += new System.EventHandler(this.CreateBtn_MouseEnter);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditBtn.Enabled = false;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(140)))));
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.Location = new System.Drawing.Point(75, 0);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(55, 47);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            this.EditBtn.MouseEnter += new System.EventHandler(this.EditBtn_MouseEnter);
            this.EditBtn.MouseLeave += new System.EventHandler(this.EditBtn_MouseLeave);
            this.EditBtn.MouseHover += new System.EventHandler(this.EditBtn_MouseEnter);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(140)))));
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(24, 0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(46, 47);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.DeleteBtn.MouseEnter += new System.EventHandler(this.DeleteBtn_MouseEnter);
            this.DeleteBtn.MouseLeave += new System.EventHandler(this.DeleteBtn_MouseLeave);
            this.DeleteBtn.MouseHover += new System.EventHandler(this.DeleteBtn_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Location = new System.Drawing.Point(-4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 47);
            this.panel1.TabIndex = 3;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1023, 646);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 22, 41);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

