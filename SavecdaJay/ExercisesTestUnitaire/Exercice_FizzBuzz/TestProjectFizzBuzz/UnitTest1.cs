namespace TestProjectFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTestFizzBuzz
        {
            [TestMethod]
            public void Given_nombre_When_FizzBuzzPourUnNombre_Then_Return_Nombre_String()
            {
                //Arrange
                string retour;
                int nombre = 1;
                //Act
                retour = MonBuzzFizz.Fizz.FizzBuzzPourUnNombre(nombre);
                //Assert
                Assert.AreEqual("1", retour);
            }

            [TestMethod]
            public void Given_nombre_3_When_FizzBuzzPourUnNombre_Then_Return_Fizz_String()
            {
                //Arrange
                string retour;
                int nombre = 3;
                //Act
                retour = MonBuzzFizz.Fizz.FizzBuzzPourUnNombre(nombre);
                //Assert
                Assert.AreEqual("Fizz", retour);
            }

            [TestMethod]
            public void Given_nombre_6_When_FizzBuzzPourUnNombre_Then_Return_Fizz_String()
            {
                //Arrange
                string retour;
                int nombre = 6;
                //Act
                retour = MonBuzzFizz.Fizz.FizzBuzzPourUnNombre(nombre);
                //Assert
                Assert.AreEqual("Fizz", retour);
            }
            [TestMethod]
            public void Given_nombre_5_FizzBuzzPourUnNombre_Then_Return_Buzz_String() 
            {
                //Arrange
                string retour;
                int nombre = 5;
                //Act
                retour = MonBuzzFizz.Fizz.FizzBuzzPourUnNombre(nombre);
                //Assert
                Assert.AreEqual("Buzz", retour);
            }
            [TestMethod]
            public void Given_nombre_10_FizzBuuzzPourUnNombre_Then_Return_Buzz_String() 
            {
                //Arrange
                string retour;
                int nombre = 10;
                //Act
                retour = MonBuzzFizz.Fizz.FizzBuzzPourUnNombre(nombre);
                //Assert
                Assert.AreEqual("Buzz", retour);
            }
            [TestMethod]
            public void Given_nombre_15_FizzBuuzzPourUnNombre_Then_Return_BuzzFizz_String() 
            {
                //Arrange
                string retour;
                int nombre = 15;
                //Act
                retour = MonBuzzFizz.Fizz.FizzBuzzPourUnNombre(nombre);
                //Assert
                Assert.AreEqual("BuzzFizz", retour);
            }
            [TestMethod]
            public void Given_nombre_30_FizzBuuzzPourUnNombre_Then_Return_BuzzFizz_String() 
            {
                //Arrange
                string retour;
                int nombre = 30;
                //Act
                retour = MonBuzzFizz.Fizz.FizzBuzzPourUnNombre(nombre);
                //Assert
                Assert.AreEqual("BuzzFizz", retour);
            }
        }
    }
}