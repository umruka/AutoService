﻿namespace AutoService
{
    partial class PartList
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
            this.partEditButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartRmv = new System.Windows.Forms.Button();
            this.PartAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partEditButton
            // 
            this.partEditButton.Location = new System.Drawing.Point(173, 72);
            this.partEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.partEditButton.Name = "partEditButton";
            this.partEditButton.Size = new System.Drawing.Size(70, 28);
            this.partEditButton.TabIndex = 7;
            this.partEditButton.Text = "Редакция";
            this.partEditButton.UseVisualStyleBackColor = true;
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(11, 148);
            this.partsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowTemplate.Height = 24;
            this.partsDataGridView.Size = new System.Drawing.Size(778, 181);
            this.partsDataGridView.TabIndex = 6;
            // 
            // PartRmv
            // 
            this.PartRmv.Location = new System.Drawing.Point(11, 75);
            this.PartRmv.Name = "PartRmv";
            this.PartRmv.Size = new System.Drawing.Size(143, 23);
            this.PartRmv.TabIndex = 5;
            this.PartRmv.Text = "Изтриване на автомобил";
            this.PartRmv.UseVisualStyleBackColor = true;
            // 
            // PartAddButton
            // 
            this.PartAddButton.Location = new System.Drawing.Point(11, 34);
            this.PartAddButton.Name = "PartAddButton";
            this.PartAddButton.Size = new System.Drawing.Size(205, 23);
            this.PartAddButton.TabIndex = 4;
            this.PartAddButton.Text = "Добавяне на резервна част";
            this.PartAddButton.UseVisualStyleBackColor = true;
            this.PartAddButton.Click += new System.EventHandler(this.PartAddButton_Click);
            // 
            // PartList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partEditButton);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.PartRmv);
            this.Controls.Add(this.PartAddButton);
            this.Name = "PartList";
            this.Text = "Parts";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button partEditButton;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.Button PartRmv;
        private System.Windows.Forms.Button PartAddButton;
    }
}