﻿namespace AutoService.Forms
{
    partial class MenuBrandForm
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
            this.BrandAdd = new System.Windows.Forms.Button();
            this.BrandEdit = new System.Windows.Forms.Button();
            this.BrandDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrandAdd
            // 
            this.BrandAdd.Location = new System.Drawing.Point(12, 13);
            this.BrandAdd.Name = "BrandAdd";
            this.BrandAdd.Size = new System.Drawing.Size(134, 23);
            this.BrandAdd.TabIndex = 2;
            this.BrandAdd.Text = "Добавяне на марка";
            this.BrandAdd.UseVisualStyleBackColor = true;
            // 
            // BrandEdit
            // 
            this.BrandEdit.Location = new System.Drawing.Point(12, 42);
            this.BrandEdit.Name = "BrandEdit";
            this.BrandEdit.Size = new System.Drawing.Size(134, 23);
            this.BrandEdit.TabIndex = 3;
            this.BrandEdit.Text = "Редактиране на марка";
            this.BrandEdit.UseVisualStyleBackColor = true;
            // 
            // BrandDelete
            // 
            this.BrandDelete.Location = new System.Drawing.Point(12, 71);
            this.BrandDelete.Name = "BrandDelete";
            this.BrandDelete.Size = new System.Drawing.Size(134, 23);
            this.BrandDelete.TabIndex = 4;
            this.BrandDelete.Text = "Изтриване на марка";
            this.BrandDelete.UseVisualStyleBackColor = true;
            // 
            // MenuBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.BrandDelete);
            this.Controls.Add(this.BrandEdit);
            this.Controls.Add(this.BrandAdd);
            this.Name = "MenuBrandForm";
            this.Text = "MenuBrandForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrandAdd;
        private System.Windows.Forms.Button BrandEdit;
        private System.Windows.Forms.Button BrandDelete;
    }
}