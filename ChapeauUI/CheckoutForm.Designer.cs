﻿
namespace ChapeauUI
{
    partial class CheckoutForm
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
            this.buttonBackToTableOverview = new System.Windows.Forms.Button();
            this.rekeningLbl = new System.Windows.Forms.Label();
            this.rekeningListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AfrekenenBtn = new System.Windows.Forms.Button();
            this.HandmatigBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackToTableOverview
            // 
            this.buttonBackToTableOverview.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToTableOverview.Name = "buttonBackToTableOverview";
            this.buttonBackToTableOverview.Size = new System.Drawing.Size(102, 34);
            this.buttonBackToTableOverview.TabIndex = 0;
            this.buttonBackToTableOverview.Text = "Terug";
            this.buttonBackToTableOverview.UseVisualStyleBackColor = true;
            this.buttonBackToTableOverview.Click += new System.EventHandler(this.buttonBackToTableOverview_Click);
            // 
            // rekeningLbl
            // 
            this.rekeningLbl.AutoSize = true;
            this.rekeningLbl.Location = new System.Drawing.Point(47, 85);
            this.rekeningLbl.Name = "rekeningLbl";
            this.rekeningLbl.Size = new System.Drawing.Size(73, 20);
            this.rekeningLbl.TabIndex = 1;
            this.rekeningLbl.Text = "Rekening:";
            // 
            // rekeningListBox
            // 
            this.rekeningListBox.FormattingEnabled = true;
            this.rekeningListBox.ItemHeight = 20;
            this.rekeningListBox.Location = new System.Drawing.Point(47, 108);
            this.rekeningListBox.Name = "rekeningListBox";
            this.rekeningListBox.Size = new System.Drawing.Size(322, 224);
            this.rekeningListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Totaal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "0,00 EUR";
            // 
            // AfrekenenBtn
            // 
            this.AfrekenenBtn.Location = new System.Drawing.Point(47, 367);
            this.AfrekenenBtn.Name = "AfrekenenBtn";
            this.AfrekenenBtn.Size = new System.Drawing.Size(117, 38);
            this.AfrekenenBtn.TabIndex = 5;
            this.AfrekenenBtn.Text = "Afrekenen";
            this.AfrekenenBtn.UseVisualStyleBackColor = true;
            this.AfrekenenBtn.Click += new System.EventHandler(this.AfrekenenBtn_Click);
            // 
            // HandmatigBtn
            // 
            this.HandmatigBtn.Location = new System.Drawing.Point(259, 367);
            this.HandmatigBtn.Name = "HandmatigBtn";
            this.HandmatigBtn.Size = new System.Drawing.Size(110, 38);
            this.HandmatigBtn.TabIndex = 6;
            this.HandmatigBtn.Text = "Handmatig";
            this.HandmatigBtn.UseVisualStyleBackColor = true;
            this.HandmatigBtn.Click += new System.EventHandler(this.HandmatigBtn_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 480);
            this.Controls.Add(this.HandmatigBtn);
            this.Controls.Add(this.AfrekenenBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rekeningListBox);
            this.Controls.Add(this.rekeningLbl);
            this.Controls.Add(this.buttonBackToTableOverview);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToTableOverview;
        private System.Windows.Forms.Label rekeningLbl;
        private System.Windows.Forms.ListBox rekeningListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AfrekenenBtn;
        private System.Windows.Forms.Button HandmatigBtn;
    }
}