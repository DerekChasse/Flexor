using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor.Tests
{
    [TestClass]
    public class BreakpointShould
    {
        [TestMethod]
        public void Breakpoint_Equals_Return_True()
        {
            // Arrange 
            var bp1 = Breakpoint.Desktop;
            var bp2 = Breakpoint.Desktop;

            // Act
            var equal = bp1 == bp2;

            // Assert
            equal.Should().BeTrue();
        }

        [TestMethod]
        public void Breakpoint_Equals_Return_False()
        {
            // Arrange 
            var bp1 = Breakpoint.Desktop;
            var bp2 = Breakpoint.Widescreen;

            // Act
            var equal = bp1 == bp2;

            // Assert
            equal.Should().BeFalse();
        }

        [TestMethod]
        public void Breakpoint_Object_Equals_Return_False()
        {
            // Arrange 
            var bp1 = Breakpoint.Desktop;
            var bp2 = string.Empty;

            // Act
            var equal = bp1.Equals(bp2);

            // Assert
            equal.Should().BeFalse();
        }

        [TestMethod]
        public void Breakpoint_Object_Equals_Return_True()
        {
            // Arrange 
            var bp1 = Breakpoint.Desktop;
            var bp2 = Breakpoint.Desktop;

            // Act
            var equal = bp1.Equals(bp2);

            // Assert
            equal.Should().BeTrue();
        }

        [TestMethod]
        public void Breakpoint_Operator_Equals_Return_True()
        {
            // Arrange 
            var bp1 = Breakpoint.Desktop;
            var bp2 = Breakpoint.Desktop;

            // Act
            var equal = bp1 == bp2;

            // Assert
            equal.Should().BeTrue();
        }

        [TestMethod]
        public void Breakpoint_Operator_NotEquals_Return_True()
        {
            // Arrange 
            var bp1 = Breakpoint.Desktop;
            var bp2 = Breakpoint.Widescreen;

            // Act
            var equal = bp1 != bp2;

            // Assert
            equal.Should().BeTrue();
        }
    }
}
