namespace ClassLibraryPoint
{
    public class Point
    {
        private float xAbscisse;
        private float yOrdonnee;

        /// <summary>
        /// Constructeur classic
        /// </summary>
        public Point(float _xAbscisse, float _yOrdonnee)
        {
            this.xAbscisse = _xAbscisse;
            this.yOrdonnee = _yOrdonnee;
        }
        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Point() : this(0.0f, 0.0f)
        {

        }
        /// <summary>
        /// Constructeur de clonage
        /// </summary>
        /// <param name="_point"></param>
        public Point(Point _point) : this(_point.xAbscisse, _point.yOrdonnee)
        {

        }

        public void SeDeplacer(float _nouvelleCoordonneeX, float _nouvelleCoordonneeY) // cree une copie de x et y , et modifie x et y
        {
            xAbscisse = _nouvelleCoordonneeX;
            yOrdonnee = _nouvelleCoordonneeY;
        }
        /// <summary>
        /// affichage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return " Les coordonnes du point sont : x = " + xAbscisse + " et y = " + yOrdonnee;
        }

        public Point SymetrieOrdonee() // inverse la valeur de y
        {

            return new Point(-xAbscisse, yOrdonnee);
        }

        public Point SymetrieAbcisse() // inverse la valeur de x
        {
            return new Point(xAbscisse, -yOrdonnee);
        }

        public Point SymetrieOrigine() // recupère les valeurs symetriques de x et x et les inverses
        {
            return this.SymetrieOrdonee().SymetrieAbcisse();
        }

        public void Permuter() // cree une copie de x et y puis permute les valeurs de x et y
        { 
            float temp = xAbscisse;
            xAbscisse = yOrdonnee;
            yOrdonnee = temp;

        }
    }
}