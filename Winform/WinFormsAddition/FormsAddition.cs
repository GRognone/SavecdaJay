using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WinFormsAddition
{
    public partial class FormsAddition : Form
    {
        int total;

        public FormsAddition()
        {
            InitializeComponent();
            total = 0;
        }

        private void FormsAddition_Load(object sender, EventArgs e)
        {
            
        }

        /* solution pour rassembler l'ensemble des boutons*/
        private void button_Chiffres_Click(object sender, EventArgs e) 
        {
            Button b = sender as Button;
            this.textBox_Affichage.Text += b.Tag +"+";
            total += int.Parse((string)b.Tag);
        }

       
        private void button10_vider_Click(object sender, EventArgs e)
        {
            this.textBox_Affichage.Text = "";
            total = 0;
        }

        private void button11_Calculer_Click(object sender, EventArgs e)
        {
            this.textBox_Affichage.Text += " = " + total + "+";
        }

        private void textBox_Affichage_TextChanged(object sender, EventArgs e)
        {
          
        }
        /*cette solition est sans rassembler l'ensemble des boutons dans une fonction penser à remplacer button_Chiffres_Click par button0_0_Click
        * etc pour les differents boutons dans FormsAdditionDesigners.cs

         private void button0_0_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "0+";
                  total = total + 0; ;
         }

         private void button1_1_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "1+";
                 total = total+ 1;
         }

         private void button2_2_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "2+";
             total = total + 2;
         }

         private void button3_3_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "3+";
                  total = total + 3; ;
         }

         private void button4_4_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "4+";
                  total = total + 4; ;
         }

         private void button5_5_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "5+";
             total = total + 5;
         }

         private void button6_6_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "6+";
             total = total + 6;
         }

         private void button7_7_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "7+";
             total = total + 7;
         }

         private void button8_8_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "8+";
             total = total + 8;
         }

         private void button9_9_Click(object sender, EventArgs e)
         {
             this.textBox_Affichage.Text += "9+";
             total = total + 9;
         }
    */
    }
}
