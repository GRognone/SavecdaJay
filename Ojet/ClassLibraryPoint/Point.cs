namespace ClassLibraryPoint
{
    public class Point
    {
        private float xAbcisse;
        private float yOrdonnee;

        /// <summary>
        /// Constructeur classic
        /// </summary>
        public Point(float _xAbcisse, float _yOrdonnee)
        {
            this.xAbcisse = _xAbcisse;
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
        public Point(Point _point) : this(_point.xAbcisse, _point.yOrdonnee)
        {

        }

        public void SeDeplacer(float _nouvelleCoordonneeX, float _nouvelleCoordonneeY) // cree une copie de x et y , et modifie x et y
        {
            xAbcisse = _nouvelleCoordonneeX;
            yOrdonnee = _nouvelleCoordonneeY;
        }
        /// <summary>
        /// affichage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return " Les coordonnes du point sont : x = " + xAbcisse + " et y = " + yOrdonnee;
        }

        public Point SymetrieOrdonee() // inverse la valeur de y
        {

            return new Point (xAbcisse, - yOrdonnee);
        }

        public Point SymetrieAbcisse() // inverse la valeur de x
        {
           return new Point (-xAbcisse, yOrdonnee);
        }

        public Point SymetrieOrigine() // recupère les valeurs symetriques de x et x et les inverses
        {
           return this.SymetrieOrdonee().SymetrieAbcisse();
        }

        public Point Permuter() // permute les valeurs de x et y
        {
           return new Point(yOrdonnee, xAbcisse);
        }
    }
}