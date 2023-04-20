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
            // pour ajouter une ville
            City c = new City();
            c.CityName = classCity1.CityName;
            classCity1.CityName = textBoxCityNameAdd.Text;
            //c.CountryCode = "Pw";

            //ajouter dans le context
            dbContext.Cities.Add(c);
            dbContext.SaveChanges();



            dataGridViewCities.Refresh();
        }
        private void buttonAddCountries_Click(object sender, EventArgs e)
        {
            //pour ajouter un pays
            Country country = new Country();
            country.CountryCode = "b";
            country.CountryName = "bb";

            //ajouter dans le context
            dbContext.Countries.Add(country);
            dbContext.SaveChanges();
            dataGridViewCities.Refresh();
        }
        private void buttonDeleteCitiesMethod1_Click(object sender, EventArgs e)
        {
            {
                int id;
                bool idOk = int.TryParse(this.textBoxDelectIdCity.Text, out id);

                if (idOk)
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
            int id;
            bool idOk = int.TryParse(this.textBoxDelectIdCity.Text, out id);
            string nouveauNom = this.textBoxNameCityModify.Text;
            if (idOk)
            {
                City? cAModifier = dbContext.Cities.Find(id);
                if (cAModifier != null)
                {
                    cAModifier.CityName = this.textBoxNameCityModify.Text;
                    dbContext.Cities.Update(cAModifier);
                    dbContext.SaveChanges();
                    dataGridViewCities.Refresh();
                }
            }
        }
    }
}

