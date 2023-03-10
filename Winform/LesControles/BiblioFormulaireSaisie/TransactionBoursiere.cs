namespace BiblioFormulaireSaisie
{
    public class TransactionBoursiere
    {
        private string nom;
        private string prenom;

        public TransactionBoursiere(string a, string b)
        {
            nom = a;
            prenom = b;
        }

        public override string ToString()
        {
            return String.Format("nom:{0}{1}prenom:{2}", nom, Environment.NewLine, prenom);
        }

        public void setPrenom(string prenom) { this.prenom = prenom;  }

        public void setNom(string nom) { this.nom = nom;  }
    }
}