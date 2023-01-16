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
            if (_denominateur == 0)
            {
                throw new DivideByZeroException("Division par zero impossible");
            }
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
            numerateur = numerateur * -1;
        }
        public void Inverse()
        {
            if (numerateur == 0)
            {
                throw new DivideByZeroException("Division par zero impossible");
            }
            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }
        public float Evalue() // transforme et calcul int en float
        {
            return ((float)this.numerateur) / this.denominateur; // le int est casté en float

        }

        public bool SuperieurA(Fraction _autreFraction)
        {

            if (this.Evalue() > _autreFraction.Evalue())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EgalA(Fraction _autreFraction)
        {
            if (this.Evalue() > _autreFraction.Evalue())
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
                denominateur = denominateur * -1;
            }

        }
        public string ToDisplay()
        {
            Reduire();
            ChangerSigneFraction();
            return ToString();
        }

        public Fraction Plus(Fraction _autreFraction)
        {
            int numerateurTmp = this.numerateur * _autreFraction.denominateur + _autreFraction.numerateur * this.denominateur; // addition des numerateurs
            int denominateurTmp = this.denominateur * _autreFraction.denominateur; // addition des denominateurs
            Fraction addition = new Fraction(numerateurTmp, denominateurTmp);
            addition.Reduire();
            return addition;
        }
        public Fraction Moins(Fraction _autreFraction)
        {
            Fraction temp = new Fraction(_autreFraction); // rappel le construteur par clonage
            temp.Oppose();
            return Plus(temp);
        }
        public Fraction Multiplie(Fraction _autreFraction)
        {
            int numerateurTmp = this.numerateur * _autreFraction.numerateur;
            int denominateurTmp = this.denominateur * _autreFraction.denominateur;
            Fraction multiplication = new Fraction(numerateurTmp, denominateurTmp);
            multiplication.Reduire();
            return multiplication;
        }
        public Fraction Divise(Fraction _autreFraction)
        {
            Fraction temp = new Fraction(_autreFraction); // rappel le construteur par clonage
            temp.Inverse();
            return Multiplie(temp);
        }


        public static Fraction operator + (Fraction left, Fraction right)
        {
            return left.Plus(right);
        }

        public static Fraction operator - (Fraction left, Fraction right)
        {
            return left.Moins(right);
        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            return left.Multiplie(right);
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            return left.Divise(right);
        }
    }
}

