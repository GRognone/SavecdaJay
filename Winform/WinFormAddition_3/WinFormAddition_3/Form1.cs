namespace WinFormAddition_3
{
    public partial class Form1 : Form
    {
        int total;
        public Form1()
        {
            total = 0;
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_All_Clic(object sender, EventArgs e)
        {
            Button b = new Button();
            this.textbox1_Affichage.Text += ((Button)sender) + "+";
            total += ("+" + b);
        }

        private void textBox1_Affichage(object sender, EventArgs e)
        {
            
        }
    }
}