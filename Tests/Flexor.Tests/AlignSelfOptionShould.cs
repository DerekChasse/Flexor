using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor.Tests
{
    [TestClass]
    public class AlignSelfOptionShould
    {
        [TestMethod]
        public void Operator_Implicit_Auto_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "auto";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Auto.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Auto_Case_Insensitive_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "auTO";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Auto.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Baseline_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "baseline";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Baseline.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Baseline_Case_Insensitive_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "baseLINE";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Baseline.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Center_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "center";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Center.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Center_Case_Insensitive_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "cenTER";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Center.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_End_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "end";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.End.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_End_Case_Insensitive_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "End";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.End.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Start_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "start";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Start.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Start_Case_Insensitive_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "stART";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Start.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Stretch_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "stretch";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Stretch.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Stretch_Case_Insensitive_Success()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "strETCH";

            // Assert
            underTest.ToString().Should().Be(AlignSelfOption.Stretch.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Unknown_Fail()
        {
            // Arrange
            AlignSelfOption underTest;

            // Act
            underTest = "UNKNOWN";

            // Assert
            underTest.Should().BeNull();
        }
    }
}
