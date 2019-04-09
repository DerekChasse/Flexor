// <copyright file="ICssBacked.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Backed by a collection of CSS classes.
    /// </summary>
    public interface ICssBacked
    {
        /// <summary>
        /// Gets the CSS class definition.
        /// </summary>
        string Class { get; }

        /// <summary>
        /// Gets the CSS style definition.
        /// </summary>
        string Style { get; }
    }
}
