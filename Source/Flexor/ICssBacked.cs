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
    }

    /// <summary>
    /// Backed by a dynamic definition of CSS classes.
    /// </summary>
    public interface IDynamicCssBacked
    {
        /// <summary>
        /// Gets the dynamic CSS definition.
        /// </summary>
        string Css { get; }
    }
}
