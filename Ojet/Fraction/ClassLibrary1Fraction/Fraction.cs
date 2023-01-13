namespace ClassLibrary1Fraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        /// <summary>
        /// constructeur classic
        /// </summary>
        /// <param name="_numerateur"></param>
        /// <param name="_denominateur"></param>
        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Fraction() : this(0, 1)
        {

        }

        /// <summary>
        /// Constructeur par clonage
        /// </summary>
        /// <param name="_fraction"></param>
        public Fraction(Fraction _fraction) : this(_fraction.numerateur, _fraction.denominateur)
        {

        }

        public Fraction(int _numerateur) : this(_numerateur, 1)
        {

        }

        public override string ToString()
        {

            if (denominateur == 1)
                return numerateur + "";
            else
                return (numerateur + "/" + denominateur);
            // return (denominateur != 1 ? numertateur+"/"+denominateur : numerateur+""); version terner
        }
        private void controlDenominateur()
        {
            if (denominateur == 0)
            {
                denominateur = 1;
            }

        }

        public int Oppose (_numerateur)
        {
            _numerateur = - numerateur;
        }
        public void Inverse()
        {
            int temp = numerateur;
            numerateur = denominateur;
            numerateur = temp;
        }
    }
}