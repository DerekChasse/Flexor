using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentOrderShould
    {
        private IOrder underTest;

        [TestMethod]
        public void Constructor_Default_Null()
        {
            // Arrange
            this.underTest = new FluentOrder();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().BeNullOrWhiteSpace();
        }

        [TestMethod]
        public void GetClass_Default_Correcty()
        {
            // Arrange
            this.underTest = Order.Default;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().BeNullOrWhiteSpace();
        }

        [TestMethod]
        public void GetClass_0_Correcty()
        {
            // Arrange
            this.underTest = Order.Is0;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-0")));
        }

        [TestMethod]
        public void GetClass_1_Correcty()
        {
            // Arrange
            this.underTest = Order.Is1;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-1")));
        }

        [TestMethod]
        public void GetClass_2_Correcty()
        {
            // Arrange
            this.underTest = Order.Is2;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-2")));
        }

        [TestMethod]
        public void GetClass_3_Correcty()
        {
            // Arrange
            this.underTest = Order.Is3;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-3")));
        }

        [TestMethod]
        public void GetClass_4_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-4")));
        }

        [TestMethod]
        public void GetClass_5_Correcty()
        {
            // Arrange
            this.underTest = Order.Is5;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-5")));
        }

        [TestMethod]
        public void GetClass_6_Correcty()
        {
            // Arrange
            this.underTest = Order.Is6;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-6")));
        }

        [TestMethod]
        public void GetClass_7_Correcty()
        {
            // Arrange
            this.underTest = Order.Is7;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-7")));
        }

        [TestMethod]
        public void GetClass_8_Correcty()
        {
            // Arrange
            this.underTest = Order.Is8;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-8")));
        }

        [TestMethod]
        public void GetClass_9_Correcty()
        {
            // Arrange
            this.underTest = Order.Is9;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-9")));
        }

        [TestMethod]
        public void GetClass_10_Correcty()
        {
            // Arrange
            this.underTest = Order.Is10;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-10")));
        }

        [TestMethod]
        public void GetClass_11_Correcty()
        {
            // Arrange
            this.underTest = Order.Is11;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-11")));
        }

        [TestMethod]
        public void GetClass_12_Correcty()
        {
            // Arrange
            this.underTest = Order.Is12;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-12")));
        }

        [TestMethod]
        public void GetClass_First_Correcty()
        {
            // Arrange
            this.underTest = Order.IsFirst;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-first")));
        }

        [TestMethod]
        public void GetClass_Last_Correcty()
        {
            // Arrange
            this.underTest = Order.IsLast;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("order") && v.EndsWith("-last")));
        }




        [TestMethod]
        public void OnMobile_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnMobileAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-7")
                .And
                .HaveElementAt(3, "order-lg-7")
                .And
                .HaveElementAt(4, "order-xl-7");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "order-sm-7");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-4")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-7")
                .And
                .HaveElementAt(3, "order-lg-7")
                .And
                .HaveElementAt(4, "order-xl-7");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-4")
                .And
                .HaveElementAt(3, "order-lg-4")
                .And
                .HaveElementAt(4, "order-xl-4");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "order-md-7");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-4")
                .And
                .HaveElementAt(1, "order-sm-4")
                .And
                .HaveElementAt(2, "order-md-7")
                .And
                .HaveElementAt(3, "order-lg-7")
                .And
                .HaveElementAt(4, "order-xl-7");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-7")
                .And
                .HaveElementAt(3, "order-lg-4")
                .And
                .HaveElementAt(4, "order-xl-4");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "order-lg-7");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-4")
                .And
                .HaveElementAt(1, "order-sm-4")
                .And
                .HaveElementAt(2, "order-md-4")
                .And
                .HaveElementAt(3, "order-lg-7")
                .And
                .HaveElementAt(4, "order-xl-7");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-7")
                .And
                .HaveElementAt(3, "order-lg-7")
                .And
                .HaveElementAt(4, "order-xl-4");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "order-xl-7");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correcty()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobileAndLarger().Is7.OnFullHDAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-7")
                .And
                .HaveElementAt(3, "order-lg-7")
                .And
                .HaveElementAt(4, "order-xl-7");
        }


    }
}
