// <copyright file="IFluentReactive.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public interface IFluentReactive<out TReturn>
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

    public interface IFluentReactive<out TFluent, in TProp>
    {
        TFluent OnMobile(TProp value);

        TFluent OnMobileAndLarger(TProp value);

        TFluent OnTablet(TProp value);

        TFluent OnTabletAndLarger(TProp value);

        TFluent OnTabletAndSmaller(TProp value);

        TFluent OnDesktop(TProp value);

        TFluent OnDesktopAndLarger(TProp value);

        TFluent OnDesktopAndSmaller(TProp value);

        TFluent OnWidescreen(TProp value);

        TFluent OnWidescreenAndLarger(TProp value);

        TFluent OnWidescreenAndSmaller(TProp value);

        TFluent OnFullHD(TProp value);

        TFluent OnFullHDAndSmaller(TProp value);
    }
}
