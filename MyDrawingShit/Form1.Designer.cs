﻿namespace MyDrawingShit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.color_black = new System.Windows.Forms.Button();
            this.color_red = new System.Windows.Forms.Button();
            this.color_blue = new System.Windows.Forms.Button();
            this.color_yellow = new System.Windows.Forms.Button();
            this.color_pink = new System.Windows.Forms.Button();
            this.color_orange = new System.Windows.Forms.Button();
            this.color_green = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.color_pink);
            this.panel1.Controls.Add(this.color_green);
            this.panel1.Controls.Add(this.color_blue);
            this.panel1.Controls.Add(this.color_yellow);
            this.panel1.Controls.Add(this.color_orange);
            this.panel1.Controls.Add(this.color_red);
            this.panel1.Controls.Add(this.color_black);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 146);
            this.panel1.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(779, 32);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(53, 50);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Smazat";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Location = new System.Drawing.Point(671, 26);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(74, 62);
            this.btn_line.TabIndex = 6;
            this.btn_line.Text = "Čára";
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Location = new System.Drawing.Point(591, 26);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(74, 62);
            this.btn_rect.TabIndex = 5;
            this.btn_rect.Text = "Obdélník";
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Location = new System.Drawing.Point(511, 26);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(74, 62);
            this.btn_ellipse.TabIndex = 4;
            this.btn_ellipse.Text = "Elipsa";
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Location = new System.Drawing.Point(431, 26);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(74, 62);
            this.btn_eraser.TabIndex = 3;
            this.btn_eraser.Text = "Guma";
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Location = new System.Drawing.Point(351, 26);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(74, 62);
            this.btn_pencil.TabIndex = 2;
            this.btn_pencil.Text = "Tužka";
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Location = new System.Drawing.Point(271, 26);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(74, 62);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Barva";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.Black;
            this.pic_color.Location = new System.Drawing.Point(190, 32);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(53, 50);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(255, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 86);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 689);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 35);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(849, 724);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // color_black
            // 
            this.color_black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_black.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_black.Location = new System.Drawing.Point(20, 26);
            this.color_black.Name = "color_black";
            this.color_black.Size = new System.Drawing.Size(32, 30);
            this.color_black.TabIndex = 9;
            this.color_black.UseVisualStyleBackColor = false;
            this.color_black.Click += new System.EventHandler(this.color_black_Click);
            // 
            // color_red
            // 
            this.color_red.BackColor = System.Drawing.Color.Red;
            this.color_red.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_red.Location = new System.Drawing.Point(58, 26);
            this.color_red.Name = "color_red";
            this.color_red.Size = new System.Drawing.Size(32, 30);
            this.color_red.TabIndex = 9;
            this.color_red.UseVisualStyleBackColor = false;
            this.color_red.Click += new System.EventHandler(this.color_red_Click);
            // 
            // color_blue
            // 
            this.color_blue.BackColor = System.Drawing.Color.Blue;
            this.color_blue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_blue.Location = new System.Drawing.Point(96, 26);
            this.color_blue.Name = "color_blue";
            this.color_blue.Size = new System.Drawing.Size(32, 30);
            this.color_blue.TabIndex = 9;
            this.color_blue.UseVisualStyleBackColor = false;
            this.color_blue.Click += new System.EventHandler(this.color_blue_Click);
            // 
            // color_yellow
            // 
            this.color_yellow.BackColor = System.Drawing.Color.Yellow;
            this.color_yellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_yellow.Location = new System.Drawing.Point(20, 62);
            this.color_yellow.Name = "color_yellow";
            this.color_yellow.Size = new System.Drawing.Size(32, 30);
            this.color_yellow.TabIndex = 9;
            this.color_yellow.UseVisualStyleBackColor = false;
            this.color_yellow.Click += new System.EventHandler(this.color_yellow_Click);
            // 
            // color_pink
            // 
            this.color_pink.BackColor = System.Drawing.Color.Fuchsia;
            this.color_pink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_pink.Location = new System.Drawing.Point(96, 62);
            this.color_pink.Name = "color_pink";
            this.color_pink.Size = new System.Drawing.Size(32, 30);
            this.color_pink.TabIndex = 9;
            this.color_pink.UseVisualStyleBackColor = false;
            this.color_pink.Click += new System.EventHandler(this.color_pink_Click);
            // 
            // color_orange
            // 
            this.color_orange.BackColor = System.Drawing.Color.DarkOrange;
            this.color_orange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_orange.Location = new System.Drawing.Point(58, 62);
            this.color_orange.Name = "color_orange";
            this.color_orange.Size = new System.Drawing.Size(32, 30);
            this.color_orange.TabIndex = 9;
            this.color_orange.UseVisualStyleBackColor = false;
            this.color_orange.Click += new System.EventHandler(this.color_orange_Click);
            // 
            // color_green
            // 
            this.color_green.BackColor = System.Drawing.Color.Lime;
            this.color_green.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_green.Location = new System.Drawing.Point(134, 26);
            this.color_green.Name = "color_green";
            this.color_green.Size = new System.Drawing.Size(32, 30);
            this.color_green.TabIndex = 9;
            this.color_green.UseVisualStyleBackColor = false;
            this.color_green.Click += new System.EventHandler(this.color_green_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(134, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 30);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.color_white_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(238, 106);
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(231, 31);
            this.hScrollBar1.SmallChange = 5;
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button color_black;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button color_pink;
        private System.Windows.Forms.Button color_green;
        private System.Windows.Forms.Button color_blue;
        private System.Windows.Forms.Button color_yellow;
        private System.Windows.Forms.Button color_orange;
        private System.Windows.Forms.Button color_red;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

