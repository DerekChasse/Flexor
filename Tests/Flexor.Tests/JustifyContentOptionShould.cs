using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor.Tests
{
    [TestClass]
    public class JustifyContentOptionShould
    {
        [TestMethod]
        public void Operator_Implicit_Center_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "center";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.Center.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Center_Case_Insensitive_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "cenTER";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.Center.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_End_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "end";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.End.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_End_Case_Insensitive_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "End";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.End.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_SpaceAround_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "around";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.SpaceAround.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_SpaceAround_Case_Insensitive_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "aroUND";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.SpaceAround.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_SpaceBetween_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "between";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.SpaceBetween.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_SpaceBetween_Case_Insensitive_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "betWEEN";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.SpaceBetween.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Start_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "start";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.Start.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Start_Case_Insensitive_Success()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "stART";

            // Assert
            underTest.ToString().Should().Be(JustifyContentOption.Start.ToString());
        }
       
        [TestMethod]
        public void Operator_Implicit_Unknown_Fail()
        {
            // Arrange
            JustifyContentOption underTest;

            // Act
            underTest = "UNKNOWN";

            // Assert
            underTest.Should().BeNull();
        }
    }
}
