﻿//----------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//----------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace System.IdentityModel.Tokens
{
    /// <summary>
    /// Constants for Json Web tokens.
    /// </summary>
    internal class JwtConstants
    {
        /// <summary>
        /// Short header type.
        /// </summary>
        public const string HeaderType = "JWT";

        /// <summary>
        /// Long header type.
        /// </summary>
        public const string HeaderTypeAlt = "http://openid.net/specs/jwt/1.0";

        /// <summary>
        /// Short token type.
        /// </summary>
        public const string TokenType = "JWT";

        /// <summary>
        /// Long token type.
        /// </summary>
        public const string TokenTypeAlt = "urn:ietf:params:oauth:token-type:jwt";

        /// <summary>
        /// List of algorithms in spec
        /// </summary>
        public struct Algorithms
        {
            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string ECDSA_SHA256    = "ES256";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string ECDSA_SHA384    = "ES384";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string ECDSA_SHA512    = "ES512";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string HMAC_SHA256     = "HS256";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string HMAC_SHA384     = "HS384";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string HMAC_SHA512     = "HS512";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string NONE            = "none";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string RSA_SHA256      = "RS256";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string RSA_SHA384      = "RS384";

            /// <summary>
            /// Algorithm short name.
            /// </summary>
            public const string RSA_SHA512      = "RS512";
        }

        /// <summary>
        /// List of reserved claims in spec.
        /// </summary>
        /// <remarks>see: http://tools.ietf.org/pdf/draft-ietf-oauth-json-web-token-03.pdf </remarks>
        public struct ReservedClaims
        {
            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Actor = "actort";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Audience = "aud";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Birthdate = "birthdate";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Email = "email";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string ExpirationTime = "exp";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Gender = "gender";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string FamilyName = "family_name";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string GivenName = "given_name";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string IssuedAt = "iat";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Issuer = "iss";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string JwtId = "jti";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string NameId = "nameid";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string NotBefore = "nbf";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Principal = "prn";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Subject = "sub";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Type = "typ";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string UniqueName = "unique_name";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Website = "website";
        }

        /// <summary>
        /// List of reserved header parameters in spec.
        /// </summary>
        /// <remarks>see: http://tools.ietf.org/pdf/draft-ietf-jose-json-web-signature-06.pdf </remarks>
        public struct ReservedHeaderParameters
        {
            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Algorithm                 = "alg";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string ContentType               = "cty";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string KeyId                     = "kid";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string JsonSetUrl                = "jku";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string JsonWebKey                = "jwk";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string Type                      = "typ";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string X509CertificateChain      = "x5c";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string X509CertificateThumbprint = "x5t";

            /// <summary>
            /// Claim short name.
            /// </summary>
            public const string X509Url                   = "x5u";
        }
    }
}