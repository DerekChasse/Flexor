using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flexor
{
    public interface IFluentShow
    {

    }


    public interface IFluentShowOnBreakpoint : IFluentShow
    {
        IFluentShowOnBreakpointWithValue OnMobile(bool value = true);

        IFluentShowOnBreakpointWithValue OnTablet(bool value = true);

        IFluentShowOnBreakpointWithValue OnDesktop(bool value = true);

        IFluentShowOnBreakpointWithValue OnWidescreen(bool value = true);

        IFluentShowOnBreakpointWithValue OnFullHD(bool value = true);
    }

    public interface IFluentShowOnBreakpointWithValue : IFluentShow, IFluentShowOnBreakpoint
    {
    }

    public class FluentShow : IFluentShow, IFluentShowOnBreakpoint, IFluentShowOnBreakpointWithValue
    {
        private Dictionary<Breakpoint, bool> breakpointDictionary = new Dictionary<Breakpoint, bool>()
        {
            { Breakpoint.None, true },
            { Breakpoint.Mobile, true },
            { Breakpoint.Tablet, true },
            { Breakpoint.Desktop, true },
            { Breakpoint.Widescreen, true },
            { Breakpoint.FullHD, true },
        };

        public IFluentShowOnBreakpointWithValue OnDesktop(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Desktop] = value;
            return this;
        }

        public IFluentShowOnBreakpointWithValue OnFullHD(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.FullHD] = value;
            return this;
        }

        public IFluentShowOnBreakpointWithValue OnMobile(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Mobile] = value;
            return this;
        }

        public IFluentShowOnBreakpointWithValue OnTablet(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Tablet] = value;
            return this;
        }

        public IFluentShowOnBreakpointWithValue OnWidescreen(bool value = true)
        {
            this.breakpointDictionary[Breakpoint.Widescreen] = value;
            return this;
        }
    }

    public static class Show
    {
        public static IFluentShowOnBreakpointWithValue OnMobile(bool value)
        {
            return new FluentShow().OnMobile(value);
        }

        public static IFluentShowOnBreakpointWithValue OnTablet(bool value)
        {
            return new FluentShow().OnTablet(value);
        }

        public static IFluentShowOnBreakpointWithValue OnDesktop(bool value)
        {
            return new FluentShow().OnDesktop(value);
        }

        public static IFluentShowOnBreakpointWithValue OnWidescreen(bool value)
        {
            return new FluentShow().OnWidescreen(value);
        }

        public static IFluentShowOnBreakpointWithValue OnFullHD(bool value)
        {
            return new FluentShow().OnFullHD(value);
        }
    }
}
