using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor.Tests
{
    [TestClass]
    public class AlignItemsOptionShould
    {
        [TestMethod]
        public void Operator_Implicit_Baseline_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "baseline";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Baseline.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Baseline_Case_Insensitive_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "baseLINE";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Baseline.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Center_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "center";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Center.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Center_Case_Insensitive_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "cenTER";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Center.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_End_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "end";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.End.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_End_Case_Insensitive_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "End";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.End.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Start_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "start";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Start.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Start_Case_Insensitive_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "stART";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Start.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Stretch_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "stretch";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Stretch.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Stretch_Case_Insensitive_Success()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "strETCH";

            // Assert
            underTest.ToString().Should().Be(AlignItemsOption.Stretch.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Unknown_Fail()
        {
            // Arrange
            AlignItemsOption underTest;

            // Act
            underTest = "UNKNOWN";

            // Assert
            underTest.Should().BeNull();
        }
    }
}
