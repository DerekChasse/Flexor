using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor.Tests
{
    [TestClass]
    public class DirectionOptionShould
    {
        [TestMethod]
        public void Operator_Implicit_Column_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "column";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.Column.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Column_Case_Insensitive_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "colUMN";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.Column.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_ColumnReverse_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "column-reverse";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.ColumnReverse.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_ColumnReverse_Case_Insensitive_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "column-REVERSE";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.ColumnReverse.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Row_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "row";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.Row.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Row_Case_Insensitive_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "Row";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.Row.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_RowReverse_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "row-reverse";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.RowReverse.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_RowReverse_Case_Insensitive_Success()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "row-REVERSE";

            // Assert
            underTest.ToString().Should().Be(DirectionOption.RowReverse.ToString());
        }

        [TestMethod]
        public void Operator_Implicit_Unknown_Fail()
        {
            // Arrange
            DirectionOption underTest;

            // Act
            underTest = "UNKNOWN";

            // Assert
            underTest.Should().BeNull();
        }
    }
}
