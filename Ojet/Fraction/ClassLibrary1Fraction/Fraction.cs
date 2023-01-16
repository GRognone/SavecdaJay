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

        public void Oppose()
        {
            numerateur = -numerateur;
        }
        public void Inverse()
        {
            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }
        private float Evalue() // transforme et calcul int en float
        {
            return ((float)this.numerateur) / this.denominateur; // le int est casté en float

        }

        public bool SuperieurA(Fraction f)
        {

            if (this.Evalue() > f.Evalue())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EgalA(Fraction f)
        {
            if (this.Evalue() > f.Evalue())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }
        

        private void Reduire()
        {
            int temp = GetPgcd();
            numerateur = this.numerateur / temp;
             denominateur = this.denominateur / temp;
        }
        public void ChangerSigneFraction()
        {
            if (denominateur < 0)
            {
                numerateur = numerateur * -1;
                denominateur = denominateur *-1;
            }
               
        }
        public string ToDisplay()
        {
            Reduire();
            ChangerSigneFraction();
            return ToString();
        }
        public Fraction Plus (Fraction _autreFraction)
        {

        }
        public Fraction Moins(Fraction _autreFraction)
        {

        }
        public Fraction Multiplie(Fraction _autreFraction)
        {

        }
        public Fraction Divise(Fraction _autreFraction)
        {

        }
    }



}
