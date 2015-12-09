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
    /// <summary>Ecommerce standards document that contains a list of product kit records</summary>
    /// <example>
    /// An example of the Product Kit Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product kit data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyKitProductID,keyComponentProductID,quantity,ordering"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 0.5,
    ///     "totalDataRecords": 4,
    ///     "dataRecords":
    ///     [
    ///         {
    ///             "keyKitProductID":"PROD-432",
    ///             "keyComponentProductID":"PROD-123"
    ///         },
    ///         {
    ///             "keyKitProductID":"PROD-444",
    ///             "keyComponentProductID":"PROD-123",
    ///             "quantity": 3,
    ///             "ordering": 3
    ///         },
    ///         {
    ///             "keyKitProductID":"PROD-444",
    ///             "keyComponentProductID":"PROD-456",
    ///             "quantity": 10,
    ///             "ordering": 1
    ///         },
    ///         {
    ///             "keyKitProductID":"PROD-444",
    ///             "keyComponentProductID":"PROD-789",
    ///             "quantity": 1,
    ///             "ordering": 2
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentProductKit : ESDocument
    {
        /// <summary>List of product kit records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordProductKitComponent[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product kit data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="productKitComponentRecords">list of product kit component records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the product kit component record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentProductKit(int resultStatus, string message, ESDRecordProductKitComponent[] productKitComponentRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = productKitComponentRecords;
            this.configs = configs;
        }
    }
}
