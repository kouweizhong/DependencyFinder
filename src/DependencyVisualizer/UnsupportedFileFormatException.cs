//----------------------------------------------------------------
// Dependency Visualizer
//----------------------------------------------------------------
//
// Unsupported file format exception
//
// Copyright � 2007 Simon Dahlbacka
//
// Created: 27.3 2007 Simon Dahlbacka
// $Id: $
//----------------------------------------------------------------
// $NoKeywords: $

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using DependencyVisualizer.Properties;

namespace DependencyVisualizer {
    /// <summary>
    /// Unsupported file format exception
    /// </summary>
    [Serializable]
    public class UnsupportedFileFormatException : Exception {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsupportedFileFormatException"/> class.
        /// </summary>
        public UnsupportedFileFormatException()
            : base(Resources.UnsupportedFileFormat) {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsupportedFileFormatException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public UnsupportedFileFormatException(string message)
            : base(message) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsupportedFileFormatException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public UnsupportedFileFormatException(string message, Exception innerException)
            : base(message, innerException) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnsupportedFileFormatException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"></see> is zero (0). </exception>
        /// <exception cref="T:System.ArgumentNullException">The info parameter is null. </exception>
        protected UnsupportedFileFormatException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
