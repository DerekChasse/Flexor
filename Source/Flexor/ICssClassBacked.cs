// <copyright file="ICssClassBacked.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Backed by a collection of CSS classes.
    /// </summary>
    public interface ICssClassBacked
    {
        /// <summary>
        /// Gets the CSS class definition.
        /// </summary>
        string Class { get; }

        ////TODO: rename to ICssBacked and Add Style getter.
    }
}
