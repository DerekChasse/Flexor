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
        public void GetClass_Default_Correctly()
        {
            // Arrange
            this.underTest = Order.Default;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().BeNullOrWhiteSpace();
        }

        [TestMethod]
        public void GetClass_0_Correctly()
        {
            // Arrange
            this.underTest = Order.Is0OnAll;

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
        public void GetClass_1_Correctly()
        {
            // Arrange
            this.underTest = Order.Is1OnAll;

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
        public void GetClass_2_Correctly()
        {
            // Arrange
            this.underTest = Order.Is2OnAll;

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
        public void GetClass_3_Correctly()
        {
            // Arrange
            this.underTest = Order.Is3OnAll;

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
        public void GetClass_4_Correctly()
        {
            // Arrange
            this.underTest = Order.Is4OnAll;

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
        public void GetClass_5_Correctly()
        {
            // Arrange
            this.underTest = Order.Is5OnAll;

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
        public void GetClass_6_Correctly()
        {
            // Arrange
            this.underTest = Order.Is6OnAll;

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
        public void GetClass_7_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7OnAll;

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
        public void GetClass_8_Correctly()
        {
            // Arrange
            this.underTest = Order.Is8OnAll;

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
        public void GetClass_9_Correctly()
        {
            // Arrange
            this.underTest = Order.Is9OnAll;

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
        public void GetClass_10_Correctly()
        {
            // Arrange
            this.underTest = Order.Is10OnAll;

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
        public void GetClass_11_Correctly()
        {
            // Arrange
            this.underTest = Order.Is11OnAll;

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
        public void GetClass_12_Correctly()
        {
            // Arrange
            this.underTest = Order.Is12OnAll;

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
        public void GetClass_First_Correctly()
        {
            // Arrange
            this.underTest = Order.IsFirstOnAll;

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
        public void GetClass_Last_Correctly()
        {
            // Arrange
            this.underTest = Order.IsLastOnAll;

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
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnMobileAndLarger();

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
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnTablet();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-sm-7");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnTabletAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(4)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-sm-7")
                .And
                .HaveElementAt(1, "order-md-7")
                .And
                .HaveElementAt(2, "order-lg-7")
                .And
                .HaveElementAt(3, "order-xl-7");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnTabletAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(2)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnDesktop();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-md-7");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnDesktopAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(3)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-md-7")
                .And
                .HaveElementAt(1, "order-lg-7")
                .And
                .HaveElementAt(2, "order-xl-7");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnDesktopAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(3)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-7");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnWidescreen();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-lg-7");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnWidescreenAndLarger();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(2)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-lg-7")
                .And
                .HaveElementAt(1, "order-xl-7");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnWidescreenAndSmaller();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(4)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-7")
                .And
                .HaveElementAt(1, "order-sm-7")
                .And
                .HaveElementAt(2, "order-md-7")
                .And
                .HaveElementAt(3, "order-lg-7");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnFullHD();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "order-xl-7");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnFullHDAndSmaller();

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
        public void Is0_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is0.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-0");
        }

        [TestMethod]
        public void Is1_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is1.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-1");
        }

        [TestMethod]
        public void Is2_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is2.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-2");
        }

        [TestMethod]
        public void Is3_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is3.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-3");
        }

        [TestMethod]
        public void Is4_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is4.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-4");
        }

        [TestMethod]
        public void Is5_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is5.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-5");
        }

        [TestMethod]
        public void Is6_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is6.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-6");
        }

        [TestMethod]
        public void Is7_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is7.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-7");
        }

        [TestMethod]
        public void Is8_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is8.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-8");
        }

        [TestMethod]
        public void Is9_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is9.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-9");
        }

        [TestMethod]
        public void Is10_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is10.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-10");
        }

        [TestMethod]
        public void Is11_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is11.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-11");
        }

        [TestMethod]
        public void Is12_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.Is12.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-12");
        }

        [TestMethod]
        public void IsFirst_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.IsFirst.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-first");
        }

        [TestMethod]
        public void IsLast_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Order.IsLast.OnMobile();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(1)
                .And
                .HaveElementAt(0, "order-last");
        }
    }
}
