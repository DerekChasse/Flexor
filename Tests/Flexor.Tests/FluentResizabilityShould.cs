using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentResizabilityShould
    {
        private IResizability underTest;

        [TestMethod]
        public void Constructor_Default_Auto()
        {
            // Arrange
            this.underTest = new FluentResizability();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-auto")));
        }

        [TestMethod]
        public void GetClass_Auto_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Auto;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-auto")));
        }

        [TestMethod]
        public void GetClass_Grow_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Grow;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-grow")));
        }

        [TestMethod]
        public void GetClass_Initial_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Initial;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-none")));
        }

        [TestMethod]
        public void GetClass_NoGrow_Correcty()
        {
            // Arrange
            this.underTest = Resizability.NoGrow;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-nogrow")));
        }

        [TestMethod]
        public void GetClass_NoShrink_Correcty()
        {
            // Arrange
            this.underTest = Resizability.NoShrink;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-noshrink")));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-grow");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-grow")
                .And
                .HaveElementAt(1, "flex-resize-sm-grow")
                .And
                .HaveElementAt(2, "flex-resize-md-grow")
                .And
                .HaveElementAt(3, "flex-resize-lg-grow")
                .And
                .HaveElementAt(4, "flex-resize-xl-grow");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-resize-sm-grow");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-auto")
                .And
                .HaveElementAt(1, "flex-resize-sm-grow")
                .And
                .HaveElementAt(2, "flex-resize-md-grow")
                .And
                .HaveElementAt(3, "flex-resize-lg-grow")
                .And
                .HaveElementAt(4, "flex-resize-xl-grow");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-grow")
                .And
                .HaveElementAt(1, "flex-resize-sm-grow")
                .And
                .HaveElementAt(2, "flex-resize-md-auto")
                .And
                .HaveElementAt(3, "flex-resize-lg-auto")
                .And
                .HaveElementAt(4, "flex-resize-xl-auto");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-resize-md-grow");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-auto")
                .And
                .HaveElementAt(1, "flex-resize-sm-auto")
                .And
                .HaveElementAt(2, "flex-resize-md-grow")
                .And
                .HaveElementAt(3, "flex-resize-lg-grow")
                .And
                .HaveElementAt(4, "flex-resize-xl-grow");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-grow")
                .And
                .HaveElementAt(1, "flex-resize-sm-grow")
                .And
                .HaveElementAt(2, "flex-resize-md-grow")
                .And
                .HaveElementAt(3, "flex-resize-lg-auto")
                .And
                .HaveElementAt(4, "flex-resize-xl-auto");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-resize-lg-grow");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-auto")
                .And
                .HaveElementAt(1, "flex-resize-sm-auto")
                .And
                .HaveElementAt(2, "flex-resize-md-auto")
                .And
                .HaveElementAt(3, "flex-resize-lg-grow")
                .And
                .HaveElementAt(4, "flex-resize-xl-grow");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-grow")
                .And
                .HaveElementAt(1, "flex-resize-sm-grow")
                .And
                .HaveElementAt(2, "flex-resize-md-grow")
                .And
                .HaveElementAt(3, "flex-resize-lg-grow")
                .And
                .HaveElementAt(4, "flex-resize-xl-auto");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-resize-xl-grow");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.Auto).OnMobileAndLarger().CanGrow().OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-grow")
                .And
                .HaveElementAt(1, "flex-resize-sm-grow")
                .And
                .HaveElementAt(2, "flex-resize-md-grow")
                .And
                .HaveElementAt(3, "flex-resize-lg-grow")
                .And
                .HaveElementAt(4, "flex-resize-xl-grow");
        }
    }
}
