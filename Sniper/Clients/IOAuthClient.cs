﻿#if false
using System;
using System.Threading.Tasks;
using Sniper.Request;
using Sniper.Response;

namespace Sniper
{
    /// <summary>
    /// Provides methods used in the OAuth web flow.
    /// </summary>
    public interface IOAuthClient  //TODO: Replace with TargetProcess if this is usable
    {
        /// <summary>
        /// Gets the URL used in the first step of the web flow. The Web application should redirect to this URL.
        /// </summary>
        /// <param name="request">Parameters to the Oauth web flow login url</param>
        /// <returns></returns>
        Uri GetGitHubLoginUrl(OAuthLoginRequest request);

        /// <summary>
        /// Makes a request to get an access token using the code returned when GitHub.com redirects back from the URL
        /// <see cref="GetGitHubLoginUrl">GitHub login url</see> to the application.  //TODO: Replace with TargetProcess if this is usable
        /// </summary>
        /// <remarks>
        /// If the user accepts your request, GitHub redirects back to your site with a temporary code in a code
        /// parameter as well as the state you provided in the previous step in a state parameter. If the states don’t
        /// match, the request has been created by a third party and the process should be aborted. Exchange this for
        /// an access token using this method.
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<OAuthToken> CreateAccessToken(OAuthTokenRequest request);
    }
}
#endif