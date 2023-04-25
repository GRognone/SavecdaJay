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
using ClassCity;
using TestLienBasedeDonnées.Models;
using ClassControl;

namespace Test_Lien_Base_de_Données
{
    public partial class FormAjouterModifierCity : Form
    {
        C_City maCity1;
        CitiesContext context;
        private EnumModeOuverture modeOuverture;

        public FormAjouterModifierCity()
        {
            InitializeComponent();
        }
        public FormAjouterModifierCity(CitiesContext c, EnumModeOuverture mode, C_City? donnees = null)
        {
            InitializeComponent();
            context = c;
            context.Cities.Load();
            context.Countries.Load();
            comboBoxCountryCode.DataSource = context.Countries.Local.ToBindingList();
            comboBoxCountryCode.ValueMember = "CountryCode";
            modeOuverture = mode;
            labelIdCity.Visible = mode != EnumModeOuverture.CREATE;
            textBoxIdCity.Visible = mode != EnumModeOuverture.CREATE;
            textBoxIdCity.Enabled = false;
            if (donnees != null)
            {
                maCity1 = donnees;
                textBoxIdCity.Text = donnees.CityId.ToString();
                textBoxCityName.Text = donnees.CityName;
                comboBoxCountryCode.Text = donnees.CountryCode;
            }
        }
        private void textBoxCityName_TextChanged(object sender, EventArgs e)
        {
            if (ClassControl.Controls.saisieAControler(textBoxCityName.Text))
            {
                errorProviderSetCityName.Clear();
            }
            else
            {
                errorProviderSetCityName.SetError(textBoxCityName, "Veuillez saisir uniquement des lettres, pour un nom composé pour pouvez separer par un '-' suivi de lettres");
            }
        }
        private void buttonSaveAllCity_Click(object sender, EventArgs e)
        {
            switch (modeOuverture)
            {
                case EnumModeOuverture.UPDATE:
                    maCity1 = new C_City(Convert.ToInt32(textBoxIdCity.Text),
                        textBoxCityName.Text,
                        comboBoxCountryCode.Text);
                    Update();
                    break;
                case EnumModeOuverture.CREATE:
                    maCity1 = new C_City(textBoxCityName.Text,
                       comboBoxCountryCode.Text);
                    Insert();
                    break;
            }

        }
        private void Insert()
        {
            if (ClassControl.Controls.saisieAControler(textBoxCityName.Text))
            {
                if (modeOuverture != EnumModeOuverture.CREATE)
                    return;
                City city = new City();
                city.CityName = maCity1.CityName;
                city.CountryCode = maCity1.CountryCode;
                context.Cities.Add(city);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                errorProviderSetCityName.SetError(textBoxCityName, "Veuillez saisir uniquement des lettres, pour un nom composé pour pouvez separer par un '-' suivi de lettres");
            }

        }
        private void Update()
        {
            if (ClassControl.Controls.saisieAControler(textBoxCityName.Text))
            {
                if (modeOuverture != EnumModeOuverture.UPDATE)
                    return;
                City? c = findFromId(maCity1.CityId);
                if (c == null)
                    return;
                c.CityName = maCity1.CityName;
                c.CountryCode = maCity1.CountryCode;
                context.Cities.Update(c);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                errorProviderSetCityName.SetError(textBoxCityName, "Veuillez saisir uniquement des lettres, pour un nom composé pour pouvez separer par un '-' suivi de lettres");
            }
        }
        private City? findFromId(int _id)
        {
            return context.Cities.Find(_id);
        }
    }
}
