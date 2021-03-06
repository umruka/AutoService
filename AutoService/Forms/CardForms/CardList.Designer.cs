﻿namespace AutoService.Forms.CardForms
{
    partial class CardList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardList));
            this.cardEditButton = new System.Windows.Forms.Button();
            this.cardsDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveCardButton = new System.Windows.Forms.Button();
            this.CardAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cardEditButton
            // 
            this.cardEditButton.Location = new System.Drawing.Point(311, 15);
            this.cardEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardEditButton.Name = "cardEditButton";
            this.cardEditButton.Size = new System.Drawing.Size(93, 28);
            this.cardEditButton.TabIndex = 7;
            this.cardEditButton.Text = "Редакция";
            this.cardEditButton.UseVisualStyleBackColor = true;
            this.cardEditButton.Click += new System.EventHandler(this.cardEditButton_Click);
            // 
            // cardsDataGridView
            // 
            this.cardsDataGridView.AllowUserToAddRows = false;
            this.cardsDataGridView.AllowUserToDeleteRows = false;
            this.cardsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardsDataGridView.Location = new System.Drawing.Point(15, 49);
            this.cardsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardsDataGridView.MultiSelect = false;
            this.cardsDataGridView.Name = "cardsDataGridView";
            this.cardsDataGridView.ReadOnly = true;
            this.cardsDataGridView.RowTemplate.Height = 24;
            this.cardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cardsDataGridView.Size = new System.Drawing.Size(1124, 287);
            this.cardsDataGridView.TabIndex = 6;
            // 
            // RemoveCardButton
            // 
            this.RemoveCardButton.Location = new System.Drawing.Point(425, 15);
            this.RemoveCardButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveCardButton.Name = "RemoveCardButton";
            this.RemoveCardButton.Size = new System.Drawing.Size(191, 28);
            this.RemoveCardButton.TabIndex = 5;
            this.RemoveCardButton.Text = "Изтриване на карта";
            this.RemoveCardButton.UseVisualStyleBackColor = true;
            this.RemoveCardButton.Click += new System.EventHandler(this.RemoveCardButton_Click);
            // 
            // CardAddButton
            // 
            this.CardAddButton.Location = new System.Drawing.Point(15, 15);
            this.CardAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.CardAddButton.Name = "CardAddButton";
            this.CardAddButton.Size = new System.Drawing.Size(273, 28);
            this.CardAddButton.TabIndex = 4;
            this.CardAddButton.Text = "Добавяне на карта";
            this.CardAddButton.UseVisualStyleBackColor = true;
            this.CardAddButton.Click += new System.EventHandler(this.CardAddButton_Click_1);
            // 
            // CardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.bckgrndRepairCard;
            this.ClientSize = new System.Drawing.Size(1147, 348);
            this.Controls.Add(this.cardEditButton);
            this.Controls.Add(this.cardsDataGridView);
            this.Controls.Add(this.RemoveCardButton);
            this.Controls.Add(this.CardAddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CardList";
            this.Text = "Ремонтни карти";
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cardEditButton;
        private System.Windows.Forms.DataGridView cardsDataGridView;
        private System.Windows.Forms.Button RemoveCardButton;
        private System.Windows.Forms.Button CardAddButton;
    }
}