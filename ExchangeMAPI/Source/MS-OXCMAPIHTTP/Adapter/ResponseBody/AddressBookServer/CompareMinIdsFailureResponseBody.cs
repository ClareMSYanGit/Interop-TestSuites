﻿namespace Microsoft.Protocols.TestSuites.MS_OXCMAPIHTTP
{
    using System;

    /// <summary>
    /// A class indicates the CompareMinIds request type failure response body.
    /// </summary>
    public class CompareMinIdsFailureResponseBody: AddressBookResponseBodyBase
    {
        /// <summary>
        /// Parse the CompareMinIds request type response body.
        /// </summary>
        /// <param name="rawData">The raw data of response.</param>
        /// <returns>The failure response body of CompareMinIds request</returns>
        public static CompareMinIdsFailureResponseBody Parse(byte[] rawData)
        {
            CompareMinIdsFailureResponseBody responseBody = new CompareMinIdsFailureResponseBody();
            int index = 0;
            responseBody.StatusCode = BitConverter.ToUInt32(rawData, index);
            index += 4;
            responseBody.AuxiliaryBufferSize = BitConverter.ToUInt32(rawData, index);
            index += 4;
            responseBody.AuxiliaryBuffer = new byte[responseBody.AuxiliaryBufferSize];
            Array.Copy(rawData, index, responseBody.AuxiliaryBuffer, 0, responseBody.AuxiliaryBufferSize);

            return responseBody;
        }
    }
}
