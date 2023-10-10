using Barnabe;

namespace TestDeMonAppliBarnabe2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_JeDonneUnMontantDe4_When_NbMagasinRealisePArBarnabe_Then_RetourLeNombreDeMAgasinVisité2() 
        {
            //arrange
            decimal montant = 4;
            //act
            int retour1 =Program.NbMagasinRealisePArBarnabe(montant);
            //assert
            Assert.IsTrue(retour1 == 2,"Le retour attendu 2 n'est pas le retour qui a été fait lors de l'appel à la fonction avec le paramettre 4");
        }
        [TestMethod]
        public void Given_JeDonneUnMontantInferieurA1_When_NbMagasinRealisePArBarnabe_ThenRetourTrowNewException() 
        {
            //arrange
            decimal montant = (decimal)0.5;

            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> Program.NbMagasinRealisePArBarnabe(montant),"Erreur montant saisie insuffisant");
        }
        [TestMethod]
        public void Given_JeDonneUnMontantDe2_When_NbMagasinRealisePArBarnabe_Then_RetourLeNombreDeMagasin1()
        {
            //Arrange
            decimal montant = 2;
            //Act
            int retour2 = Program.NbMagasinRealisePArBarnabe(montant);
            //Assert
            Assert.IsTrue(retour2 == 1, "Le retour attendu 1 n'est pas le retour qui a été fait lors de la'appel à la fonction avec le paramettre 2");
        }
        [TestMethod]
        public void Given_JeDonneUnMontantSuperieurA1EtInferieurA2_When_NbMagasinRealisePArBarnabe_Then_RetourLeNombreDeMagasin1() 
        {
            //Arrange
            decimal montant =(decimal)1.25;
            //act
            int retour3 = Program.NbMagasinRealisePArBarnabe(montant);
            //Assert
            Assert.IsTrue(retour3 == 1, "Le retour attendu 1 n'est pas celui qui a été fait lors de l'appel a la fonction avec le paramettre 1.25");
        }



    }
}