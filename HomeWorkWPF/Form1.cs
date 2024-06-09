namespace HomeWorkWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Width = hScrollBar1.Value;
        }
    }
}
