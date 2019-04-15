using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentWrapShould
    {
        private IWrap underTest;

        [TestMethod]
        public void Constructor_Default_NoWrap()
        {
            // Arrange
            this.underTest = new FluentWrap();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-nowrap")));
        }

        [TestMethod]
        public void GetClass_Wrap_Correctly()
        {
            // Arrange
            this.underTest = Wrap.CanWrap;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-wrap")));
        }

        [TestMethod]
        public void GetClass_NoWrap_Correctly()
        {
            // Arrange
            this.underTest = Wrap.NoWrap;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-nowrap")));
        }

        [TestMethod]
        public void GetClass_RowReverse_Correctly()
        {
            // Arrange
            this.underTest = Wrap.WrapReverse;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-wrap-reverse")));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-wrap-reverse");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-wrap-reverse")
                .And
                .HaveElementAt(1, "flex-sm-wrap-reverse")
                .And
                .HaveElementAt(2, "flex-md-wrap-reverse")
                .And
                .HaveElementAt(3, "flex-lg-wrap-reverse")
                .And
                .HaveElementAt(4, "flex-xl-wrap-reverse");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-sm-wrap-reverse");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-sm-wrap-reverse")
                .And
                .HaveElementAt(2, "flex-md-wrap-reverse")
                .And
                .HaveElementAt(3, "flex-lg-wrap-reverse")
                .And
                .HaveElementAt(4, "flex-xl-wrap-reverse");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-wrap-reverse")
                .And
                .HaveElementAt(1, "flex-sm-wrap-reverse");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-md-wrap-reverse");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-md-wrap-reverse")
                .And
                .HaveElementAt(3, "flex-lg-wrap-reverse")
                .And
                .HaveElementAt(4, "flex-xl-wrap-reverse");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-wrap-reverse")
                .And
                .HaveElementAt(1, "flex-sm-wrap-reverse")
                .And
                .HaveElementAt(2, "flex-md-wrap-reverse");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-lg-wrap-reverse");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-lg-wrap-reverse")
                .And
                .HaveElementAt(4, "flex-xl-wrap-reverse");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-wrap-reverse")
                .And
                .HaveElementAt(1, "flex-sm-wrap-reverse")
                .And
                .HaveElementAt(2, "flex-md-wrap-reverse")
                .And
                .HaveElementAt(3, "flex-lg-wrap-reverse";
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-xl-wrap-reverse");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is(WrapOption.NoWrap).OnMobileAndLarger().Is(WrapOption.WrapReverse).OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-wrap-reverse")
                .And
                .HaveElementAt(1, "flex-sm-wrap-reverse")
                .And
                .HaveElementAt(2, "flex-md-wrap-reverse")
                .And
                .HaveElementAt(3, "flex-lg-wrap-reverse")
                .And
                .HaveElementAt(4, "flex-xl-wrap-reverse");
        }
    }
}
