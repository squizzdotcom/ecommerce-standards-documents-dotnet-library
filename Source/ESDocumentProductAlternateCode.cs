/// <remarks>
/// Copyright (C) 2016 Squizz PTY LTD
/// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.  If not, see http://www.gnu.org/licenses/.
/// </remarks>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace EcommerceStandardsDocuments
{
    /// <summary>
    /// Ecommerce standards document that contains a list of alternate code records associated with products
    /// </summary>
    /// <example>
    /// An example of the Product Alternate Code Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product alternate code data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyProductID,alternateCode,isUseCode,isSupplierCode"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 0.5,
    ///     "totalDataRecords": 3,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"123A",
    ///             "alternateCode":"043432-IND"
    ///         },
    ///         {
    ///             "keyProductID":"123A",
    ///             "alternateCode":"SWISH-1234",
    ///             "isUseCode":"N",
    ///             "isSupplierCode":"Y"
    ///         },
    ///         {
    ///             "keyProductID":"1234",
    ///             "alternateCode":"SWISH-4567",
    ///             "isUseCode":"Y",
    ///             "isSupplierCode":"N"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentProductAlternateCode : ESDocument
    {
        /// <summary>List of alternate product code records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordProductAlternateCode[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product alternate code data</param>
        /// <param name="message">message describing the status of obtaining the data for the document</param>
        /// <param name="productAlternateCodeRecords">list of product alternate code records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the product alternate code record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentProductAlternateCode(int resultStatus, string message, ESDRecordProductAlternateCode[] productAlternateCodeRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = productAlternateCodeRecords;
            this.configs = configs;
        }
    }
}
