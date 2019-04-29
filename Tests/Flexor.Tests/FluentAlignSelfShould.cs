using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentAlignSelfShould
    {
        private IAlignSelf underTest;

        [TestMethod]
        public void GetClass_AlignSelf_Auto_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Auto;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-self") && v.EndsWith("-auto")));
        }

        [TestMethod]
        public void GetClass_AlignSelf_Baseline_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Baseline;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-self") && v.EndsWith("-baseline")));
        }

        [TestMethod]
        public void GetClass_AlignSelf_Center_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Center;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-self") && v.EndsWith("-center")));
        }

        [TestMethod]
        public void GetClass_AlignSelf_End_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.End;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-self") && v.EndsWith("-end")));
        }

        [TestMethod]
        public void GetClass_AlignSelf_Start_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Start;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-self") && v.EndsWith("-start")));
        }

        [TestMethod]
        public void GetClass_AlignSelf_Stretch_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Stretch;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-self") && v.EndsWith("-stretch")));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnMobile(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnMobileAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnTablet(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "align-self-sm-start");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnTabletAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnTabletAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnDesktop(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "align-self-md-start");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnDesktopAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnDesktopAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnWidescreen(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "align-self-lg-start");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnWidescreenAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnWidescreenAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnFullHD(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnFullHDAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnMobile_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnMobile(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-stretch")
                .And
                .HaveElementAt(2, "align-self-md-stretch")
                .And
                .HaveElementAt(3, "align-self-lg-stretch")
                .And
                .HaveElementAt(4, "align-self-xl-stretch");
        }

        [TestMethod]
        public void OnMobileAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnMobileAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnTablet_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnTablet(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-stretch")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-stretch")
                .And
                .HaveElementAt(3, "align-self-lg-stretch")
                .And
                .HaveElementAt(4, "align-self-xl-stretch");
        }

        [TestMethod]
        public void OnTabletAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnTabletAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-stretch")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnTabletAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnTabletAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-stretch")
                .And
                .HaveElementAt(3, "align-self-lg-stretch")
                .And
                .HaveElementAt(4, "align-self-xl-stretch");
        }

        [TestMethod]
        public void OnDesktop_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnDesktop(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
               .HaveCount(5)
               .And
               .OnlyHaveUniqueItems()
               .And
               .HaveElementAt(0, "align-self-stretch")
               .And
               .HaveElementAt(1, "align-self-sm-stretch")
               .And
               .HaveElementAt(2, "align-self-md-start")
               .And
               .HaveElementAt(3, "align-self-lg-stretch")
               .And
               .HaveElementAt(4, "align-self-xl-stretch");
        }

        [TestMethod]
        public void OnDesktopAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnDesktopAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
               .HaveCount(5)
               .And
               .OnlyHaveUniqueItems()
               .And
               .HaveElementAt(0, "align-self-stretch")
               .And
               .HaveElementAt(1, "align-self-sm-stretch")
               .And
               .HaveElementAt(2, "align-self-md-start")
               .And
               .HaveElementAt(3, "align-self-lg-start")
               .And
               .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnDesktopAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-self-start")
              .And
              .HaveElementAt(1, "align-self-sm-start")
              .And
              .HaveElementAt(2, "align-self-md-start")
              .And
              .HaveElementAt(3, "align-self-lg-stretch")
              .And
              .HaveElementAt(4, "align-self-xl-stretch");
        }

        [TestMethod]
        public void OnWidescreen_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnWidescreen(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-self-stretch")
              .And
              .HaveElementAt(1, "align-self-sm-stretch")
              .And
              .HaveElementAt(2, "align-self-md-stretch")
              .And
              .HaveElementAt(3, "align-self-lg-start")
              .And
              .HaveElementAt(4, "align-self-xl-stretch");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnWidescreenAndLarger(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-self-stretch")
              .And
              .HaveElementAt(1, "align-self-sm-stretch")
              .And
              .HaveElementAt(2, "align-self-md-stretch")
              .And
              .HaveElementAt(3, "align-self-lg-start")
              .And
              .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnWidescreenAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-self-start")
              .And
              .HaveElementAt(1, "align-self-sm-start")
              .And
              .HaveElementAt(2, "align-self-md-start")
              .And
              .HaveElementAt(3, "align-self-lg-start")
              .And
              .HaveElementAt(4, "align-self-xl-stretch");
        }

        [TestMethod]
        public void OnFullHD_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnFullHD(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-self-stretch")
              .And
              .HaveElementAt(1, "align-self-sm-stretch")
              .And
              .HaveElementAt(2, "align-self-md-stretch")
              .And
              .HaveElementAt(3, "align-self-lg-stretch")
              .And
              .HaveElementAt(4, "align-self-xl-start");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignSelf.Is.OnFullHDAndSmaller(AlignSelfOption.Start);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-self-start")
                .And
                .HaveElementAt(1, "align-self-sm-start")
                .And
                .HaveElementAt(2, "align-self-md-start")
                .And
                .HaveElementAt(3, "align-self-lg-start")
                .And
                .HaveElementAt(4, "align-self-xl-start");
        }


    }
}
