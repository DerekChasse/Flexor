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
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-none")));
        }

        [TestMethod]
        public void GetClass_Auto_Correctly()
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
        public void GetClass_Grow_Correctly()
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
        public void GetClass_Initial_Correctly()
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
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-initial")));
        }

        [TestMethod]
        public void GetClass_NoGrow_Correctly()
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
        public void GetClass_NoShrink_Correctly()
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
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }



        [TestMethod]
        public void OnMobile_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-none")
                .And
                .HaveElementAt(2, "flex-resize-md-none")
                .And
                .HaveElementAt(3, "flex-resize-lg-none")
                .And
                .HaveElementAt(4, "flex-resize-xl-none");
        }

        [TestMethod]
        public void OnMobileAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTablet_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-none")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-none")
                .And
                .HaveElementAt(3, "flex-resize-lg-none")
                .And
                .HaveElementAt(4, "flex-resize-xl-none");
        }

        [TestMethod]
        public void OnTabletAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-none")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTabletAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-none")
                .And
                .HaveElementAt(3, "flex-resize-lg-none")
                .And
                .HaveElementAt(4, "flex-resize-xl-none");
        }

        [TestMethod]
        public void OnDesktop_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-none")
                .And
                .HaveElementAt(1, "flex-resize-sm-none")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-none")
                .And
                .HaveElementAt(4, "flex-resize-xl-none");
        }

        [TestMethod]
        public void OnDesktopAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-none")
                .And
                .HaveElementAt(1, "flex-resize-sm-none")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-none")
                .And
                .HaveElementAt(4, "flex-resize-xl-none");
        }

        [TestMethod]
        public void OnWidescreen_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-none")
                .And
                .HaveElementAt(1, "flex-resize-sm-none")
                .And
                .HaveElementAt(2, "flex-resize-md-none")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-none");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-none")
                .And
                .HaveElementAt(1, "flex-resize-sm-none")
                .And
                .HaveElementAt(2, "flex-resize-md-none")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-none");
        }

        [TestMethod]
        public void OnFullHD_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-none")
                .And
                .HaveElementAt(1, "flex-resize-sm-none")
                .And
                .HaveElementAt(2, "flex-resize-md-none")
                .And
                .HaveElementAt(3, "flex-resize-lg-none")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizability.Is(ResizabilityOption.NoGrow).OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

    }
}
