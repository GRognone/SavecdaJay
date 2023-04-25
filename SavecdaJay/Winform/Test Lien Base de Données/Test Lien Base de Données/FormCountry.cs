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
using ClassLibraryCountries;
using TestLienBasedeDonnées;


namespace Test_Lien_Base_de_Données
{

    public partial class FormCountry : Form
    {
        private C_Country classCountry1;
        private CitiesContext dbcontext;

        public FormCountry()
        {
            InitializeComponent();
            // Creer le context vers la source
            dbcontext = new CitiesContext();
            // Chargement de la table Cities
            dbcontext.Countries.Load();

            //Realisation d'un binding entre la source de donnée Countries et le DataGridView
            this.dataGridViewCountry.DataSource = dbcontext.Countries.Local.ToBindingList();

        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            FormAjouterModifierCountry monAjoutCountry = new FormAjouterModifierCountry(dbcontext, EnumModeOuverture.CREATE);
            monAjoutCountry.ShowDialog();
        }

        private void buttonDeleteCountry_Click(object sender, EventArgs e)
        {
            {
                string countryCode;
                countryCode = (string)this.dataGridViewCountry.CurrentRow.Cells[0].Value;
                if (countryCode != "")
                {
                    Country? coASupprimer = dbcontext.Countries.Find(countryCode);
                    if (coASupprimer != null)
                    {
                        // ce foreach permet de supprimer toutes les villes liées à 1 pays
                        foreach (City c in dbcontext.Cities)
                        {
                            if (c.CountryCode == coASupprimer.CountryCode)
                            {
                                dbcontext.Remove(c);
                            }
                        }
                        dbcontext.SaveChanges();
                        dbcontext.Countries.Remove(coASupprimer);
                        dbcontext.SaveChanges();
                        dataGridViewCountry.Refresh();
                    }
                }
            }
        }

        private void buttonModifyCountry_Click(object sender, EventArgs e)
        {
            string countryCode = (string)this.dataGridViewCountry.CurrentRow.Cells[0].Value;
            Country? co = findFromCountryCode(countryCode);
            if (co == null)
                return;
            C_Country cco = new C_Country(co.CountryCode, co.CountryName);
            FormAjouterModifierCountry monAjout = new FormAjouterModifierCountry(dbcontext, EnumModeOuverture.UPDATE, cco);
            monAjout.ShowDialog();
            dataGridViewCountry.Refresh();

        }
        private Country? findFromCountryCode(string _CCode) => dbcontext.Countries.Find(_CCode);

    }
}
