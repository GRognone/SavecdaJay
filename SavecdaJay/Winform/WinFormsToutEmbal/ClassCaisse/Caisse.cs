using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCaisse
{
    public class Caisse
    {
        DateTime date;
        string nom;
        float hauteur;
        float largeur;
        bool valide;

        public DateTime Date { get => date; set => date = value;}
        public string Nom { get => nom ; set => nom = value;}
        public float Hauteur { get => hauteur; set => hauteur = value;}
        public float Largeur { get => largeur ; set => largeur = value;}
        public bool Valide { get => valide; set => valide = value; }

        /// <summary>
        /// Constructeur Classic
        /// </summary>
        /// <param name="_date"></param>
        /// <param name="_nom"></param>
        /// <param name="_hauteur"></param>
        /// <param name="_largeur"></param>
        /// <param name="_valide"></param>
        public Caisse (DateTime _date, string _nom, float _hauteur, float _largeur, bool _valide)
        {
            date = _date;
            nom = _nom;
            hauteur = _hauteur;
            largeur = _largeur;
            valide = _valide;
        }
    }
}
