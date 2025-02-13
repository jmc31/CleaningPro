namespace CleaningPro
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblContactUs = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblhome = new System.Windows.Forms.Label();
            this.lblBookNow = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblContactUs);
            this.panel1.Controls.Add(this.lblAboutUs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblhome);
            this.panel1.Controls.Add(this.lblBookNow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Location = new System.Drawing.Point(38, 408);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(40, 13);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblContactUs
            // 
            this.lblContactUs.AutoSize = true;
            this.lblContactUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContactUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactUs.Location = new System.Drawing.Point(26, 312);
            this.lblContactUs.Name = "lblContactUs";
            this.lblContactUs.Size = new System.Drawing.Size(69, 16);
            this.lblContactUs.TabIndex = 3;
            this.lblContactUs.Text = "Contact us";
            this.lblContactUs.Click += new System.EventHandler(this.lblContactUs_Click);
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(29, 261);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(59, 16);
            this.lblAboutUs.TabIndex = 4;
            this.lblAboutUs.Text = "About us";
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.Location = new System.Drawing.Point(29, 159);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(44, 16);
            this.lblhome.TabIndex = 1;
            this.lblhome.Text = "Home";
            // 
            // lblBookNow
            // 
            this.lblBookNow.AutoSize = true;
            this.lblBookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNow.Location = new System.Drawing.Point(29, 212);
            this.lblBookNow.Name = "lblBookNow";
            this.lblBookNow.Size = new System.Drawing.Size(66, 16);
            this.lblBookNow.TabIndex = 2;
            this.lblBookNow.Text = "Book now";
            this.lblBookNow.Click += new System.EventHandler(this.lblBookNow_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(132, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(671, 450);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContactUs;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Label lblBookNow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLogout;
    }
}