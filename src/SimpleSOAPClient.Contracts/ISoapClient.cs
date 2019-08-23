﻿namespace SimpleSOAPClient
{
    /// <summary>
    /// The SOAP client that can be used to invoke SOAP Endpoints
    /// </summary>
    public interface ISoapClient
    {
        /// <summary>
        /// Creates a SOAP request
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="action">The SOAP action</param>
        /// <returns></returns>
        ISoapRequestMessage CreateRequest(object body, string action = "");
    }
}