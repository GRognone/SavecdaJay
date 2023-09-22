using TestProgrammeClassBouteille;
using TestProgrammeClassBouteille.ExceptionsBouteilles;

namespace TestExceptionsBouteille
{
    [TestClass]
    public class UnitTest1
    {
        //test pour verifier que la contenance est bien >=0
        [TestMethod]
        public void Given_contenanceEnCl_When_newBouteille_Then_ValeurDeContenuImpossibleException()
        {
            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>new Bouteille(-3,2,true));
        }

        //test pour verifier que le niveau actuel est bien >=0
        [TestMethod]
        public void Given_niveauActuelEnCl_When_newBouteille_Then_ValeurNiveauActuelImpossibleException() 
        {
            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Bouteille(100, -2, true));
        }

        //test pour verifier que si la valeur de la contenance est >=0 la valeur est bien affectee
        [TestMethod]
        public void Given_contenanceEnCl_When_valeurContenance_Then_ValeurContenanceAffectee() 
        {
            //arrange
            Bouteille bouteille = new Bouteille(100, 25, true);
            //act
            bouteille.ContenanceEnCl = 50;
            //assert
            Assert.AreEqual(50,bouteille.ContenanceEnCl);
        }

        //test pour verifier que si la valeur de la contenance est <=0 l'erreur valeur est levée
        [TestMethod]
        public void Given_contenanceEnCl_When_valeurContenance_Then_ValeurContenanceNonAffectee() 
        {
            //arrange
            Bouteille bouteille = new Bouteille(100, 25, true);
            //assert
            Assert.ThrowsException<ValeurDeContenanceImpossibleException>(() => bouteille.ContenanceEnCl = -1);

        }

        //test pour verifier que si la valeur du niveau actuel est >=0 la valeur est affectée
        [TestMethod]
        public void Given_niveauActuelEnCl_When_valeurNiveauActuel_Then_ValeurNiveauActuelAffectee() 
        {
            //arrange
            Bouteille bouteille = new Bouteille(100, 25, true);
            //act
            bouteille.NiveauActuelEnCl = 80;
            //assert
            Assert.AreEqual(80, bouteille.NiveauActuelEnCl);

        }

        //test pour verifier que si la valeur du niveau actuel est<=0 l'erreur de la valeur est levé
        [TestMethod]
        public void Given_niveauActuelEnCl_When_valeurNiveauActuel_Then_ValeurNiveauActuelNonAffectee() 
        {
            //arrange
            Bouteille bouteille = new Bouteille(100, 50, true);//50 represente la valeur initiale
            //assert
            Assert.ThrowsException<ValeurDeContenuImpossibleException>(() => bouteille.NiveauActuelEnCl = -5); // -5 represente la valeur modifiee
        }

        //test pour verifier que l'on peut ouvrir la bouteille
        [TestMethod]
        public void Given_bouteilleFermee_When_ouvrir_Then_returnTrueAndBouteilleEstOuverte()
        {
            //arrange
            bool retour;
            Bouteille bouteille = new Bouteille(100, 100, false); 

            //act
            retour = bouteille.Ouvrir();

            //assert
            Assert.IsTrue(bouteille.BouteilleEstOuverte) ;
            Assert.IsTrue(retour);
        }

        //test pour verifier que la bouteille est deja ouverte donc que l'on ne peut pas l'ouvrir
        [TestMethod]
        public void Given_bouteilleOuverte_When_ouvrir_Then_returnFalseAndBouteilleEstOuverte() 
        {
            //Arrange
            bool retour;
            Bouteille bouteille = new Bouteille(100,100,true);
            //Act
            retour = bouteille.Ouvrir();
            //Assert
            Assert.IsTrue(bouteille.BouteilleEstOuverte);
            Assert.IsFalse(retour);
        }

        //test pour verifier que la bouteille est ouverte et que l'on peut la fermer
        [TestMethod]
        public void Given_boiteilleOuverte_When_fermer_Then_returnTrueAndBouteilleEstFermee() 
        {
            //Arrange
            bool retour;
            Bouteille bouteille = new Bouteille(100, 100, true);

            //Act 
            retour = bouteille.Fermer();

            //Assert
            Assert.IsFalse(bouteille.BouteilleEstOuverte);
            Assert.IsTrue(retour);
        }

        //test pour verifier que la bouteille est fermee et que l'on ne peut pas la fermer
        [TestMethod]
        public void Given_bouteilleFermee_When_fermer_Then_returnFalseAndBouteilleEstFermee() 
        {
            //Arrange
            bool retour;
            Bouteille bouteille = new Bouteille(100, 100, false);

            //Act 
            retour = bouteille.Fermer();

            //Assert
            Assert.IsFalse(bouteille.BouteilleEstOuverte);
            Assert.IsFalse(retour);
        }

        //test pour verifier que la quantité à vider est >0
        [TestMethod]
        public void Given_quantiteAVider_When_valeurQuantiteAVider_Then_valeurQuantiteAViderImpossibleException() 
        {
            Bouteille bouteille = new Bouteille(100, 50, true);
            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bouteille.Vider(-5));
        }

        //test pour verifier que la quantite a vider est <niveau actuel
        [TestMethod]
        public void Given_quantiteAVider_When_valeurQuantiteAVider_Then_valeurQuantiteAViderAffectee() 
        {
            //arrange
            Bouteille bouteille = new Bouteille(100, 25, true);
            //act
            bouteille.Vider(25);
            //assert
            Assert.AreEqual(100, bouteille.ContenanceEnCl);
        }

       // //test pour verifier que si la quantité a vider !> niveau actuel il y a une levee d'exception
       // //[TestMethod]

       // //test pour verifier que pour tout vider la quantité a vider est = au niveau actuel.
       // //[TestMethod]


       // //test pour verifier que la quantité à remplir est >0
       //// [TestMethod]
       // public void Given_quantiteARemplir_When_valeurQuantiteARemplir_Then_valeurQuantiteARemplirImpossibleException()
       // {
       // }

       // //test pour verifier que la quantité à remplir est <= à la contenance
       // [TestMethod]

       // //test pour verifier que si la quantite a remplir est > à la contenance il y a une levee d'erreur. 
       // [TestMethod]

       // //test pour verifier que pour tout remplir la quantité à remplir est = à la difference entre la contenance et le niveau actuel
       // [TestMethod]

    }
}