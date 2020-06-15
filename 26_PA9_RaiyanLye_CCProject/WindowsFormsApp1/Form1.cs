using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double Malaysian = 3.01;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_yen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_converted_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Clear();
            txt_converted.Clear();
            rb_us.Checked = false;
            rb_yen.Checked = false;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (rb_us.Checked == true)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_amount.Text);
                    decimal converted_amount = amount * 0.74m;
                    txt_converted.Text = "$" + converted_amount.ToString();
                }
                catch (FormatException)
                {
                    txt_amount.Clear();
                    txt_converted.Clear();
                    txt_amount.Text = "Please enter a valid amount";
                }
            }

            else if (rb_yen.Checked == true)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_amount.Text);
                    decimal converted_amount = amount * 81.97m;
                    txt_converted.Text = "" + converted_amount.ToString() + " Yen";
                }

                catch (FormatException)
                {
                    txt_amount.Clear();
                    txt_converted.Clear();
                    txt_amount.Text = "Please enter a valid amount";
                }
            }
            else if (rb_Ringgit.Checked == true)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_amount.Text);
                    decimal converted_amount = amount * 3.01m;
                    txt_converted.Text = "" + converted_amount.ToString() + " Ringgit";
                }

                catch (FormatException)
                {
                    txt_amount.Clear();
                    txt_converted.Clear();
                    txt_amount.Text = "Please enter a valid amount";
                }
            }

            else
            {
                txt_amount.Clear();
                txt_converted.Clear();
                txt_amount.Text = "Please select a currency";
            }
        }

        private void rb_us_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rb_Ringgit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
