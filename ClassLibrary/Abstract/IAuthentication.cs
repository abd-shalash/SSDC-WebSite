using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    /// <summary>
    /// Interface: Authentication
    /// </summary>
    /// <remarks>
    /// Defines the methods in an authentication process.
    /// </remarks>
    public interface IAuthentication
    {
        /// <summary>
        /// Complete a login process with the provided username and password.
        /// </summary>
        /// <param name="Username">Username</param>
        /// <param name="Password">Password</param>
        /// <returns></returns>
        bool Login(string Username, string Password);

        /// <summary>
        /// Complete a login process for the current logged in user.
        /// </summary>
        /// <returns></returns>
        bool Logout();
    }
}
