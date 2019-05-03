// <copyright file="Config.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

using Microsoft.Extensions.DependencyInjection;

namespace Flexor
{
    /// <summary>
    /// Flexor configuration helper.
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Register Flexor services.
        /// </summary>
        /// <param name="serviceCollection">The current collection of services.</param>
        /// <returns>The configured collection of services.</returns>
        public static IServiceCollection AddFlexor(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFlexorJSInterop, FlexorJSInterop>();

            return serviceCollection;
        }
    }
}
