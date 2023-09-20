using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mon1erTestUnitaire;

namespace TestUnitaire1
{
    [TestClass]
    public class JeuTests
    {
        [TestInitialize]
        public void InitialisationDesTests()
        {
            //ajouter des initialisations
        }
        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer supérieur au second, alors le résultat est gagné avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeSuperieurAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            //Arrange
            Jeu jeu = new Jeu();

            //Act

            var resultat = jeu.Tour(6, 1);

            //Assert

            if (resultat != Resultat.Gagne) Assert.Fail();
            if (jeu.Heros.Points != 1) Assert.Fail();
            if (jeu.Heros.PointDeVies != 15) Assert.Fail();
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            Jeu jeu = new Jeu();
            //Act
            var resultat = jeu.Tour(5, 5);
            //Assert
            if (resultat != Resultat.Gagne) Assert.Fail();
            if (jeu.Heros.Points != 1) Assert.Fail();
            if (jeu.Heros.PointDeVies != 15) Assert.Fail();
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            Jeu jeu = new Jeu();
            //Act
            var resultat = jeu.Tour(2, 4);
            //Assert
            if (resultat != Resultat.Perdu) Assert.Fail();
            if (jeu.Heros.Points != 0) Assert.Fail();
            if (jeu.Heros.PointDeVies != 13) Assert.Fail();
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            Jeu jeu = new Jeu();

            //Act
            var resultat = jeu.Tour(6, 1);

            //Assert
            if (resultat != Resultat.Perdu) Assert.Fail();
            if (jeu.Heros.Points != 1) Assert.Fail();
            if (jeu.Heros.PointDeVies != 15) Assert.Fail();
        }

        [TestCleanup]
        public void TNettoyageDesTests2()
        {
            //netoyer les variables,...
        }
    }
}