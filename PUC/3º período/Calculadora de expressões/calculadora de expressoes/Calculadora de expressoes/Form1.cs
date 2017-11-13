using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculadora_de_expressoes.Pack;

namespace Calculadora_de_expressoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float OldSize;
        private int Ylocation;
        private void InsertValueToExpression(string val)
        {
            if (txtexpresion.TextLength < txtexpresion.MaxLength)
            {
                if (txtexpresion.Text == "0") txtexpresion.Text = val;
                else
                {
                    txtexpresion.Text += val;
                    WaitToCalc.Enabled = true;
                    to4 = 1;
                }
            }
        }
        private void Restore()
        {
            txtexpresion.Font = new Font(txtexpresion.Font.FontFamily, OldSize);
            txtexpresion.Location = new Point(txtexpresion.Location.X, Ylocation);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OldSize = txtexpresion.Font.Size;
            Ylocation = txtexpresion.Location.Y;
        }
        private void btnb1_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("(");
        }
        private void btnb2_Click(object sender, EventArgs e)
        {
            InsertValueToExpression(")");
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            txtexpresion.Text = Polonesa_Reversa.ExpressionCalculate(txtexpresion.Text).ToString();
            WaitToCalc.Enabled = false;
            to4 = 1;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("9");
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            InsertValueToExpression(",");
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("+");
        }

        private void btnless_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("-");
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("*");
        }

        private void btnsplit_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("/");
        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("^");
        }

        private void btnroot_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("√");
        }

        private void btnerase1_Click(object sender, EventArgs e)
        {
            txtexpresion.Text = txtexpresion.Text.Substring(0, txtexpresion.Text.Length - 1);
            to4 = 1;
        }

        private void btnereaseall_Click(object sender, EventArgs e)
        {
            txtexpresion.Text = "0";
            Restore();
            WaitToCalc.Enabled = false;
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            InsertValueToExpression("3,14");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            InsertValueToExpression(Key.Get(e));
        }
        int less = 5;
        private void txtexpresion_TextChanged(object sender, EventArgs e)
        {
            if (txtexpresion.TextLength > 14)
            {
                txtexpresion.Font = new Font(txtexpresion.Font.FontFamily, txtexpresion.Font.Size - less);
                if (less == 5) less = 1;
                int val = txtexpresion.Location.Y;
                txtexpresion.Location = new Point(txtexpresion.Location.X, ++val);
            }
        }
        int to4 = 1;
        private void WaitToCalc_Tick(object sender, EventArgs e)
        {
            if (to4 == 3)
            {
                txtexpresion.Text = Polonesa_Reversa.ExpressionCalculate(txtexpresion.Text).ToString();
                to4 = 1;
                WaitToCalc.Enabled = false;
            }
            else to4++;
        }
    }
}
