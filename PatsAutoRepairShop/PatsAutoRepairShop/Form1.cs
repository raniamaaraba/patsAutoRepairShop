/*
 * Program Name: 6.1
 * Programmer: Rania Maaraba
 * Date: November 2022
 * Description: Calculate the prices of customers total's at a repair shop.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace PatsAutoRepairShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*totalCharged = Decimal.Round((.08 * amountChargedTextBox_TextChanged), 2);  
            labourCharges = Decimal.Round((50 * hourOfLabourTextBox_TextChanged), 2);
            totalAMount = Decimal.Round((totalCharged + labourCharges), 2);
            */
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jobNumberTextBox.Clear();
            customerNameTextBox.Clear();
            amountChargedTextBox.Clear();
            hourOfLabourTextBox.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jobNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountChargedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hourOfLabourTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}