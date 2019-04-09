using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flexor.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CssBackedClass()
        {
            // Arrange
            var direction = Direction.Is(DirectionOption.Row).OnTabletAndSmaller().Is(DirectionOption.ColumnReverse).OnDesktopAndLarger();
           

            // Act
            var underTest = direction.Class;

            // Assert

            Assert.IsNotNull(underTest);
        }
    }
}
