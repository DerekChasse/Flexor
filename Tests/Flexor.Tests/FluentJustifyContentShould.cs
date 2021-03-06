﻿using FluentAssertions;
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
        public void GetClass_Center_Correctly()
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
        public void GetClass_End_Correctly()
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
        public void GetClass_Start_Correctly()
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
        public void GetClass_SpaceAround_Correctly()
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
        public void GetClass_SpaceBetween_Correctly()
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
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnMobile(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "justify-content-center");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnMobileAndLarger(JustifyContentOption.Center);

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
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnTablet(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "justify-content-sm-center");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnTabletAndLarger(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "justify-content-sm-center")
                .And
                .HaveElementAt(2, "justify-content-md-center")
                .And
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnTabletAndSmaller(JustifyContentOption.Center);

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
                .HaveElementAt(1, "justify-content-sm-center");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnDesktop(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "justify-content-md-center");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnDesktopAndLarger(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "justify-content-md-center")
                .And
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnDesktopAndSmaller(JustifyContentOption.Center);

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
                .HaveElementAt(2, "justify-content-md-center");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnWidescreen(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "justify-content-lg-center");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnWidescreenAndLarger(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnWidescreenAndSmaller(JustifyContentOption.Center);

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
                .HaveElementAt(3, "justify-content-lg-center");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnFullHD(JustifyContentOption.Center);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnFullHDAndSmaller(JustifyContentOption.Center);

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
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }





        [TestMethod]
        public void OnMobile_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnMobile(JustifyContentOption.Center);

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
        public void OnMobileAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnMobileAndLarger(JustifyContentOption.Center);

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
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnTablet_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnTablet(JustifyContentOption.Center);

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
                .HaveElementAt(1, "justify-content-sm-center")
                .And
                .HaveElementAt(2, "justify-content-md-start")
                .And
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnTabletAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnTabletAndLarger(JustifyContentOption.Center);

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
                .HaveElementAt(1, "justify-content-sm-center")
                .And
                .HaveElementAt(2, "justify-content-md-center")
                .And
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }

        [TestMethod]
        public void OnTabletAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnTabletAndSmaller(JustifyContentOption.Center);

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
        public void OnDesktop_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnDesktop(JustifyContentOption.Center);

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
                .HaveElementAt(3, "justify-content-lg-start")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnDesktopAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnDesktopAndLarger(JustifyContentOption.Center);

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
        public void OnDesktopAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnDesktopAndSmaller(JustifyContentOption.Center);

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
        public void OnWidescreen_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnWidescreen(JustifyContentOption.Center);

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
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnWidescreenAndLarger(JustifyContentOption.Center);

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
        public void OnWidescreenAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnWidescreenAndSmaller(JustifyContentOption.Center);

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
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-start");
        }

        [TestMethod]
        public void OnFullHD_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnFullHD(JustifyContentOption.Center);

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
        public void OnFullHDAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = JustifyContent.Is.OnFullHDAndSmaller(JustifyContentOption.Center);

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
                .HaveElementAt(3, "justify-content-lg-center")
                .And
                .HaveElementAt(4, "justify-content-xl-center");
        }
    }
}
