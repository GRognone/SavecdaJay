using ClassCity;
using ClassLibraryCountries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLienBasedeDonnées.Models;

namespace Test_Lien_Base_de_Données
{
    public partial class FormAjouterModifierCountry : Form
    {
        C_Country monCountry1;
        CitiesContext context;
        private EnumModeOuverture modeOuverture;

        public FormAjouterModifierCountry()
        {
            InitializeComponent();
        }
        public FormAjouterModifierCountry(CitiesContext co, EnumModeOuverture mode, C_Country? donnees = null)
        {
            InitializeComponent();
            context = co;
            context.Countries.Load();
            modeOuverture = mode;
            if (donnees != null)
            {
                monCountry1 = donnees;
                textBoxCountryCode.Text = donnees.CountryCode.ToString();
                textBoxCountryName.Text = donnees.CountryName;
            }
        }
        private void buttonValider_Click(object sender, EventArgs e)
        {
            switch (modeOuverture)
            {
                case EnumModeOuverture.UPDATE:
                    monCountry1 = new C_Country(textBoxCountryCode.Text,
                        textBoxCountryName.Text);
                    Update();
                    break;
                case EnumModeOuverture.CREATE:
                    monCountry1 = new C_Country(textBoxCountryCode.Text,
                        textBoxCountryName.Text);
                    Insert();
                    break;
            }
        }

        private void Insert()
        {
            if (modeOuverture != EnumModeOuverture.CREATE)
                return;
            Country country = new Country();
            country.CountryCode = monCountry1.CountryCode;
            country.CountryName = monCountry1.CountryName;
            context.Countries.Add(country);
            context.SaveChanges();
            this.Close();
        }
        private void Update()
        {
            if (modeOuverture != EnumModeOuverture.UPDATE)
                return;
            Country? co = findFromCountryCode(monCountry1.CountryCode);
            if (co == null)
                return;
            co.CountryCode = monCountry1.CountryCode;
            co.CountryName = monCountry1.CountryName;
            context.Countries.Update(co);
            context.SaveChanges();
            this.Close();
        }
        private Country? findFromCountryCode(string _CCode)
        {
            return context.Countries.Find(_CCode);
        }
    }
}
