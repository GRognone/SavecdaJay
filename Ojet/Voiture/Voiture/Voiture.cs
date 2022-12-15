using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Voiture;

namespace Voiture
{
    public class Voiture
    {
        private string marque;
        private Moteur sonMoteur;
        private Roue[] ses4Roues;
   
        /// <summary>
        /// Constructeur classic d'une voiture. version 1 utiliser seulement 1 des 3 solutions
        /// </summary>
        /// <param name="_marque"></param>
        /// <param name="_sonMoteur"></param>
        /// <param name="_ses4Roues"></param>

        /// 
        public Voiture(string _marque, Moteur _sonMoteur, Roue[] _ses4Roues)
        {
            this.marque = _marque;
            this.sonMoteur = _sonMoteur;
            this.ses4Roues = _ses4Roues;
        }

        /// <summary>
        /// autre code pour constructeur classic pour fixer le nombre de roues version 2
        /// </summary>
        /// <param name="_marque"></param>
        /// <param name="_sonMoteur"></param>
        /// <param name="_roue1"></param>
        /// <param name="_roue2"></param>
        /// <param name="_roue3"></param>
        /// <param name="_roue4"></param>
        public Voiture(string _marque, Moteur _sonMoteur, Roue _roue1, Roue _roue2, Roue _roue3, Roue _roue4)
        {
            this.marque = _marque;
            this.sonMoteur = _sonMoteur;
            this.ses4Roues = new Roue[4] { _roue1, _roue2, _roue3, _roue4 };

        }
        /// <summary>
        /// construcSteur classic version 3
        /// </summary>
        /// <param name="_marque"></param>
        /// <param name="_enMarche"></param>
        /// <param name="_tourne"></param>
        /// <param name="_dimensionPneu"></param>
        public Voiture(string _marque, Moteur _moteur, string _dimensionPneu, bool _tourne)
        {
            this.marque = _marque;

            this.sonMoteur = new Moteur(_moteur);
            this.ses4Roues = new Roue[4] {new Roue(_dimensionPneu,_tourne),
                new Roue(_dimensionPneu, _tourne) , new Roue(_dimensionPneu,_tourne),
                new Roue(_dimensionPneu, _tourne)};
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Voiture()
        {
            this.marque = "Peugeot";
            this.sonMoteur = new Moteur();
            this.ses4Roues = new Roue[4] { new Roue(), new Roue(), new Roue(), new Roue() };
        }
        /// <summary>
        /// constructeur par clonage
        /// </summary>
        /// <param name="_voitureACopier"></param>
        public Voiture(Voiture _voitureACopier)
        {
            this.marque = _voitureACopier.marque;
            this.sonMoteur = new Moteur(_voitureACopier.sonMoteur);
            this.ses4Roues = new Roue[] { new Roue(_voitureACopier.ses4Roues[0]), new Roue(_voitureACopier.ses4Roues[1]), new Roue(_voitureACopier.ses4Roues[2]), new Roue(_voitureACopier.ses4Roues[3]) };
        }

       /* /// <summary>
        /// Autre constructeur par recopie avec référence avec un constructeur classique. 
        /// </summary>
        /// <param name="_voitureACopier"></param>
        public Voiture(Voiture _voitureACopier) : this(_voitureACopier.marque,
            new Moteur(_voitureACopier.sonMoteur),
            new Roue[] { new Roue(_voitureACopier.ses4Roues[0]),
            new Roue(_voitureACopier.ses4Roues[1]),
             new Roue(_voitureACopier.ses4Roues[2]),
            new Roue(_voitureACopier.ses4Roues[3])})*/

        /// <summary>
        /// Appel la methode demarer du moteur
        /// </summary>
        /// <returns>Voir retour de Moteur.Demarrer().</returns>
        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
        }
        /// <summary>
        /// Roue
        /// </summary>
        /// <returns> </returns>
        public bool Avancer()
        {
            return sonMoteur.EntrainerRoue(ses4Roues[0], ses4Roues[1]);
            //return sonMoteur.EntrainerRoue(ses4Roues2["rad"], ses4Roues2["rag"]);//version dictionnaire
        }
        public bool Freiner()
        {
            return sonMoteur.ArreterRoues(ses4Roues[0], ses4Roues[1]);
        }

        /// <summary>
        /// Permet d'éteindre le moteur si les roues ne tournent pas. 
        /// </summary>
        /// <returns>Voir retour de Moteur.Eteindre. </returns>
        public bool CouperContact()
        {
            //ses4roues[0].Tourne = true; impossible car pas de set dans la propriété Tourne. 
            //if !(ses4roues[0].Tourne || ses4roues[1].Tourne)
            //if (ses4roues[0].Tourne==false && ses4roues[1].Tourne==false)
            if (!ses4Roues[0].Tourne && !ses4Roues[1].Tourne)
            {
                return sonMoteur.Eteindre();
            }
            return false;
        }

    }
}


/*public class Voiture
{
    private string marque;
    private Moteur sonMoteur;
    private Roue[] ses4roues;
    //version dictionnaire
    //private Dictionary<string, Roue> ses4Roues2;
    /// <summary>
    /// Constructeur par défaut de Voiture. 
    /// </summary>
    public Voiture()
    {
        this.marque = "Peugeot";
        this.sonMoteur = new Moteur();
        //this.ses4roues = new Roue[4] {new Roue(),
        //new Roue(), new Roue(), new Roue()};
        this.ses4roues = new Roue[4];
        this.ses4roues[0] = new Roue();//roue avant droite
        this.ses4roues[1] = new Roue();//roue avant gauche
        this.ses4roues[2] = new Roue();//roue arriere droite
        this.ses4roues[3] = new Roue();//roue arriere gauche
                                       //version dictionnaire
        ses4Roues2 = new Dictionary<string, Roue>();
        ses4Roues2.Add("rad", new Roue());
        ses4Roues2.Add("rag", new Roue());
        ses4Roues2.Add("rard", new Roue());
        ses4Roues2.Add("rarg", new Roue());
    }
}*/