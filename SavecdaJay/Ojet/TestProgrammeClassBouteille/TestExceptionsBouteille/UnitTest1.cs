using TestProgrammeClassBouteille;
using TestProgrammeClassBouteille.ExceptionsBouteilles;

namespace TestExceptionsBouteille
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_niveauActuelEnCl_When_newBouteille_Then_ValeurDeContenuImpossibleException()
        {
            //arrange

            //act

            //assert
          //Assert.ThrowsException<ValeurDeContenuImpossibleException>;
        }

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

    }
}