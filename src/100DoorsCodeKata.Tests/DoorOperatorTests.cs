using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace HundredDoorsCodeKata.Tests
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class DoorOperatorTests
    {
        [Test]
        public void DoorOperator_GivenOneDoor_ShouldCreateDoorOperatorWithOneDoor()
        {
            // Arrange
            const int numOfDoors = 1;

            // Act
            var doorOperator = new DoorOperator(numOfDoors);

            // Assert
            Assert.AreEqual(numOfDoors, doorOperator.NumberOfDoors);
        }

        [Test]
        public void DoorOperator_GivenMaxInt_ShouldCreateDoorWithMaxIntDoors()
        {
            // Arrange
            const int numOfDoors = int.MaxValue;

            // Act
            var doorOperator = new DoorOperator(numOfDoors);

            // Assert
            Assert.AreEqual(numOfDoors, doorOperator.NumberOfDoors);
        }

        [TestCase(0)]
        [TestCase(int.MinValue)]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void DoorOperator_GivenInvalidNumberOfDoors_ShouldThrowArgumentOutOfRangeException(int numOfDoors)
        {
            // Arrange
            const string expectedParamName = "numOfDoors";

            // Act
            var actual = Assert.Throws<ArgumentOutOfRangeException>(() => new DoorOperator(numOfDoors));

            // Assert
            Assert.AreEqual(expectedParamName, actual.ParamName);
        }
    }
}