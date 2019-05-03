/// <remarks>
/// Copyright (C) 2019 Squizz PTY LTD
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
    /// <summary>Ecommerce standards document that contains a list of kit records</summary>
    /// <example>
    /// An example of the Kit Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.3,
    ///     "resultStatus": 1,
    ///     "message":"The product kit data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 4,
    ///     "configs":{"dataFields":"keyKitProductID,keyComponentProductID,quantity,ordering"},
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
    public class ESDocumentKit : ESDocument
    {
        /// <summary>List of kit records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordKitComponent[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the kit data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="kitComponentRecords">list of kit component records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the kit component record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentKit(int resultStatus, string message, ESDRecordKitComponent[] kitComponentRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = kitComponentRecords;
            this.configs = configs;
            if (kitComponentRecords != null)
            {
                this.totalDataRecords = kitComponentRecords.Length;
            }
        }
    }
}
