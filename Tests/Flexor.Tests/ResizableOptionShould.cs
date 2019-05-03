using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flexor.Tests
{
    [TestClass]
    public class ResizableOptionShould
    {
        [TestMethod]
        public void Operator_Implicit_Default_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "unset";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Default.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Default_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "unSET";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Default.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Auto_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "auto";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Auto.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Auto_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "auTO";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Auto.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Initial_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "initial";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Initial.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Initial_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "iniTIAL";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Initial.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_None_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "none";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.None.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_None_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "noNE";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.None.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Fill_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "fill";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Fill.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Fill_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "fiLL";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Fill.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Grow_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "grow";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Grow.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Grow_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "grOW";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.Grow.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_NoGrow_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "nogrow";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.NoGrow.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_NoGrow_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "noGROW";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.NoGrow.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_NoShrink_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "noshrink";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.NoShrink.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_NoShrink_Case_Insensitive_Success()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "noSHRINK";

            // Assert
            underTest.ToString().Should().Be(ResizableOption.NoShrink.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Unknown_Fail()
        {
            // Arrange
            ResizableOption underTest;

            // Act
            underTest = "UNKNOWN";

            // Assert
            underTest.Should().BeNull();
        }
    }
}
