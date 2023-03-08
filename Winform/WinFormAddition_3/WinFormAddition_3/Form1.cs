using ClassLibraryAdditionneur;

namespace WinFormAddition_3
{
    public partial class Form1 : Form
    {
        Addition addition;
        // List<Addition> mesAdditions;
        int total;
        public Form1()
        {
            total = 0;
            InitializeComponent();
            addition = new Addition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_All_Clic(object sender, EventArgs e)
        {
            Button b = sender as Button;
            // solution sans classe metier
            /*this.textbox1_Affichage.Text += b.Tag + "+" ;
            total += int.Parse((string) b.Tag);*/

            //solution avec classe metier
            addition.AjouterNombre(int.Parse((string)b.Tag));
            this.textbox1_Affichage.Text += b.Tag + "+";
        }

        private void textBox1_Affichage(object sender, EventArgs e)
        {

        }

        private void button_Vider_Click(object sender, EventArgs e)
        {
            this.textbox1_Affichage.Text = "";
           total = 0;

            // solution avec classe metier
            addition = new Addition(); 
        }

        private void button_Calculer_Click(object sender, EventArgs e)
        {   // solution sans classe metier
            //this.textbox1_Affichage.Text += "=" + total + "+";

            // solution avec classe metier
            this.textbox1_Affichage.Text = addition.RecupererResultat() + "+";
        }


    }


}
