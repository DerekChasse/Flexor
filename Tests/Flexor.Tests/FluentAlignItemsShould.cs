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
        public void GetClass_ItemAlignment_Baseline_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Baseline;

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
        public void GetClass_ItemAlignment_Center_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Center;

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
        public void GetClass_ItemAlignment_End_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.End;

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
        public void GetClass_ItemAlignment_Start_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Start;

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
        public void GetClass_ItemAlignment_Stretch_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Stretch;

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
        public void GetClass_SelfAlignment_Baseline_Correctly()
        {
            // Arrange
            this.underTest = SelfAlignment.Baseline;

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
        public void GetClass_SelfAlignment_Center_Correctly()
        {
            // Arrange
            this.underTest = SelfAlignment.Center;

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
        public void GetClass_SelfAlignment_End_Correctly()
        {
            // Arrange
            this.underTest = SelfAlignment.End;

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
        public void GetClass_SelfAlignment_Start_Correctly()
        {
            // Arrange
            this.underTest = SelfAlignment.Start;

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
        public void GetClass_SelfAlignment_Stretch_Correctly()
        {
            // Arrange
            this.underTest = SelfAlignment.Stretch;

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
        public void GetClass_SelfAlignment_Is_Stretch_Correctly()
        {
            // Arrange
            this.underTest = SelfAlignment.Is(ItemAlignmentOption.Stretch);

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
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnMobile();

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
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnMobileAndLarger();

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
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnTablet();

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
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnTabletAndLarger();

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
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnTabletAndSmaller();

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
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnDesktop();

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
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnDesktopAndLarger();

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
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnDesktopAndSmaller();

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
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnWidescreen();

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
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnWidescreenAndLarger();

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
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnWidescreenAndSmaller();

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
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnFullHD();

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
            this.underTest = ItemAlignment.Is(ItemAlignmentOption.Stretch).OnMobileAndLarger().Is(ItemAlignmentOption.Start).OnFullHDAndSmaller();

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
