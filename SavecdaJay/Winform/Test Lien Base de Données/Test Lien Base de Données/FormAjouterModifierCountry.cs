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
            //passe la textBox CountryCode en readonly et pose la selection sur la textbon countryName
            if (modeOuverture==EnumModeOuverture.UPDATE)
            {
                textBoxCountryCode.ReadOnly = true;
            }
            else
            {
                textBoxCountryCode.ReadOnly = false;
            }
            textBoxCountryName.Select();
            if (donnees != null)
            {
                monCountry1 = donnees;
                textBoxCountryCode.Text = donnees.CountryCode.ToString();
                textBoxCountryName.Text = donnees.CountryName;
            }
        }
        private void textBoxCountryCode_TextChanged(object sender, EventArgs e)
        {
            if (ClassControl.Controls.sasieCodePaysAControler(textBoxCountryCode.Text))
            {
                errorProviderCountryCode.Clear();
            }
            else
            {
                errorProviderCountryCode.SetError(textBoxCountryCode, "Veuillez saisir uniquement les 2 lettres du code pays");
            }
        }
        private void textBoxCountryName_TextChanged(object sender, EventArgs e)
        {
            if (ClassControl.Controls.saisieAControler(textBoxCountryName.Text))
            {
                errorProviderCountryName.Clear();
            }
            else
            {
                errorProviderCountryName.SetError(textBoxCountryName, "Veuillez saisir uniquement des lettres, pour un nom composé pour pouvez separer par un '-' suivi de lettres");
            }
        }
        private void buttonValider_Click(object sender, EventArgs e)
        {
            switch (modeOuverture)
            {
                case EnumModeOuverture.UPDATE:
                    monCountry1 = new C_Country(textBoxCountryCode.Text,textBoxCountryName.Text);
                    Update();
                    break;
                case EnumModeOuverture.CREATE:
                    monCountry1 = new C_Country(textBoxCountryCode.Text,textBoxCountryName.Text);
                    Insert();
                    break;
            }
            this.Close();
        }
        private void Insert()
        {
            if (ClassControl.Controls.sasieCodePaysAControler(textBoxCountryCode.Text) && ClassControl.Controls.saisieAControler(textBoxCountryName.Text))
            {
                if (modeOuverture != EnumModeOuverture.CREATE)
                    return;
                Country country = new Country();
                country.CountryCode = monCountry1.CountryCode.ToUpper();
                country.CountryName = monCountry1.CountryName;
                context.Countries.Add(country);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                if (ClassControl.Controls.sasieCodePaysAControler(textBoxCountryCode.Text))
                {
                    errorProviderCountryCode.Clear();
                }
                else
                {
                    errorProviderCountryCode.SetError(textBoxCountryCode, "Veuillez saisir uniquement les 2 lettres du code pays");
                }
                if (ClassControl.Controls.saisieAControler(textBoxCountryName.Text))
                {
                    errorProviderCountryName.Clear();
                }
                else
                {
                    errorProviderCountryName.SetError(textBoxCountryName, "Veuillez saisir uniquement des lettres, pour un nom composé pour pouvez separer par un '-' suivi de lettres");
                }
            }
        }
        private void Update()
        {
            if (ClassControl.Controls.sasieCodePaysAControler(textBoxCountryCode.Text) && ClassControl.Controls.saisieAControler(textBoxCountryName.Text))
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
            else
            {
                if (ClassControl.Controls.sasieCodePaysAControler(textBoxCountryCode.Text))
                {
                    errorProviderCountryCode.Clear();
                }
                else
                {
                    errorProviderCountryCode.SetError(textBoxCountryCode, "Veuillez saisir uniquement les 2 lettres du code pays");
                }
                if (ClassControl.Controls.saisieAControler(textBoxCountryName.Text))
                {
                    errorProviderCountryName.Clear();
                }
                else
                {
                    errorProviderCountryName.SetError(textBoxCountryName, "Veuillez saisir uniquement des lettres, pour un nom composé pour pouvez separer par un '-' suivi de lettres");
                }
            }

        }
        private Country? findFromCountryCode(string _CCode)
        {
            return context.Countries.Find(_CCode);
        }
    }
}
