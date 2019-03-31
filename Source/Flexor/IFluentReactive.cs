using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor
{
    public interface IFluentReactive<TReturn>
    {
        TReturn OnMobile();

        TReturn OnMobileAndLarger();

        TReturn OnTablet();

        TReturn OnTabletAndLarger();

        TReturn OnTabletAndSmaller();

        TReturn OnDesktop();

        TReturn OnDesktopAndLarger();

        TReturn OnDesktopAndSmaller();

        TReturn OnWidescreen();

        TReturn OnWidescreenAndLarger();

        TReturn OnWidescreenAndSmaller();

        TReturn OnFullHD();

        TReturn OnFullHDAndSmaller();
    }

    public interface IFluentReactive<TFuent, TProp>
    {
        TFuent OnMobile(TProp value);

        TFuent OnMobileAndLarger(TProp value);

        TFuent OnTablet(TProp value);

        TFuent OnTabletAndLarger(TProp value);

        TFuent OnTabletAndSmaller(TProp value);

        TFuent OnDesktop(TProp value);

        TFuent OnDesktopAndLarger(TProp value);

        TFuent OnDesktopAndSmaller(TProp value);

        TFuent OnWidescreen(TProp value);

        TFuent OnWidescreenAndLarger(TProp value);

        TFuent OnWidescreenAndSmaller(TProp value);

        TFuent OnFullHD(TProp value);

        TFuent OnFullHDAndSmaller(TProp value);

    }
}
