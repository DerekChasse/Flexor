using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flexor.Tests
{
    [TestClass]
    public class OrderOptionShould
    {
        [TestMethod]
        public void Operator_Implicit_First_Success()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = "first";

            // Assert
            underTest.ToString().Should().Be(OrderOption.First.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_First_Case_Insensitive_Success()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = "firST";

            // Assert
            underTest.ToString().Should().Be(OrderOption.First.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Last_Success()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = "last";

            // Assert
            underTest.ToString().Should().Be(OrderOption.Last.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Last_Case_Insensitive_Success()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = "laST";

            // Assert
            underTest.ToString().Should().Be(OrderOption.Last.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_In_Range_Success()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = 6;

            // Assert
            underTest.ToString().Should().Be("6");
        }

        [TestMethod]
        public void Operator_Implicit_Below_Range_Fail()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = -2;

            // Assert
            underTest.Should().BeNull();
        }

        [TestMethod]
        public void Operator_Implicit_Above_Range_Fail()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = 20;

            // Assert
            underTest.Should().BeNull();
        }

        [TestMethod]
        public void Operator_Implicit_Unknown_Fail()
        {
            // Arrange
            OrderOption underTest;

            // Act
            underTest = "UNKNOWN";

            // Assert
            underTest.Should().BeNull();
        }
    }
}
