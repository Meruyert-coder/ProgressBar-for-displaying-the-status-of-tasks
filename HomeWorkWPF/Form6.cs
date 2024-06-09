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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            for(int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = "Button" + (i + 1);
                button.Size = new Size(100, 30);
                button.Location = new Point(10, 10 + i * 40);
                panel1.Controls.Add(button);    
            }

            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = "Button" + (i + 1);
                button.Size = new Size(100, 30);
                button.Location = new Point(10, 10 + i * 40);
                panel2.Controls.Add(button);
            }
        }
    }
}
