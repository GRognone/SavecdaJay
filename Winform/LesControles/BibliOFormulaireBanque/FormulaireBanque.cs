namespace BibliOFormulaireBanque
{
    public class FormulaireBanque
    {
        string nom;
        string date;
        string montant;
        string code_postal;

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_nom"></param>
        /// <param name="_date"></param>
        /// <param name="_montant"></param>
        /// <param name="_code_postal"></param>
        public FormulaireBanque(string _nom, string _date, string _montant, string _code_postal)
        {
            nom = _nom;
            date = _date;
            montant = _montant;
            code_postal = _code_postal;
        }

        public override string ToString()
        {
            return "FormulaireBanque" + nom + " " + date + " " + montant + " " + code_postal+ " ";
        }

    }
}