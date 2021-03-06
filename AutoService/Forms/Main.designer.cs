﻿namespace AutoService.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.employeesButton = new System.Windows.Forms.Button();
            this.cartsButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brandToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.carColorToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 24);
            this.toolStripMenuItem1.Text = "Опции";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Image = global::AutoService.Properties.Resources.steering_wheel;
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.brandToolStripMenuItem.Text = "Марки";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Image = global::AutoService.Properties.Resources.car_door;
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.modelToolStripMenuItem.Text = "Модели";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // carColorToolStripMenuItem
            // 
            this.carColorToolStripMenuItem.Image = global::AutoService.Properties.Resources.aerosol;
            this.carColorToolStripMenuItem.Name = "carColorToolStripMenuItem";
            this.carColorToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.carColorToolStripMenuItem.Text = "Цветове";
            this.carColorToolStripMenuItem.Click += new System.EventHandler(this.carColorToolStripMenuItem_Click);
            // 
            // statsButton
            // 
            this.statsButton.Image = global::AutoService.Properties.Resources.chart_bar_green;
            this.statsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statsButton.Location = new System.Drawing.Point(12, 379);
            this.statsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(195, 84);
            this.statsButton.TabIndex = 7;
            this.statsButton.Text = "Справки";
            this.statsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoService.Properties.Resources._48364228_267573177259903_5433165283348971520_n;
            this.pictureBox2.Location = new System.Drawing.Point(235, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(564, 462);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // employeesButton
            // 
            this.employeesButton.Image = ((System.Drawing.Image)(resources.GetObject("employeesButton.Image")));
            this.employeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesButton.Location = new System.Drawing.Point(12, 287);
            this.employeesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(195, 84);
            this.employeesButton.TabIndex = 3;
            this.employeesButton.Text = "Служители";
            this.employeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // cartsButton
            // 
            this.cartsButton.Image = ((System.Drawing.Image)(resources.GetObject("cartsButton.Image")));
            this.cartsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartsButton.Location = new System.Drawing.Point(12, 189);
            this.cartsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartsButton.Name = "cartsButton";
            this.cartsButton.Size = new System.Drawing.Size(195, 92);
            this.cartsButton.TabIndex = 2;
            this.cartsButton.Text = "Ремотни Карти";
            this.cartsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cartsButton.UseVisualStyleBackColor = true;
            this.cartsButton.Click += new System.EventHandler(this.cartsButton_Click);
            // 
            // partsButton
            // 
            this.partsButton.Image = ((System.Drawing.Image)(resources.GetObject("partsButton.Image")));
            this.partsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.partsButton.Location = new System.Drawing.Point(12, 112);
            this.partsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(195, 71);
            this.partsButton.TabIndex = 1;
            this.partsButton.Text = "Части";
            this.partsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.partsButton.UseVisualStyleBackColor = true;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.Image = ((System.Drawing.Image)(resources.GetObject("autoButton.Image")));
            this.autoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autoButton.Location = new System.Drawing.Point(12, 35);
            this.autoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(195, 71);
            this.autoButton.TabIndex = 0;
            this.autoButton.Text = "Автомобили";
            this.autoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 476);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.cartsButton);
            this.Controls.Add(this.partsButton);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Авто Сервиз";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button cartsButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carColorToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button statsButton;
    }
}