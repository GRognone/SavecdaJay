using Revision_test_unitaire;

namespace MonTdd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_DeuxNombresPositifsNonNulsWhen_LorsqueLInstanciationAdditionThen_InstanciationOkEtNombreAffecte()
        {
            //ARRANGE
            int n1, n2;
            n1 = 2; 
            n2 = 3;
            Addition addition = new Addition(n1,n2);
            //ACT
            //dans ce cas present pas d'act
            //ASSERT
            Assert.IsTrue(n1 == addition.Nombre1, "");
            Assert.IsTrue(n2 == addition.Nombre2, "");
        }

        [TestMethod]
        public void Given_Addition_10Plus3When_AppelFonctionResultatThen_Retour13() 
        {
            //Arrange
            Addition addition = new Addition(10, 3);

            //Act
            double r = addition.Resultat();

            //Assert
            Assert.IsTrue(r == 13, "");
           
        }
    }
}