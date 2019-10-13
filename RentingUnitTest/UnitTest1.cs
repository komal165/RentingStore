using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesAndMusicRenting;

namespace RentingUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Connection()
        {
            // Arrange
            var helper = new NetworkingHelpers();

            // Act
            var actual = helper.Configs();

            // Assert
            Assert.AreEqual(@"Data Source=LAPTOP-GPSG7DIK\SQLEXPRESS; Initial Catalog=rental_store; Integrated Security=True", actual);
        }

        [TestMethod]
        public void Get_Rental_Count()
        {
            // Arrange
            var helper = new NetworkingHelpers();

            // Act
            var actual = helper.GetRentalCount();

            // Assert
            Assert.AreEqual(0, actual);
        }
    }
}
