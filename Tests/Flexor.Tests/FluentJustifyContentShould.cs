using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentJustifyContentShould
    {
        private IJustifyContent underTest;

        [TestMethod]
        public void Constructor_Default_Start()
        {
            // Arrange
            this.underTest = new FluentJustifyContent();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("justify-content") && v.EndsWith("-start")));
        }

        [TestMethod]
        public void GetClass_Center_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Center;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("justify-content") && v.EndsWith("-center")));
        }

        [TestMethod]
        public void GetClass_End_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.End;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("justify-content") && v.EndsWith("-end")));
        }

        [TestMethod]
        public void GetClass_Start_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Start;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("justify-content") && v.EndsWith("-start")));
        }

        [TestMethod]
        public void GetClass_SpaceAround_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.SpaceAround;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("justify-content") && v.EndsWith("-around")));
        }

        [TestMethod]
        public void GetClass_SpaceBetween_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.SpaceBetween;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("justify-content") && v.EndsWith("-between")));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-start");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-start")
                .And
                .HaveElementAt(1, "justify-content-sm-start")
                .And
                .HaveElementAt(2, "justify-content-md-start")
                .And
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "justify-content-sm-start");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-center")
                .And
                .HaveElementAt(1, "justify-content-sm-start")
                .And
                .HaveElementAt(2, "justify-content-md-start")
                .And
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-start")
                .And
                .HaveElementAt(1, "justify-content-sm-start")
                .And
                .HaveElementAt(2, "justify-content-md-center")
                .And
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "justify-content-md-start");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-center")
                .And
                .HaveElementAt(1, "justify-content-sm-center")
                .And
                .HaveElementAt(2, "justify-content-md-start")
                .And
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-start")
                .And
                .HaveElementAt(1, "justify-content-sm-start")
                .And
                .HaveElementAt(2, "justify-content-md-start")
                .And
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "justify-content-lg-start");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-center")
                .And
                .HaveElementAt(1, "justify-content-sm-center")
                .And
                .HaveElementAt(2, "justify-content-md-center")
                .And
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-start")
                .And
                .HaveElementAt(1, "justify-content-sm-start")
                .And
                .HaveElementAt(2, "justify-content-md-start")
                .And
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = JustifyContent.Is(JustificationOption.Center).OnMobileAndLarger().Is(JustificationOption.Start).OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-start")
                .And
                .HaveElementAt(1, "justify-content-sm-start")
                .And
                .HaveElementAt(2, "justify-content-md-start")
                .And
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }
    }
}
