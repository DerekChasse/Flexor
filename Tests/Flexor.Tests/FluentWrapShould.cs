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
            this.underTest = Wrap.Is.OnMobile(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnMobileAndLarger(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnTablet(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnTabletAndLarger(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnTabletAndSmaller(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnDesktop(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnDesktopAndLarger(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnDesktopAndSmaller(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnWidescreen(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnWidescreenAndLarger(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnWidescreenAndSmaller(WrapOption.WrapReverse);

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
                .HaveElementAt(3, "flex-lg-wrap-reverse");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnFullHD(WrapOption.WrapReverse);

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
            this.underTest = Wrap.Is.OnFullHDAndSmaller(WrapOption.WrapReverse);

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
        public void OnMobile_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnMobile(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-sm-nowrap")
                .And
                .HaveElementAt(2, "flex-md-nowrap")
                .And
                .HaveElementAt(3, "flex-lg-nowrap")
                .And
                .HaveElementAt(4, "flex-xl-nowrap");
        }

        [TestMethod]
        public void OnMobileAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnMobileAndLarger(WrapOption.WrapReverse);

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
        public void OnTablet_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnTablet(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-nowrap")
                .And
                .HaveElementAt(2, "flex-md-nowrap")
                .And
                .HaveElementAt(3, "flex-lg-nowrap")
                .And
                .HaveElementAt(4, "flex-xl-nowrap");
        }

        [TestMethod]
        public void OnTabletAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnTabletAndLarger(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-nowrap");
        }

        [TestMethod]
        public void OnTabletAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnTabletAndSmaller(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-md-nowrap")
                .And
                .HaveElementAt(3, "flex-lg-nowrap")
                .And
                .HaveElementAt(4, "flex-xl-nowrap");
        }

        [TestMethod]
        public void OnDesktop_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnDesktop(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-nowrap")
                .And
                .HaveElementAt(1, "flex-sm-nowrap")
                .And
                .HaveElementAt(3, "flex-lg-nowrap")
                .And
                .HaveElementAt(4, "flex-xl-nowrap");
        }

        [TestMethod]
        public void OnDesktopAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnDesktopAndLarger(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-nowrap")
                .And
                .HaveElementAt(1, "flex-sm-nowrap");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnDesktopAndSmaller(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-lg-nowrap")
                .And
                .HaveElementAt(4, "flex-xl-nowrap");
        }

        [TestMethod]
        public void OnWidescreen_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnWidescreen(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-nowrap")
                .And
                .HaveElementAt(1, "flex-sm-nowrap")
                .And
                .HaveElementAt(2, "flex-md-nowrap")
                .And
                .HaveElementAt(4, "flex-xl-nowrap");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnWidescreenAndLarger(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-nowrap")
                .And
                .HaveElementAt(1, "flex-sm-nowrap")
                .And
                .HaveElementAt(2, "flex-md-nowrap");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnWidescreenAndSmaller(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-xl-nowrap");
        }

        [TestMethod]
        public void OnFullHD_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnFullHD(WrapOption.WrapReverse);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-nowrap")
                .And
                .HaveElementAt(1, "flex-sm-nowrap")
                .And
                .HaveElementAt(2, "flex-md-nowrap")
                .And
                .HaveElementAt(3, "flex-lg-nowrap");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Wrap.Is.OnFullHDAndSmaller(WrapOption.WrapReverse);

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
