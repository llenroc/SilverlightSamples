﻿using System;

namespace MetroWpf
{
    /// <summary>
    /// Generic exception for combining several other exceptions
    /// </summary>
    public class CombinedException : Exception
    {
        #region · Properties ·

        /// <summary>
        /// Gets the inner exceptions.
        /// </summary>
        /// <value>The inner exceptions.</value>
        public Exception[] InnerExceptions
        {
            get;
            protected set;
        }

        #endregion

        #region · Constructors ·

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerExceptions">The inner exceptions.</param>
        public CombinedException(string message, Exception[] innerExceptions)
            : base(message)
        {
            this.InnerExceptions = innerExceptions;
        }

        #endregion
    }
}