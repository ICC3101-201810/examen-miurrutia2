namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.red1 = new System.Windows.Forms.PictureBox();
            this.pink1 = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uva = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wall = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // red1
            // 
            this.red1.Image = ((System.Drawing.Image)(resources.GetObject("red1.Image")));
            this.red1.Location = new System.Drawing.Point(45, 112);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(30, 30);
            this.red1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red1.TabIndex = 1;
            this.red1.TabStop = false;
            this.red1.Tag = "ghost";
            // 
            // pink1
            // 
            this.pink1.Image = ((System.Drawing.Image)(resources.GetObject("pink1.Image")));
            this.pink1.Location = new System.Drawing.Point(122, 338);
            this.pink1.Name = "pink1";
            this.pink1.Size = new System.Drawing.Size(30, 30);
            this.pink1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pink1.TabIndex = 2;
            this.pink1.TabStop = false;
            this.pink1.Tag = "ghost";
            this.pink1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // cherry
            // 
            this.cherry.Image = ((System.Drawing.Image)(resources.GetObject("cherry.Image")));
            this.cherry.Location = new System.Drawing.Point(178, 156);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(20, 20);
            this.cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cherry.TabIndex = 4;
            this.cherry.TabStop = false;
            this.cherry.Tag = "cherry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uva
            // 
            this.uva.Image = global::WindowsFormsApp1.Properties.Resources.tile114;
            this.uva.Location = new System.Drawing.Point(458, 81);
            this.uva.Name = "uva";
            this.uva.Size = new System.Drawing.Size(26, 30);
            this.uva.TabIndex = 6;
            this.uva.TabStop = false;
            this.uva.Tag = "uva";
            // 
            // pacman
            // 
            this.pacman.Image = global::WindowsFormsApp1.Properties.Resources.pacman_right;
            this.pacman.Location = new System.Drawing.Point(308, 168);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(47, 50);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pacman.TabIndex = 7;
            this.pacman.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 11);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.wall.Location = new System.Drawing.Point(-2, 524);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(637, 12);
            this.wall.TabIndex = 9;
            this.wall.TabStop = false;
            this.wall.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 537);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(624, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(11, 537);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(634, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.uva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.pink1);
            this.Controls.Add(this.red1);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Up);
            ((System.ComponentModel.ISupportInitialize)(this.red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox red1;
        private System.Windows.Forms.PictureBox pink1;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox uva;
        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox wall;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}