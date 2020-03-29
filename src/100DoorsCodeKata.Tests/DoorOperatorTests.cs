using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace HundredDoorsCodeKata.Tests
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class DoorOperatorTests
    {
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

        [Test]
        public void DoorOperator_GivenOneDoor_ShouldCreateDoorOperatorWithOneDoor()
        {
            // Arrange
            const int numOfDoors = 1;

            // Act
            var doorOperator = new DoorOperator(numOfDoors);

            // Assert
            Assert.AreEqual(numOfDoors, doorOperator.Doors.Count);
        }

        [Test]
        public void DoorOperator_GivenOneHundredDoors_ShouldCreateDoorWithOneHundredDoors()
        {
            // Arrange
            const int numOfDoors = 100;

            // Act
            var doorOperator = new DoorOperator(numOfDoors);

            // Assert
            Assert.AreEqual(numOfDoors, doorOperator.Doors.Count);
        }

        [Test]
        public void Operate_GivenOneDoorAndOnePass_ShouldOpenTheDoor()
        {
            // Arrange
            const string expectedDoorString = "@";

            const int numOfDoors = 1;
            const int numOfPasses = 1;
            var doorOperator = new DoorOperator(numOfDoors);

            // Act
            var actualDoorString = doorOperator.Operate(numOfPasses);

            // Assert
            Assert.AreEqual(expectedDoorString, actualDoorString);
        }

        [Test]
        public void Operate_GivenSixDoorsAndOnePass_ShouldOpenAllDoors()
        {
            // Arrange
            const string expectedDoorString = "@@@@@@";

            const int numOfDoors = 6;
            const int numOfPasses = 1;
            var doorOperator = new DoorOperator(numOfDoors);

            // Act
            var actualDoorString = doorOperator.Operate(numOfPasses);

            // Assert
            Assert.AreEqual(expectedDoorString, actualDoorString);
        }

        [Test]
        public void Operate_GivenSixDoorsAndTwoPasses_ShouldToggleAllTheDoorStates()
        {
            // Arrange
            const string expectedDoorString = "@#@#@#";

            const int numOfDoors = 6;
            const int numOfPasses = 2;
            var doorOperator = new DoorOperator(numOfDoors);

            // Act
            var actualDoorString = doorOperator.Operate(numOfPasses);

            // Assert
            Assert.AreEqual(expectedDoorString, actualDoorString);
        }

        [Test]
        public void Operate_GivenSixDoorsAndThreePasses_ShouldToggleTheDoorsStates()
        {
            // Arrange
            const string expectedDoorString = "@###@@";

            const int numOfDoors = 6;
            const int numOfPasses = 3;
            var doorOperator = new DoorOperator(numOfDoors);

            // Act
            var actualDoorString = doorOperator.Operate(numOfPasses);

            // Assert
            Assert.AreEqual(expectedDoorString, actualDoorString);
        }

        [Test]
        public void Operate_GivenSixDoorsAndFourPasses_ShouldToggleTheDoorsStates()
        {
            // Arrange
            const string expectedDoorString = "@##@@@";

            const int numOfDoors = 6;
            const int numOfPasses = 4;
            var doorOperator = new DoorOperator(numOfDoors);

            // Act
            var actualDoorString = doorOperator.Operate(numOfPasses);

            // Assert
            Assert.AreEqual(expectedDoorString, actualDoorString);
        }
        
        [Test]
        public void Operate_GivenSixDoorsAndFivePasses_ShouldToggleTheDoorsStates()
        {
            // Arrange
            const string expectedDoorString = "@##@#@";

            const int numOfDoors = 6;
            const int numOfPasses = 5;
            var doorOperator = new DoorOperator(numOfDoors);

            // Act
            var actualDoorString = doorOperator.Operate(numOfPasses);

            // Assert
            Assert.AreEqual(expectedDoorString, actualDoorString);
        }
        
        [Test]
        public void Operate_GivenSixDoorsAndSixPasses_ShouldToggleTheDoorsStates()
        {
            // Arrange
            const string expectedDoorString = "@##@##";

            const int numOfDoors = 6;
            const int numOfPasses = 6;
            var doorOperator = new DoorOperator(numOfDoors);

            // Act
            var actualDoorString = doorOperator.Operate(numOfPasses);

            // Assert
            Assert.AreEqual(expectedDoorString, actualDoorString);
        }
    }
}