using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentSizeShould
    {
        private ISize underTest;

        [TestMethod]
        public void Constructor_Default_Null()
        {
            // Arrange
            this.underTest = new FluentSize();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().BeNullOrWhiteSpace();
        }

        [TestMethod]
        public void GetClass_IsPixels_Correcty()
        {
            // Arrange
            this.underTest = Size.IsPixels(50);

            // Act
            var underTestClass = underTest.Class;
            var underTestCss = underTest.Css;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems();

            underTestCss.Should().NotBeNullOrWhiteSpace();

            Regex.Matches(underTestCss, "50px").Count.Should().Be(10);
        }

        [TestMethod]
        public void GetClass_IsPercent_Correcty()
        {
            // Arrange
            this.underTest = Size.IsPercent(50);

            // Act
            var underTestClass = underTest.Class;
            var underTestCss = underTest.Css;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems();

            underTestCss.Should().NotBeNullOrWhiteSpace();

            Regex.Matches(underTestCss, "50%").Count.Should().Be(10);
        }

        [TestMethod]
        public void GetClass_IsElement_Correcty()
        {
            // Arrange
            this.underTest = Size.IsElement(50);

            // Act
            var underTestClass = underTest.Class;
            var underTestCss = underTest.Css;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems();

            underTestCss.Should().NotBeNullOrWhiteSpace();

            Regex.Matches(underTestCss, "50em").Count.Should().Be(10);
        }

        [TestMethod]
        public void GetClass_IsViewportHeight_Correcty()
        {
            // Arrange
            this.underTest = Size.IsViewportHeight(50);

            // Act
            var underTestClass = underTest.Class;
            var underTestCss = underTest.Css;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems();

            underTestCss.Should().NotBeNullOrWhiteSpace();

            Regex.Matches(underTestCss, "50vh").Count.Should().Be(10);
        }

        [TestMethod]
        public void GetClass_IsViewportWidth_Correcty()
        {
            // Arrange
            this.underTest = Size.IsViewportWidth(50);

            // Act
            var underTestClass = underTest.Class;
            var underTestCss = underTest.Css;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems();

            underTestCss.Should().NotBeNullOrWhiteSpace();

            Regex.Matches(underTestCss, "50vw").Count.Should().Be(10);
        }
    }
}
