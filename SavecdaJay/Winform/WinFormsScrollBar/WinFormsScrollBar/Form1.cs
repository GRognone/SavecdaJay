namespace WinFormsScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar1.Value = Math.Max(1, hScrollBar1.Value / hScrollBar1.SmallChange) * hScrollBar1.SmallChange;
            label1.Text = hScrollBar1.Value.ToString();
        }
    }
}