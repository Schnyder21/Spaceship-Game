namespace Animation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spaceship = new System.Windows.Forms.PictureBox();
            this.Spaceshiptimer = new System.Windows.Forms.Timer(this.components);
            this.alien5 = new System.Windows.Forms.PictureBox();
            this.lblscore = new System.Windows.Forms.Label();
            this.alien4 = new System.Windows.Forms.PictureBox();
            this.alien1 = new System.Windows.Forms.PictureBox();
            this.alien9 = new System.Windows.Forms.PictureBox();
            this.alien10 = new System.Windows.Forms.PictureBox();
            this.alien8 = new System.Windows.Forms.PictureBox();
            this.alien2 = new System.Windows.Forms.PictureBox();
            this.alien3 = new System.Windows.Forms.PictureBox();
            this.alien6 = new System.Windows.Forms.PictureBox();
            this.alien7 = new System.Windows.Forms.PictureBox();
            this.purplefireballpicture = new System.Windows.Forms.PictureBox();
            this.purplefireballpicturetimer = new System.Windows.Forms.Timer(this.components);
            this.starstimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplefireballpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // spaceship
            // 
            this.spaceship.BackColor = System.Drawing.Color.Transparent;
            this.spaceship.Image = ((System.Drawing.Image)(resources.GetObject("spaceship.Image")));
            this.spaceship.Location = new System.Drawing.Point(25, 149);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(74, 36);
            this.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.spaceship.TabIndex = 1;
            this.spaceship.TabStop = false;
            this.spaceship.Click += new System.EventHandler(this.Dragonpicture_Click);
            // 
            // Spaceshiptimer
            // 
            this.Spaceshiptimer.Interval = 10;
            this.Spaceshiptimer.Tick += new System.EventHandler(this.Dragontimer_Tick);
            // 
            // alien5
            // 
            this.alien5.BackColor = System.Drawing.Color.Transparent;
            this.alien5.Image = ((System.Drawing.Image)(resources.GetObject("alien5.Image")));
            this.alien5.Location = new System.Drawing.Point(337, 7);
            this.alien5.Name = "alien5";
            this.alien5.Size = new System.Drawing.Size(39, 35);
            this.alien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien5.TabIndex = 2;
            this.alien5.TabStop = false;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.DarkGray;
            this.lblscore.Location = new System.Drawing.Point(696, 7);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(13, 13);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "0";
            // 
            // alien4
            // 
            this.alien4.BackColor = System.Drawing.Color.Transparent;
            this.alien4.Image = ((System.Drawing.Image)(resources.GetObject("alien4.Image")));
            this.alien4.Location = new System.Drawing.Point(430, 50);
            this.alien4.Name = "alien4";
            this.alien4.Size = new System.Drawing.Size(41, 42);
            this.alien4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien4.TabIndex = 4;
            this.alien4.TabStop = false;
            // 
            // alien1
            // 
            this.alien1.BackColor = System.Drawing.Color.Transparent;
            this.alien1.Image = ((System.Drawing.Image)(resources.GetObject("alien1.Image")));
            this.alien1.Location = new System.Drawing.Point(587, 106);
            this.alien1.Name = "alien1";
            this.alien1.Size = new System.Drawing.Size(166, 46);
            this.alien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien1.TabIndex = 5;
            this.alien1.TabStop = false;
            // 
            // alien9
            // 
            this.alien9.BackColor = System.Drawing.Color.Transparent;
            this.alien9.Image = ((System.Drawing.Image)(resources.GetObject("alien9.Image")));
            this.alien9.Location = new System.Drawing.Point(168, 12);
            this.alien9.Name = "alien9";
            this.alien9.Size = new System.Drawing.Size(46, 27);
            this.alien9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien9.TabIndex = 6;
            this.alien9.TabStop = false;
            // 
            // alien10
            // 
            this.alien10.BackColor = System.Drawing.Color.Transparent;
            this.alien10.Image = ((System.Drawing.Image)(resources.GetObject("alien10.Image")));
            this.alien10.Location = new System.Drawing.Point(147, 89);
            this.alien10.Name = "alien10";
            this.alien10.Size = new System.Drawing.Size(28, 34);
            this.alien10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien10.TabIndex = 7;
            this.alien10.TabStop = false;
            // 
            // alien8
            // 
            this.alien8.BackColor = System.Drawing.Color.Transparent;
            this.alien8.Image = ((System.Drawing.Image)(resources.GetObject("alien8.Image")));
            this.alien8.Location = new System.Drawing.Point(52, 22);
            this.alien8.Name = "alien8";
            this.alien8.Size = new System.Drawing.Size(38, 39);
            this.alien8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien8.TabIndex = 8;
            this.alien8.TabStop = false;
            // 
            // alien2
            // 
            this.alien2.BackColor = System.Drawing.Color.Transparent;
            this.alien2.Image = ((System.Drawing.Image)(resources.GetObject("alien2.Image")));
            this.alien2.Location = new System.Drawing.Point(244, 89);
            this.alien2.Name = "alien2";
            this.alien2.Size = new System.Drawing.Size(49, 32);
            this.alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien2.TabIndex = 9;
            this.alien2.TabStop = false;
            // 
            // alien3
            // 
            this.alien3.BackColor = System.Drawing.Color.Transparent;
            this.alien3.Image = ((System.Drawing.Image)(resources.GetObject("alien3.Image")));
            this.alien3.Location = new System.Drawing.Point(651, 31);
            this.alien3.Name = "alien3";
            this.alien3.Size = new System.Drawing.Size(43, 39);
            this.alien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien3.TabIndex = 10;
            this.alien3.TabStop = false;
            // 
            // alien6
            // 
            this.alien6.BackColor = System.Drawing.Color.Transparent;
            this.alien6.Image = ((System.Drawing.Image)(resources.GetObject("alien6.Image")));
            this.alien6.Location = new System.Drawing.Point(519, 31);
            this.alien6.Name = "alien6";
            this.alien6.Size = new System.Drawing.Size(46, 40);
            this.alien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien6.TabIndex = 11;
            this.alien6.TabStop = false;
            // 
            // alien7
            // 
            this.alien7.BackColor = System.Drawing.Color.Transparent;
            this.alien7.Image = ((System.Drawing.Image)(resources.GetObject("alien7.Image")));
            this.alien7.Location = new System.Drawing.Point(260, 22);
            this.alien7.Name = "alien7";
            this.alien7.Size = new System.Drawing.Size(33, 32);
            this.alien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien7.TabIndex = 12;
            this.alien7.TabStop = false;
            // 
            // purplefireballpicture
            // 
            this.purplefireballpicture.BackColor = System.Drawing.Color.Transparent;
            this.purplefireballpicture.Image = ((System.Drawing.Image)(resources.GetObject("purplefireballpicture.Image")));
            this.purplefireballpicture.Location = new System.Drawing.Point(82, 157);
            this.purplefireballpicture.Name = "purplefireballpicture";
            this.purplefireballpicture.Size = new System.Drawing.Size(17, 17);
            this.purplefireballpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.purplefireballpicture.TabIndex = 13;
            this.purplefireballpicture.TabStop = false;
            this.purplefireballpicture.Visible = false;
            this.purplefireballpicture.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.purplefireballpicture_PreviewKeyDown);
            // 
            // purplefireballpicturetimer
            // 
            this.purplefireballpicturetimer.Interval = 1;
            this.purplefireballpicturetimer.Tick += new System.EventHandler(this.purplefireballpicturetimer_Tick);
            // 
            // starstimer
            // 
            this.starstimer.Tick += new System.EventHandler(this.starstimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 444);
            this.Controls.Add(this.purplefireballpicture);
            this.Controls.Add(this.alien7);
            this.Controls.Add(this.alien6);
            this.Controls.Add(this.alien3);
            this.Controls.Add(this.alien2);
            this.Controls.Add(this.alien8);
            this.Controls.Add(this.alien10);
            this.Controls.Add(this.alien9);
            this.Controls.Add(this.alien1);
            this.Controls.Add(this.alien4);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.alien5);
            this.Controls.Add(this.spaceship);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplefireballpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox spaceship;
        private System.Windows.Forms.Timer Spaceshiptimer;
        private System.Windows.Forms.PictureBox alien5;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox alien4;
        private System.Windows.Forms.PictureBox alien1;
        private System.Windows.Forms.PictureBox alien9;
        private System.Windows.Forms.PictureBox alien10;
        private System.Windows.Forms.PictureBox alien8;
        private System.Windows.Forms.PictureBox alien2;
        private System.Windows.Forms.PictureBox alien3;
        private System.Windows.Forms.PictureBox alien6;
        private System.Windows.Forms.PictureBox alien7;
        private System.Windows.Forms.PictureBox purplefireballpicture;
        private System.Windows.Forms.Timer purplefireballpicturetimer;
        private System.Windows.Forms.Timer starstimer;
    }
}

