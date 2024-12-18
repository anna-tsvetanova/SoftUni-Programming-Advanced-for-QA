using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class HotelGuestSystemTests
    {
        HotelGuestSystem _hotel;
        [SetUp]
        public void SetUp() 
        {
            this._hotel = new HotelGuestSystem();
        }

        [Test]
        public void Test_Constructor_CheckInitialEmptyGuestCollectionAndCount()
        {
            // Act
            List<string> actualResult = _hotel.GetAllGuests();

            //Assert
            Assert.That(actualResult, Has.Count.EqualTo(0));
            Assert.That(actualResult, Is.Empty);
            Assert.IsNotNull(actualResult);
            Assert.That(_hotel.GuestsCount, Is.EqualTo(0));
        }

        [Test]
        public void Test_RegisterGuest_ValidGuestName_AddNewGuest()
        {
            //Arrange
            string guestName = "Jimmy Choo";
            List<string> expectedResult = new List<string>() { "Jimmy Choo" };
            
            //Act
            _hotel.RegisterGuest(guestName);
            List<string> actualResult = _hotel.GetAllGuests();

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
            Assert.That(actualResult, Has.Count.EqualTo(1));
            Assert.That(actualResult[0], Is.EqualTo(guestName));
        }

        [Test]
        public void Test_RegisterGuest_NullOrEmptyGuestName_ThrowsArgumentException()
        {
            // Arrange
            string nullGuestName = null;
            string emptyGuestName = "";

            //Act and Assert
            Assert.That(() => _hotel.RegisterGuest(nullGuestName), Throws.ArgumentException.With.Message.EqualTo("Guest name cannot be empty or whitespace."));
            Assert.That(() => _hotel.RegisterGuest(emptyGuestName), Throws.ArgumentException.With.Message.EqualTo("Guest name cannot be empty or whitespace."));
            Assert.That(() => _hotel.RegisterGuest(string.Empty), Throws.ArgumentException.With.Message.EqualTo("Guest name cannot be empty or whitespace."));

        }

        [Test]
        public void Test_RemoveGuest_ValidGuestName_RemoveFirstGuestName()
        {
            // Arrange
            List<string> expectedResult = new List<string>() { "Jimmy Choo" };

            // Act
            _hotel.RegisterGuest("Jimmy Choo");
            _hotel.RegisterGuest("Van Dizel");
            _hotel.RemoveGuest("Van Dizel");
            List<string> actualResult = _hotel.GetAllGuests();

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
            Assert.That(actualResult, Has.Count.EqualTo(1));
            Assert.That(actualResult[0], Is.EqualTo("Jimmy Choo"));

        }

        [Test]
        public void Test_RemoveGuest_NullOrEmptyGuestName_ThrowsArgumentException()
        {
            //Arrange
            string nullGuestName = null;
            string emptyGuestName = "";

            //Act and Assert
            Assert.That(() => _hotel.RemoveGuest(nullGuestName), Throws.ArgumentException.With.Message.EqualTo("Guest not found in the system."));
            Assert.That(() => _hotel.RemoveGuest(emptyGuestName), Throws.ArgumentException.With.Message.EqualTo("Guest not found in the system."));

        }

        [Test]
        public void Test_GetAllGuests_RegisteredAndRemovedGuests_ReturnsExpectedGuestCollection()
        {
            // Arrange
            List<string> expectedResult = new List<string>() { "Jimmy Choo" };

            _hotel.RegisterGuest("Jimmy Choo");
            _hotel.RegisterGuest("Van Dizel");
            _hotel.RemoveGuest("Van Dizel");

            // Act
            List<string> actualResult = _hotel.GetAllGuests();

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
            Assert.That(actualResult, Has.Count.EqualTo(1));
            Assert.That(actualResult[0], Is.EqualTo("Jimmy Choo"));



        }
    }
}

