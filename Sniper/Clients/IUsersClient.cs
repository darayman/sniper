﻿#if false
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Sniper.Request;
using Sniper.Response;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Users API.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/users/">Users API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
    /// </remarks>
    public interface IUsersClient
    {
        /// <summary>
        /// A client for GitHub's User Emails API
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/users/emails/">Emails API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        ///</remarks>
        IUserEmailsClient Email { get; }

      /// <summary>
        /// Returns the user specified by the login.
        /// </summary>
        /// <param name="login">The login name for the user</param>
        [SuppressMessage(Categories.Naming, "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        [SuppressMessage(Categories.Naming, "CA1726:UsePreferredTerms", MessageId = "login")]
        Task<User> Get(string login);

        /// <summary>
        /// Returns a <see cref="User"/> for the current authenticated user.
        /// </summary>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <returns>A <see cref="User"/></returns>
        Task<User> Current();

        /// <summary>
        /// Update the specified <see cref="UserUpdate"/>.
        /// </summary>
        /// <param name="user">The login for the user</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <returns>A <see cref="User"/></returns>
        Task<User> Update(UserUpdate user);

        /// <summary>
        /// A client for GitHub's User Administration API
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/users/administration/">User Administrator API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        ///</remarks>
        IUserAdministrationClient Administration { get; }
    }
}
#endif