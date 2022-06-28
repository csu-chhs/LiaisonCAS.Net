using LiaisonCAS.Net.Interfaces;

namespace LiaisonCAS.Net
{
    public interface ILiaisonCASClient
    {
        /// <summary>
        /// This method specifically gets placed outside of the 
        /// constructor so that it does not run every time a new object 
        /// is constructed.  DI creates a new object on every page load
        /// in an app, and that would quickly increase the number of 
        /// calls we are making.
        /// </summary>
        void SetupAuthenticationHeaders();

        /// <summary>
        /// This method specifically gets placed outside of the 
        /// constructor so that it does not run every time a new object 
        /// is constructed.  DI creates a new object on every page load
        /// in an app, and that would quickly increase the number of 
        /// calls we are making.
        /// </summary>
        Task SetupAuthenticationHeadersAsync();

        /// <summary>
        /// Access the Applications API
        /// </summary>
        IApplicationClient Application { get; }

        /// <summary>
        /// Access the File API
        /// </summary>
        IFileClient File { get; }

        /// <summary>
        /// Access the Program API
        /// </summary>
        IProgramClient Program { get; }

        /// <summary>
        /// Access the Account API
        /// </summary>
        IAccountClient Account { get; }
    }
}
