using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Computation
{
    public partial class PayrollComputation : Form
    {
        public PayrollComputation()
        {
            InitializeComponent();
        }

        private void PayrollComputation_Load(object sender, EventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            double rate, hours;
            double gross, federal, state, net;

            rate = Convert.ToDouble(hourlypr_txtbox.Text);
            hours = Convert.ToDouble(hoursworked_txtbox.Text);

            gross = rate * hours;
            federal = gross * 0.15;
            state = gross * 0.05;
            net = gross - federal - state;

            gross_txtbox.Text = gross.ToString("C");
            federal_txtbox.Text = federal.ToString("C");
            state_txtbox.Text = state.ToString("C");
            netpay_txtbox.Text = net.ToString("C");
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            name_txtbox.Clear();
            sss_txtbox.Clear();
            hourlypr_txtbox.Clear();
            hoursworked_txtbox.Clear();
            gross_txtbox.Clear();
            federal_txtbox.Clear();
            state_txtbox.Clear();
            netpay_txtbox.Clear();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
