using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLienBasedeDonnées.Models;
using ClassCity;
using Test_Lien_Base_de_Données;

namespace TestLienBasedeDonnées
{
    public partial class FormCity : Form
    {
        private C_City classCity1;
        private CitiesContext dbContext;

        public FormCity()
        {
            InitializeComponent();
            // Creer le context vers la source
            dbContext = new CitiesContext();
            // Chargement de la table Cities
            dbContext.Cities.Load();
            //dbContext.Cities.Load<City>();// dans le ca ou le load ne fonctionne pas il faut specifier

            //Realisation d'un binding entre lasource de donnée Cities et le DataGridView
            this.dataGridViewCities.DataSource = dbContext.Cities.Local.ToBindingList();
        }

        private void buttonAddCities_Click(object sender, EventArgs e)
        {
            FormAjouterModifierCity monAjout = new FormAjouterModifierCity(dbContext, EnumModeOuverture.CREATE);
            monAjout.ShowDialog();
        }
        private void buttonDeleteCitiesMethod1_Click(object sender, EventArgs e)
        {
            {
                int id;
                id = (int)this.dataGridViewCities.CurrentRow.Cells[0].Value;
                if (id != 0)
                {
                    City? cASupprimer = dbContext.Cities.Find(id);//City? veut dire nullable
                    if (cASupprimer != null)
                    {
                        dbContext.Cities.Remove(cASupprimer);
                        dbContext.SaveChanges();
                        dataGridViewCities.Refresh();
                    }
                }
            }
        }
        private void buttonEditCity_Click(object sender, EventArgs e)
        {
            int id = (int)this.dataGridViewCities.CurrentRow.Cells[0].Value;
            City? c = findFromId(id);
            if (c == null)
                return;
            C_City cc = new C_City(c.CityId, c.CityName, c.CountryCode);
            FormAjouterModifierCity monAjout = new FormAjouterModifierCity(dbContext, EnumModeOuverture.UPDATE, cc);
            monAjout.ShowDialog();
            dataGridViewCities.Refresh();

        }
        // sert a trouver si une city existe à un id.
        private City? findFromId(int _id) => dbContext.Cities.Find(_id);

        private void dataGridViewCities_SelectionChanged(object sender, EventArgs e)
        {
            int id = (int)this.dataGridViewCities.CurrentRow.Cells[0].Value;
        }
    }
}

