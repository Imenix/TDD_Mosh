using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Mosh;
namespace TDD_Mosh.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new user { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }
    }
}
