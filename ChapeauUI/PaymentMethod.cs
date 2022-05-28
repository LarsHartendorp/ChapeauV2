﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorHandling;
using HashingAlgorithms;
using ChapeauModel;
using ChapeauLogica;

namespace ChapeauUI
{
    public partial class PaymentMethod : Form
    {
        private int tableId;
        private decimal newTotal;
        private Employee employee;
        public PaymentMethod(int TableId, decimal NewTotal, Employee employee)
        {
            InitializeComponent();
            tableId = TableId;
            newTotal = NewTotal;
            this.employee = employee;
        }
        private string paymentMethod;
        
        //ReceiptForm receipt = new ReceiptForm();

        private void AnnulerenBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }


        private void ContantBtn_Click(object sender, EventArgs e)
        {

            betaalMethode = "Contant";
            ReceiptForm receiptForm = new ReceiptForm(paymentMethod, tableId, newTotal, this.employee);

            receiptForm.ShowDialog();
            this.Close();
            
        }

        private void PinBtn_Click(object sender, EventArgs e)
        {

            betaalMethode = "Pin";
            ReceiptForm receiptForm = new ReceiptForm(paymentMethod, tableId, newTotal, this.employee);

            receiptForm.ShowDialog();
            this.Close();
        }

        private void CreditCardBtn_Click(object sender, EventArgs e)
        {

            betaalMethode = "CreditCard";
            ReceiptForm receiptForm = new ReceiptForm(paymentMethod, tableId, newTotal, this.employee);

            receiptForm.ShowDialog();
            this.Close();
        }
    }
}
