// <copyright file="IFluentReactive.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Definition objects are reactive and respond to CSS media query values.
    /// </summary>
    /// <typeparam name="TFluent">The object configuration type.</typeparam>
    public interface IFluentReactive<out TFluent>
    {
        /// <summary>
        /// Specifies that the configuration is applicable to mobile devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnMobile();

        /// <summary>
        /// Specifies that the configuration is applicable to mobile and larger devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnMobileAndLarger();

        /// <summary>
        /// Specifies that the configuration is applicable to tablet devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnTablet();

        /// <summary>
        /// Specifies that the configuration is applicable to tablet and larger devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnTabletAndLarger();

        /// <summary>
        /// Specifies that the configuration is applicable to tablet and smaller devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnTabletAndSmaller();

        /// <summary>
        /// Specifies that the configuration is applicable to desktop devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnDesktop();

        /// <summary>
        /// Specifies that the configuration is applicable to desktop and larger devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnDesktopAndLarger();

        /// <summary>
        /// Specifies that the configuration is applicable to desktop an smaller devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnDesktopAndSmaller();

        /// <summary>
        /// Specifies that the configuration is applicable to widescreen devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnWidescreen();

        /// <summary>
        /// Specifies that the configuration is applicable to widescreen and larger devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnWidescreenAndLarger();

        /// <summary>
        /// Specifies that the configuration is applicable to widescreen and smaller devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnWidescreenAndSmaller();

        /// <summary>
        /// Specifies that the configuration is applicable to full HD devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnFullHD();

        /// <summary>
        /// Specifies that the configuration is applicable to full HD and smaller devices.
        /// </summary>
        /// <returns>The configuration object.</returns>
        TFluent OnFullHDAndSmaller();
    }
}
