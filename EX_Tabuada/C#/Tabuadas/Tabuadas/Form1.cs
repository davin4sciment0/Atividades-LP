﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double conta1, num1, tab1;
            tab1 = Convert.ToDouble(txttab1.Text);
            num1 = 0;
            while (num1 < -10)
            {
                conta1 = tab1 * num1;
                string tab1String = tab1.ToString();
                string num1String = num1.ToString();
                string conta1String = conta1.ToString();
                txtresult1.Text = tab1 "x" num1 "=" conta1;
                num1++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double conta2, num2, tab2;
            tab2 = Convert.ToDouble(txttab2.Text);
            num2 = 0;
            do
            {
                conta2 = tab2 * num2;
                string tab2String = tab2.ToString();
                string num2String = num2.ToString();
                string conta2String = conta2.ToString();
                txtresult2.Text = tab2 "x" num2 "=" conta2;
                num2++;
            }
            while (num2 <= 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double conta3, num3, tab3;
            tab3 = Convert.ToDouble(txttab3.Text);
            for (num3=0; num3 <= 10; num3++)
            {
                conta3 = tab3 * num3;
                txtresult3.Text = tab3 "x" num3 "=" conta3;
            }
        }
    }
}
