using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentDirectionShould
    {
        private IDirection underTest;

        [TestMethod]
        public void Constructor_Default_Row()
        {
            // Arrange
            this.underTest = new FluentDirection();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-row")));
        }

        [TestMethod]
        public void GetClass_Row_Correctly()
        {
            // Arrange
            this.underTest = Direction.Row;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-row")));
        }

        [TestMethod]
        public void GetClass_Column_Correctly()
        {
            // Arrange
            this.underTest = Direction.Column;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-column")));
        }

        [TestMethod]
        public void GetClass_RowReverse_Correctly()
        {
            // Arrange
            this.underTest = Direction.RowReverse;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-row-reverse")));
        }

        [TestMethod]
        public void GetClass_ColumnReverse_Correctly()
        {
            // Arrange
            this.underTest = Direction.ColumnReverse;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex") && v.EndsWith("-column-reverse")));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnMobile(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnMobileAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnTablet(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-sm-column");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnTabletAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnTabletAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnDesktop(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-md-column");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnDesktopAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnDesktopAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnWidescreen(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-lg-column");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnWidescreenAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnWidescreenAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnFullHD(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnFullHDAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }



        [TestMethod]
        public void OnMobile_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnMobile(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-row")
                .And
                .HaveElementAt(2, "flex-md-row")
                .And
                .HaveElementAt(3, "flex-lg-row")
                .And
                .HaveElementAt(4, "flex-xl-row");
        }

        [TestMethod]
        public void OnMobileAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnMobileAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnTablet_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnTablet(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-row")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-row")
                .And
                .HaveElementAt(3, "flex-lg-row")
                .And
                .HaveElementAt(4, "flex-xl-row");
        }

        [TestMethod]
        public void OnTabletAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnTabletAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-row")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnTabletAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnTabletAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-row")
                .And
                .HaveElementAt(3, "flex-lg-row")
                .And
                .HaveElementAt(4, "flex-xl-row");
        }

        [TestMethod]
        public void OnDesktop_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnDesktop(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-row")
                .And
                .HaveElementAt(1, "flex-sm-row")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-row")
                .And
                .HaveElementAt(4, "flex-xl-row");
        }

        [TestMethod]
        public void OnDesktopAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnDesktopAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-row")
                .And
                .HaveElementAt(1, "flex-sm-row")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnDesktopAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-row")
                .And
                .HaveElementAt(4, "flex-xl-row");
        }

        [TestMethod]
        public void OnWidescreen_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnWidescreen(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-row")
                .And
                .HaveElementAt(1, "flex-sm-row")
                .And
                .HaveElementAt(2, "flex-md-row")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-row");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnWidescreenAndLarger(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-row")
                .And
                .HaveElementAt(1, "flex-sm-row")
                .And
                .HaveElementAt(2, "flex-md-row")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnWidescreenAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-row");
        }

        [TestMethod]
        public void OnFullHD_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnFullHD(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Direction.Is.OnFullHDAndSmaller(DirectionOption.Column);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-column")
                .And
                .HaveElementAt(1, "flex-sm-column")
                .And
                .HaveElementAt(2, "flex-md-column")
                .And
                .HaveElementAt(3, "flex-lg-column")
                .And
                .HaveElementAt(4, "flex-xl-column");
        }

    }
}
