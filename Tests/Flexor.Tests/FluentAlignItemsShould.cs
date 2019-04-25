using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentAlignItemsShould
    {
        private IAlignItems underTest;

        [TestMethod]
        public void Constructor_Default_Stretch()
        {
            // Arrange
            this.underTest = new FluentAlignItems();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-items") && v.EndsWith("-stretch")));
        }

        [TestMethod]
        public void GetClass_AlignItems_Baseline_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Baseline;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-items") && v.EndsWith("-baseline")));
        }

        [TestMethod]
        public void GetClass_AlignItems_Center_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Center;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-items") && v.EndsWith("-center")));
        }

        [TestMethod]
        public void GetClass_AlignItems_End_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.End;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-items") && v.EndsWith("-end")));
        }

        [TestMethod]
        public void GetClass_AlignItems_Start_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Start;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-items") && v.EndsWith("-start")));
        }

        [TestMethod]
        public void GetClass_AlignItems_Stretch_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Stretch;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("align-items") && v.EndsWith("-stretch")));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "align-items-sm-start");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "align-items-md-start");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "align-items-lg-start");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnMobile_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-stretch")
                .And
                .HaveElementAt(2, "align-items-md-stretch")
                .And
                .HaveElementAt(3, "align-items-lg-stretch")
                .And
                .HaveElementAt(4, "align-items-xl-stretch");
        }

        [TestMethod]
        public void OnMobileAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnTablet_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-stretch")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-stretch")
                .And
                .HaveElementAt(3, "align-items-lg-stretch")
                .And
                .HaveElementAt(4, "align-items-xl-stretch");
        }

        [TestMethod]
        public void OnTabletAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-stretch")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnTabletAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-stretch")
                .And
                .HaveElementAt(3, "align-items-lg-stretch")
                .And
                .HaveElementAt(4, "align-items-xl-stretch");
        }

        [TestMethod]
        public void OnDesktop_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
               .HaveCount(5)
               .And
               .OnlyHaveUniqueItems()
               .And
               .HaveElementAt(0, "align-items-stretch")
               .And
               .HaveElementAt(1, "align-items-sm-stretch")
               .And
               .HaveElementAt(2, "align-items-md-start")
               .And
               .HaveElementAt(3, "align-items-lg-stretch")
               .And
               .HaveElementAt(4, "align-items-xl-stretch");
        }

        [TestMethod]
        public void OnDesktopAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
               .HaveCount(5)
               .And
               .OnlyHaveUniqueItems()
               .And
               .HaveElementAt(0, "align-items-stretch")
               .And
               .HaveElementAt(1, "align-items-sm-stretch")
               .And
               .HaveElementAt(2, "align-items-md-start")
               .And
               .HaveElementAt(3, "align-items-lg-start")
               .And
               .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-items-start")
              .And
              .HaveElementAt(1, "align-items-sm-start")
              .And
              .HaveElementAt(2, "align-items-md-start")
              .And
              .HaveElementAt(3, "align-items-lg-stretch")
              .And
              .HaveElementAt(4, "align-items-xl-stretch");
        }

        [TestMethod]
        public void OnWidescreen_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-items-stretch")
              .And
              .HaveElementAt(1, "align-items-sm-stretch")
              .And
              .HaveElementAt(2, "align-items-md-stretch")
              .And
              .HaveElementAt(3, "align-items-lg-start")
              .And
              .HaveElementAt(4, "align-items-xl-stretch");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-items-stretch")
              .And
              .HaveElementAt(1, "align-items-sm-stretch")
              .And
              .HaveElementAt(2, "align-items-md-stretch")
              .And
              .HaveElementAt(3, "align-items-lg-start")
              .And
              .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-items-start")
              .And
              .HaveElementAt(1, "align-items-sm-start")
              .And
              .HaveElementAt(2, "align-items-md-start")
              .And
              .HaveElementAt(3, "align-items-lg-start")
              .And
              .HaveElementAt(4, "align-items-xl-stretch");
        }

        [TestMethod]
        public void OnFullHD_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
              .HaveCount(5)
              .And
              .OnlyHaveUniqueItems()
              .And
              .HaveElementAt(0, "align-items-stretch")
              .And
              .HaveElementAt(1, "align-items-sm-stretch")
              .And
              .HaveElementAt(2, "align-items-md-stretch")
              .And
              .HaveElementAt(3, "align-items-lg-stretch")
              .And
              .HaveElementAt(4, "align-items-xl-start");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = AlignItems.Is(AlignItemsOption.Start).OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "align-items-start")
                .And
                .HaveElementAt(1, "align-items-sm-start")
                .And
                .HaveElementAt(2, "align-items-md-start")
                .And
                .HaveElementAt(3, "align-items-lg-start")
                .And
                .HaveElementAt(4, "align-items-xl-start");
        }
    }
}
