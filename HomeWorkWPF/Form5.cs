using System;
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
    public partial class Form5 : Form
    {
        private int count = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Button" + (count + 1);
            button.Size = new Size(100, 50);
            button.Location = new Point(10, 10 + count * 60);

            panel1.Controls.Add(button);
            count++;

            panel1.AutoScrollMinSize = new Size(0, 10 + count * 60);
        }
    }
}
