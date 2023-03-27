using System.Xml.Schema;


namespace WinFormsAppAddition2
{ 
   
    public partial class Form1 : Form
    {
        int total;

        public Form1()
        {
            total = 0;
            InitializeComponent();
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "0+";
            total = total + 0;
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "1+";
            total = total + 1;
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "2+";
            total = total + 2;
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "3+";
            total = total + 3;
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "4+";
            total = total + 4;
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "5+";
            total = total + 5;
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "6+";
            total = total + 6;
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "7+";
            total = total + 7;
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "8+";
            total = total + 8;
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += "9+";
            total = total + 9;
        }
        private void button_Vider_Click(object sender, EventArgs e)
        {
            total = 0;
            text_Affichage.Text = text_Affichage.Text = total + "+";
        }
        private void button_Calculer_Click(object sender, EventArgs e)
        {
            text_Affichage.Text = text_Affichage.Text += " = " + total + "+";
        }
    }    
}