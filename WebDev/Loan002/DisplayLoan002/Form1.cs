using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayLoan002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Loan002.Loan NewLoan = new Loan002.Loan();
            try
            {
            NewLoan.Principal = decimal.Parse(txtPrincipal.Text);

            }
            catch (Exception)
            {
                MessageBox.Show(txtPrincipal.Text + " is not a decimal...");
                txtPrincipal.Focus();
                return;
            }
            NewLoan.APR = decimal.Parse(txtAPR.Text);
            NewLoan.Months = int.Parse(txtMonths.Text);
            lblMonthlyPayment.Text = NewLoan.MonthlyPayment.ToString();
            dataGridView1.DataSource = NewLoan.Schedule.Schedule;
        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
