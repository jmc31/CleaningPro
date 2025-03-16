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
            this.lblBookNow = new System.Windows.Forms.Label();
            this.lblhome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.lblContactUs = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookNow
            // 
            this.lblBookNow.AutoSize = true;
            this.lblBookNow.BackColor = System.Drawing.Color.LawnGreen;
            this.lblBookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNow.Location = new System.Drawing.Point(29, 197);
            this.lblBookNow.Name = "lblBookNow";
            this.lblBookNow.Size = new System.Drawing.Size(66, 16);
            this.lblBookNow.TabIndex = 2;
            this.lblBookNow.Text = "Book now";
            this.lblBookNow.Click += new System.EventHandler(this.lblBookNow_Click);
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
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(29, 233);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(59, 16);
            this.lblAboutUs.TabIndex = 4;
            this.lblAboutUs.Text = "About us";
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            // 
            // lblContactUs
            // 
            this.lblContactUs.AutoSize = true;
            this.lblContactUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContactUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactUs.Location = new System.Drawing.Point(29, 272);
            this.lblContactUs.Name = "lblContactUs";
            this.lblContactUs.Size = new System.Drawing.Size(69, 16);
            this.lblContactUs.TabIndex = 3;
            this.lblContactUs.Text = "Contact us";
            this.lblContactUs.Click += new System.EventHandler(this.lblContactUs_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(133, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(667, 450);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblServices);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblContactUs);
            this.panel1.Controls.Add(this.lblAboutUs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblhome);
            this.panel1.Controls.Add(this.lblBookNow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "A FRESH START, EVERY TIME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Cleaning Service Provider in Cebu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(29, 309);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(60, 16);
            this.lblServices.TabIndex = 8;
            this.lblServices.Text = "Services";
            this.lblServices.Click += new System.EventHandler(this.lblServices_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBookNow;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.Label lblContactUs;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServices;
    }
}