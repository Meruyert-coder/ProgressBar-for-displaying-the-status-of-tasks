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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            int num = 10;
            progressBar1.Maximum = num;

            for(int i = 0; i < num; i++) 
            {
                await Task.Run(() => PerformTask(i));
                progressBar1.Value += 1;
            }
        }

        private void PerformTask(int tasknum)
        {
            Thread.Sleep(500);
        }
    }
}
