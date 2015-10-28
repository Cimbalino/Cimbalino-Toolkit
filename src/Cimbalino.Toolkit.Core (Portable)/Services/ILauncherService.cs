﻿// ****************************************************************************
// <copyright file="ILauncherService.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2014
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <project>Cimbalino.Toolkit.Core</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using System;
using System.Threading.Tasks;

namespace Cimbalino.Toolkit.Services
{
    /// <summary>
    /// Represents a service capable of starting the default app associated with the specified file or <see cref="Uri"/>.
    /// </summary>
    public interface ILauncherService
    {
        /// <summary>
        /// Starts the default app associated with the URI scheme name for the specified <see cref="Uri"/>.
        /// </summary>
        /// <param name="uri">The <see cref="Uri"/> to start.</param>
        /// <returns>The <see cref="Task"/> object representing the asynchronous operation.</returns>
        Task LaunchUriAsync(Uri uri);

        /// <summary>
        /// Starts the default app associated with the URI scheme name for the specified <see cref="Uri"/>.
        /// </summary>
        /// <param name="url">The URI to start.</param>
        /// <returns>The <see cref="Task"/> object representing the asynchronous operation.</returns>
        Task LaunchUriAsync(string url);

        /// <summary>
        /// Starts the default app associated with the specified file.
        /// </summary>
        /// <param name="file">The file to start.</param>
        /// <returns>The <see cref="Task"/> object representing the asynchronous operation.</returns>
        Task LaunchFileAsync(string file);

        /// <summary>
        /// Checks for registered URI schema asynchronous.
        /// </summary>
        /// <param name="uriScheme">The URI scheme.</param>
        /// <param name="includeUriForResults">if set to <c>true</c> [include URI for results].</param>
        /// <returns>Result of checking Uri scheme is handled</returns>
        Task<UriScheme> FindUriSchemeHandlersAsync(string uriScheme, bool includeUriForResults = false);
    }
}