﻿using System.Runtime.Serialization;

namespace D3ApiDotNet.Core.Objects
{
    /// <summary>
    /// D3ApiServiceExample: basic error class, all api object will inherit
    /// </summary>
    [DataContract]
    public abstract class ErrorObject : IBaseObject
    {
        /// <summary>
        /// Error code
        /// </summary>
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Error reason
        /// </summary>
        [DataMember]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public bool IsErrorObject()
        {
            return ((Code != null) || (Reason != null));
        }

        /// <summary>
        /// FileName of Error object, necassary for caching
        /// </summary>
        public static string FileName
        {
            get { return "ErrorObject"; }
        }
    }
}
