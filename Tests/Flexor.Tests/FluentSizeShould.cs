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
        public void GetClass_IsPixels_Correctly()
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

            underTestCss.Split(Environment.NewLine).Should()
                .HaveCount(5)
                .And
                .Match(lines => lines.All(line => Regex.Matches(line, "50px;").Count == 2));
        }

        [TestMethod]
        public void GetClass_IsPercent_Correctly()
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

            underTestCss.Split(Environment.NewLine).Should()
                .HaveCount(5)
                .And
                .Match(lines => lines.All(line => Regex.Matches(line, "50%;").Count == 2));
        }

        [TestMethod]
        public void GetClass_IsElement_Correctly()
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

            underTestCss.Split(Environment.NewLine).Should()
                .HaveCount(5)
                .And
                .Match(lines => lines.All(line => Regex.Matches(line, "50em;").Count == 2));
        }

        [TestMethod]
        public void GetClass_IsViewportHeight_Correctly()
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

            underTestCss.Split(Environment.NewLine).Should()
                .HaveCount(5)
                .And
                .Match(lines => lines.All(line => Regex.Matches(line, "50vh;").Count == 2));
        }

        [TestMethod]
        public void GetClass_IsViewportWidth_Correctly()
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

            underTestCss.Split(Environment.NewLine).Should()
                .HaveCount(5)
                .And
                .Match(lines => lines.All(line => Regex.Matches(line, "50vw;").Count == 2));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPercent(75).OnMobile();

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

            var lines = underTestCss.Split(Environment.NewLine);
            
            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "75%;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnMobileAndLarger();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsElement(5).OnTablet();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "5em;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnTabletAndLarger();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnTabletAndSmaller();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsElement(75).OnDesktop();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "75em;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnDesktopAndLarger();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnDesktopAndSmaller();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsViewportHeight(75).OnWidescreen();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "75vh;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnWidescreenAndLarger();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnWidescreenAndSmaller();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsViewportWidth(75).OnFullHD();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "50px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "75vw;").Count == 2);
        }

        

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Size.IsPixels(50).OnMobileAndLarger().IsPixels(75).OnFullHDAndSmaller();

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

            var lines = underTestCss.Split(Environment.NewLine);

            lines.Should().HaveCount(5);

            lines[0].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[1].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[2].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[3].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
            lines[4].Should().Match(line => Regex.Matches(line, "75px;").Count == 2);
        }
    }
}
