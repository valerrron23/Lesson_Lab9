﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int NumberSymbols(string stroka, string symbol)
        {
            int k = 0;

            for (int i = 0, j = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol[0])
                    j++;
                if (j == symbol.Length)
                {
                    k++;
                    j = 0;
                }
            }
            return k;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKolvo.Text = NumberSymbols(txtString.Text, txtS.Text).ToString();
        }
    }
}
