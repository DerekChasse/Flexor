using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentVisibleShould
    {
        private IVisible underTest;

        [TestMethod]
        public void Constructor_Default_Show()
        {
            // Arrange
            this.underTest = new FluentVisible();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-") && v.EndsWith("-show")));
        }

        [TestMethod]
        public void GetClass_Always_Correcty()
        {
            // Arrange
            this.underTest = Visible.Always;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-") && v.EndsWith("-show")));
        }

        [TestMethod]
        public void GetClass_When_Correcty()
        {
            // Arrange
            this.underTest = Visible.When(false);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-") && v.EndsWith("-hide")));
        }

        [TestMethod]
        public void And_Chains_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnMobile().And.OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-show")
                .And
                .HaveElementAt(1, "flex-sm-hide")
                .And
                .HaveElementAt(2, "flex-md-show")
                .And
                .HaveElementAt(3, "flex-lg-hide")
                .And
                .HaveElementAt(4, "flex-xl-hide");
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-show");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-show")
                .And
                .HaveElementAt(1, "flex-sm-show")
                .And
                .HaveElementAt(2, "flex-md-show")
                .And
                .HaveElementAt(3, "flex-lg-show")
                .And
                .HaveElementAt(4, "flex-xl-show");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-sm-show");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-hide")
                .And
                .HaveElementAt(1, "flex-sm-show")
                .And
                .HaveElementAt(2, "flex-md-show")
                .And
                .HaveElementAt(3, "flex-lg-show")
                .And
                .HaveElementAt(4, "flex-xl-show");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-show")
                .And
                .HaveElementAt(1, "flex-sm-show")
                .And
                .HaveElementAt(2, "flex-md-hide")
                .And
                .HaveElementAt(3, "flex-lg-hide")
                .And
                .HaveElementAt(4, "flex-xl-hide");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-md-show");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-hide")
                .And
                .HaveElementAt(1, "flex-sm-hide")
                .And
                .HaveElementAt(2, "flex-md-show")
                .And
                .HaveElementAt(3, "flex-lg-show")
                .And
                .HaveElementAt(4, "flex-xl-show");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-show")
                .And
                .HaveElementAt(1, "flex-sm-show")
                .And
                .HaveElementAt(2, "flex-md-show")
                .And
                .HaveElementAt(3, "flex-lg-hide")
                .And
                .HaveElementAt(4, "flex-xl-hide");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-lg-show");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-hide")
                .And
                .HaveElementAt(1, "flex-sm-hide")
                .And
                .HaveElementAt(2, "flex-md-hide")
                .And
                .HaveElementAt(3, "flex-lg-show")
                .And
                .HaveElementAt(4, "flex-xl-show");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-show")
                .And
                .HaveElementAt(1, "flex-sm-show")
                .And
                .HaveElementAt(2, "flex-md-show")
                .And
                .HaveElementAt(3, "flex-lg-show")
                .And
                .HaveElementAt(4, "flex-xl-hide");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-xl-show");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Visible.Only.OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-show")
                .And
                .HaveElementAt(1, "flex-sm-show")
                .And
                .HaveElementAt(2, "flex-md-show")
                .And
                .HaveElementAt(3, "flex-lg-show")
                .And
                .HaveElementAt(4, "flex-xl-show");
        }




    }
}
