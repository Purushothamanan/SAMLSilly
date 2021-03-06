﻿using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace SAMLSilly.Config
{
    /// <summary>
    /// ServiceProvider configuration element.
    /// </summary>
    public class ServiceProvider
    {

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the server.
        /// </summary>
        /// <value>The server.</value>
        public string Server { get; set; }

        /// <summary>
        /// Gets or sets the authentication contexts.
        /// </summary>
        /// <value>The authentication contexts.</value>
        public AuthenticationContexts AuthenticationContexts { get; set; }

        /// <summary>
        /// Gets or sets the endpoints.
        /// </summary>
        /// <value>The endpoints.</value>
        public ServiceProviderEndpoints Endpoints { get; set; }

        /// <summary>
        /// Gets or sets the name id formats.
        /// </summary>
        /// <value>The name id formats.</value>
        public NameIdFormats NameIdFormats { get; set; }

        /// <summary>
        /// Gets or sets the name id format required for the request
        /// </summary>
        /// <value>The required name id format for the request</value>
        public NameIdFormat RequiredNameIdFormat { get; set; }

        /// <summary>
        /// Gets or sets the signing certificate.
        /// </summary>
        /// <value>The signing certificate.</value>
        public X509Certificate2 SigningCertificate { get; set; }


        public ServiceProvider()
        {
            NameIdFormats = new NameIdFormats();
            Endpoints = new ServiceProviderEndpoints();
            AuthenticationContexts = new AuthenticationContexts();
        }

        public bool AuthNAllowCreate { get; set; }

        public bool UseValidUntil { get; set; }

        public bool AuthNRequestsSigned { get; set; }

        public bool WantAssertionsSigned { get; set; }

        public bool IncludeArtifactResolutionEndpoints { get; set; }
    }
}
