﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkWPF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = "Button " + (i + 1);
                button.Location = new System.Drawing.Point(20, i * 50); 
                panel1.Controls.Add(button);
            }
        }
    }
}