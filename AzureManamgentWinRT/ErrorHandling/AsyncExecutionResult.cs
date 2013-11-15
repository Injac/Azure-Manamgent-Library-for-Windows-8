using System;

namespace AzureManamgentWinRT.ErrorHandling
{
    /// <summary>
    /// Handle async exceptions, or success.
    /// </summary>
    public class AsyncExecutionResult
    {
        /// <summary>
        /// True, if the method was successfull.
        /// </summary>
        /// <value>The successfull.</value>
        public bool Successfull { get; set; }

        /// <summary>
        /// Gets or sets the message,
        /// returned by the method.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }


        /// <summary>
        /// If an exception occured, it is saved here.
        /// </summary>
        /// <value>The async exception.</value>
        public Exception AsyncException { get; set; }

    }
}
