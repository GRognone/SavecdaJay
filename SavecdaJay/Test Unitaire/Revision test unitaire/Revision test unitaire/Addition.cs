namespace Revision_test_unitaire
{
    public class Addition
    {
        private double nombre1;
        private double nombre2;

        public Addition(double n1, double n2)
        {
            this.nombre1 = n1;
            this.nombre2 = n2;
        }

        public double Nombre2 { get => nombre2;  }
        public double Nombre1 { get => nombre1; }

        public double Resultat()
        {
            return nombre1 + nombre2;
        }
    }
}