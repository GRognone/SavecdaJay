using ClassCity;
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
using TestLienBasedeDonnées.Models;
using ClassLibraryCountries;

namespace Test_Lien_Base_de_Données
{

    public partial class FormCountry : Form
    {
        private C_Country classCountry1;
        private CitiesContext dbContext;

        public FormCountry()
        {
            InitializeComponent();
            // Creer le context vers la source
            dbContext = new CitiesContext();
            // Chargement de la table Cities
            dbContext.Countries.Load();

            //Realisation d'un binding entre lasource de donnée Cities et le DataGridView
            this.dataGridViewCountry.DataSource = dbContext.Countries.Local.ToBindingList();
        }


    }
}
