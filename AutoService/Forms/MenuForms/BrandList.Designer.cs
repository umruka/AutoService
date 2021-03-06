﻿namespace AutoService.Forms
{
    partial class BrandList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandList));
            this.BrandAdd = new System.Windows.Forms.Button();
            this.BrandEdit = new System.Windows.Forms.Button();
            this.BrandDelete = new System.Windows.Forms.Button();
            this.brandGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.brandGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandAdd
            // 
            this.BrandAdd.Location = new System.Drawing.Point(16, 16);
            this.BrandAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrandAdd.Name = "BrandAdd";
            this.BrandAdd.Size = new System.Drawing.Size(179, 28);
            this.BrandAdd.TabIndex = 2;
            this.BrandAdd.Text = "Добавяне на марка";
            this.BrandAdd.UseVisualStyleBackColor = true;
            this.BrandAdd.Click += new System.EventHandler(this.BrandAdd_Click);
            // 
            // BrandEdit
            // 
            this.BrandEdit.Location = new System.Drawing.Point(16, 52);
            this.BrandEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrandEdit.Name = "BrandEdit";
            this.BrandEdit.Size = new System.Drawing.Size(179, 28);
            this.BrandEdit.TabIndex = 3;
            this.BrandEdit.Text = "Редактиране на марка";
            this.BrandEdit.UseVisualStyleBackColor = true;
            this.BrandEdit.Click += new System.EventHandler(this.BrandEdit_Click);
            // 
            // BrandDelete
            // 
            this.BrandDelete.Location = new System.Drawing.Point(16, 87);
            this.BrandDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrandDelete.Name = "BrandDelete";
            this.BrandDelete.Size = new System.Drawing.Size(179, 28);
            this.BrandDelete.TabIndex = 4;
            this.BrandDelete.Text = "Изтриване на марка";
            this.BrandDelete.UseVisualStyleBackColor = true;
            this.BrandDelete.Click += new System.EventHandler(this.BrandDelete_Click);
            // 
            // brandGridView
            // 
            this.brandGridView.AllowUserToAddRows = false;
            this.brandGridView.AllowUserToDeleteRows = false;
            this.brandGridView.BackgroundColor = System.Drawing.Color.White;
            this.brandGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandGridView.Location = new System.Drawing.Point(10, 140);
            this.brandGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brandGridView.MultiSelect = false;
            this.brandGridView.Name = "brandGridView";
            this.brandGridView.ReadOnly = true;
            this.brandGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandGridView.Size = new System.Drawing.Size(351, 185);
            this.brandGridView.TabIndex = 5;
            // 
            // BrandList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(369, 340);
            this.Controls.Add(this.brandGridView);
            this.Controls.Add(this.BrandDelete);
            this.Controls.Add(this.BrandEdit);
            this.Controls.Add(this.BrandAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BrandList";
            this.Text = "Марка";
            ((System.ComponentModel.ISupportInitialize)(this.brandGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrandAdd;
        private System.Windows.Forms.Button BrandEdit;
        private System.Windows.Forms.Button BrandDelete;
        private System.Windows.Forms.DataGridView brandGridView;
    }
}