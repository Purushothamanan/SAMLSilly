﻿using System.Configuration;

namespace SAMLSilly.AspNet.Config
{
    /// <summary>
    /// Logging configuration element.
    /// </summary>
    public class LoggingElement : WritableConfigurationElement
    {
        #region Attributes

        /// <summary>
        /// Gets or sets the logging factory.
        /// </summary>
        /// <value>The logging factory.</value>
        [ConfigurationProperty("loggingFactory")]
        public string LoggingFactory
        {
            get { return (string)base["loggingFactory"]; }
            set { base["loggingFactory"] = value; }
        }

        #endregion
    }
}
