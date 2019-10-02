﻿// ****************************************************************************
// <copyright file="ApplicationSettingsService.uwp.cs" company="Pedro Lamas">
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

using Windows.Storage;

namespace Cimbalino.Toolkit.Services
{
    /// <summary>
    /// Represents an implementation of the <see cref="IApplicationSettingsService"/>.
    /// </summary>
    public class ApplicationSettingsService : IApplicationSettingsService
    {
        private static readonly IApplicationSettingsServiceHandler LocalSettingsServiceHandlerStatic, RoamingSettingsServiceHandlerStatic;

        private static readonly IApplicationSettingsServiceHandler LegacySettingsServiceHandlerStatic;

        static ApplicationSettingsService()
        {
            var applicationData = ApplicationData.Current;

            LocalSettingsServiceHandlerStatic = new ApplicationSettingsServiceHandler(applicationData.LocalSettings);
            RoamingSettingsServiceHandlerStatic = new ApplicationSettingsServiceHandler(applicationData.RoamingSettings);

            LegacySettingsServiceHandlerStatic = new LegacyApplicationSettingsServiceHandler();
        }

        /// <summary>
        /// Gets the local settings handler instance for the app.
        /// </summary>
        /// <value>The local settings handler instance for the app.</value>
        public virtual IApplicationSettingsServiceHandler Local
        {
            get
            {
                return LocalSettingsServiceHandlerStatic;
            }
        }

        /// <summary>
        /// Gets the roaming settings handler instance for the app.
        /// </summary>
        /// <value>The roaming settings handler instance for the app.</value>
        public virtual IApplicationSettingsServiceHandler Roaming
        {
            get
            {
                return RoamingSettingsServiceHandlerStatic;
            }
        }

        /// <summary>
        /// Gets the legacy settings handler instance for the app.
        /// </summary>
        /// <value>The legacy settings handler instance for the app.</value>
        public virtual IApplicationSettingsServiceHandler Legacy
        {
            get
            {
                return LegacySettingsServiceHandlerStatic;
            }
        }
    }
}