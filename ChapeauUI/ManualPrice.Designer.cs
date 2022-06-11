﻿namespace ChapeauUI
{
    partial class ManualPrice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newPriceTextBox = new System.Windows.Forms.TextBox();
            this.AfrekenenBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberOfPersons = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pas het bedrag aan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Het originele bedrag is:";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Location = new System.Drawing.Point(162, 72);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(28, 15);
            this.totalPriceLbl.TabIndex = 2;
            this.totalPriceLbl.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Het nieuwe bedrag hier:";
            // 
            // newPriceTextBox
            // 
            this.newPriceTextBox.Location = new System.Drawing.Point(162, 95);
            this.newPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPriceTextBox.Name = "newPriceTextBox";
            this.newPriceTextBox.Size = new System.Drawing.Size(155, 23);
            this.newPriceTextBox.TabIndex = 4;
            this.newPriceTextBox.TextChanged += new System.EventHandler(this.newPriceTextbox_TextChanged);
            // 
            // AfrekenenBtn
            // 
            this.AfrekenenBtn.Location = new System.Drawing.Point(141, 192);
            this.AfrekenenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AfrekenenBtn.Name = "AfrekenenBtn";
            this.AfrekenenBtn.Size = new System.Drawing.Size(82, 22);
            this.AfrekenenBtn.TabIndex = 5;
            this.AfrekenenBtn.Text = "Afrekenen";
            this.AfrekenenBtn.UseVisualStyleBackColor = true;
            this.AfrekenenBtn.Click += new System.EventHandler(this.AfrekenenBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bon delen? Geef hier het aantal personen:";
            // 
            // textBoxNumberOfPersons
            // 
            this.textBoxNumberOfPersons.Location = new System.Drawing.Point(264, 142);
            this.textBoxNumberOfPersons.Name = "textBoxNumberOfPersons";
            this.textBoxNumberOfPersons.Size = new System.Drawing.Size(53, 23);
            this.textBoxNumberOfPersons.TabIndex = 7;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Terug";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ManualPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 225);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxNumberOfPersons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AfrekenenBtn);
            this.Controls.Add(this.newPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManualPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManualPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPriceTextBox;
        private System.Windows.Forms.Button AfrekenenBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumberOfPersons;
        private System.Windows.Forms.Button buttonBack;
    }
}