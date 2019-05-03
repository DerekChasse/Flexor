using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flexor.Tests
{
    [TestClass]
    public class WrapOptionShould
    {
        [TestMethod]
        public void Operator_Implicit_NoWrap_Success()
        {
            // Arrange
            WrapOption underTest;

            // Act
            underTest = "nowrap";

            // Assert
            underTest.ToString().Should().Be(WrapOption.NoWrap.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_NoWrap_Case_Insensitive_Success()
        {
            // Arrange
            WrapOption underTest;

            // Act
            underTest = "noWRAP";

            // Assert
            underTest.ToString().Should().Be(WrapOption.NoWrap.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Wrap_Success()
        {
            // Arrange
            WrapOption underTest;

            // Act
            underTest = "wrap";

            // Assert
            underTest.ToString().Should().Be(WrapOption.Wrap.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Wrap_Case_Insensitive_Success()
        {
            // Arrange
            WrapOption underTest;

            // Act
            underTest = "wrAP";

            // Assert
            underTest.ToString().Should().Be(WrapOption.Wrap.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_WrapReverse_Success()
        {
            // Arrange
            WrapOption underTest;

            // Act
            underTest = "wrap-reverse";

            // Assert
            underTest.ToString().Should().Be(WrapOption.WrapReverse.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_WrapReverse_Case_Insensitive_Success()
        {
            // Arrange
            WrapOption underTest;

            // Act
            underTest = "wrap-REVERSE";

            // Assert
            underTest.ToString().Should().Be(WrapOption.WrapReverse.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Unknown_Fail()
        {
            // Arrange
            WrapOption underTest;

            // Act
            underTest = "UNKNOWN";

            // Assert
            underTest.Should().BeNull();
        }
    }
}
