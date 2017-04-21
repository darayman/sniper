﻿using Sniper.Application.Messages;
using Sniper.Authentication;
using Sniper.Http;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Sniper
{
    internal class BasicAuthenticator : IAuthenticationHandler
    {
        ///<summary>
        ///Authenticate a request using the basic access authentication scheme
        ///</summary>
        ///<param name="request">The request to authenticate</param>
        ///<param name="credentials">The credentials to attach to the request</param>
        ///<remarks>
        ///See the <a href="http://developer.github.com/v3/#basic-authentication">Basic Authentication documentation</a> for more information. //TODO: Replace with TargetProcess
        ///</remarks>
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(request), request);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);
            Ensure.ArgumentNotNull(nameof(credentials.Login), credentials.Login);

            Debug.Assert(credentials.Password != null, AuthenticationKeys.Messages.EmptyPassword);

            var header = string.Format(CultureInfo.InvariantCulture, AuthenticationKeys.Messages.BasicAuthorizationMessageFormat, 
                Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, 
                MessageKeys.StandardKeyValueFormat, credentials.Login, credentials.Password))));

            request.Headers[AuthenticationKeys.Keys.Authorization] = header;
        }
    }
}