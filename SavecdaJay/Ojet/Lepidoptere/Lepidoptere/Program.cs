namespace Lepidoptere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere monLepidoptere = new Lepidoptere();
            ///stade oeuf
            string resultat0 = monLepidoptere.SeDeplacer();
            monLepidoptere.SeMetamorphoser();
            ///stade chenille
            string resultat1 = monLepidoptere.SeDeplacer();
            monLepidoptere.SeMetamorphoser();
            ///stade chrysalide
            string resultat2 = monLepidoptere.SeDeplacer();
            monLepidoptere.SeMetamorphoser();
            /// stade papillon
            string resultat4 = monLepidoptere.SeDeplacer();
            //Console.WriteLine(monLepidoptere.GetType().ToString());// affichera sur la console chaques etape de la metamorphose.
            monLepidoptere.SeMetamorphoser();
        }
    }
}