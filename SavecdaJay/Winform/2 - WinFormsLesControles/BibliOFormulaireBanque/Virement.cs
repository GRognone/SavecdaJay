namespace BiblioVirement
{
    public class Virement
    {
        string nom;
        public string Nom { get => nom;/*set => nom = value;*/ }

        DateTime date;
        public DateTime Date { get => date; /*set => date = value;*/}

        float montant;
        public float Montant { get => montant; /*set => montant = value;*/}

        string code_postal;
        public string Code_postal { get => code_postal; /*set => code_postal = value;*/ }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_nom"></param>
        /// <param name="_date"></param>
        /// <param name="_montant"></param>
        /// <param name="_code_postal"></param>
        public Virement(string _nom, DateTime _date, float _montant, string _code_postal)
        {
            nom = _nom;
            date = _date;
            montant = _montant;
            code_postal = _code_postal;
        }



        public override string ToString()
        {
            return "Virement" + nom + " " + date + " " + montant + " " + code_postal + " ";
        }
        
    }
}