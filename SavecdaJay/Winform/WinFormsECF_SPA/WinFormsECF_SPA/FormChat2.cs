using ClassLibraryChat;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsECF_SPA.Models;

namespace WinFormsECF_SPA
{
    public partial class FormChat2 : Form
    {
        private Chat chatBDD;
        private ClassChat chat;
        private SpaContext dbContext;

        public FormChat2(ClassChat petitNouveau)
        {
            InitializeComponent();
            dbContext = new SpaContext();
            dbContext.Chats.Load();
            dbContext.Races.Load();

            comboBoxRace.DataSource = dbContext.Races.Local.ToBindingList();
            comboBoxRace.ValueMember = "Race1";

            chat = petitNouveau;
            // chat chargé depuis la Bdd par son numero puce (id)
            chatBDD = findFromId(chat.PuceNumber);

            textBoxPuceNumber.Text = chat.PuceNumber.ToString();
            textBoxName.Text = chat.Name;
            numericUpDownAge.Value = (int)chat.Age;

        }

        private Chat? findFromId(Int64 _puceNumber)
        {
            return dbContext.Chats.Find(_puceNumber);
        }
        private void textBoxPuceNumber_TextChanged(object sender, EventArgs e)
        {
            if (!ClassLibraryControl.Controls.VerifIdentifiantPuce(textBoxPuceNumber.Text))
            {
                errorProviderPuceNumber.SetError(textBoxPuceNumber, "veuillez saisir un identifiant à 15 chiffres commencant par 25026");
            }

            else
            {
                errorProviderPuceNumber.Clear();
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (textBoxName != null)
            {
                /*chatBDD = c;*/
            }
            dbContext.SaveChanges();
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            chat.CheckName(tb.Text);
            if (chat.Name.Length > 0)
            {
                errorProviderNom.Clear();
            }
            else
            {
                errorProviderNom.SetError(tb,"Nom incorrect saisissez uniquement des lettres.");
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            chat.CheckAge((int)nud.Value);
        }

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
