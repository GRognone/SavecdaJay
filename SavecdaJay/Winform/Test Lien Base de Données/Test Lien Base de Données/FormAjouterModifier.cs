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

namespace Test_Lien_Base_de_Données
{
    public partial class FormAjouterModifier : Form
    {
        C_City maCity1;
        CitiesContext context;

        public FormAjouterModifier()
        {
            InitializeComponent();
            context = new CitiesContext();
            context.Cities.Load();
            context.Countries.Load();
            comboBoxCountryCode.DataSource = context.Countries.Local.ToBindingList();
            comboBoxCountryCode.ValueMember = "CountryCode";
        }

        private void buttonSaveAllCity_Click(object sender, EventArgs e)
        {
            //creer l'objet metier.
            maCity1 = new C_City(textBoxCityName.Text, ((Country)comboBoxCountryCode.SelectedItem).CountryCode);

            //Sauvegarder objet metier dans la Base de donnée
            City city = new City();
            city.CityName = maCity1.CityName;
            city.CountryCode = maCity1.CountryCode;

            context.Cities.Add(city);
            context.SaveChanges();

            maCity1.CityId = city.CityId;
        }
    }
}
