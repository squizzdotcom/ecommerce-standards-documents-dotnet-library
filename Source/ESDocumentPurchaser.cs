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
    /// Ecommerce standards document that contains a list of purchaser records
    /// </summary>
    /// <example>
    /// An example of the Purchaser Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The purchaser data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyPurchaserID,salesRepCode,contact,isIndividual"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 0.5,
    ///     "totalDataRecords": 3,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyPurchaserID":"PUR-1"
    ///         },
    ///         {
    ///             "keyPurchaserID":"PUR-2",
    ///             "salesRepCode": "JD",
    ///             "contact": "John Doe",
    ///             "isIndividual": "Y"
    ///         },
    ///         {
    ///             "keyPurchaserID":"4533",
    ///             "salesRepCode": "AI",
    ///             "name": "Acme Industries",
    ///             "contact": "Kevin Peterson",
    ///             "isIndividual": "N"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentPurchaser : ESDocument
    {
        /// <summary>List of purchaser records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordPurchaser[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the purchaser data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="purchaserRecords">list of purchaser records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the purchaser record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentPurchaser(int resultStatus, string message, ESDRecordPurchaser[] purchaserRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = purchaserRecords;
            this.configs = configs;
        }
    }
}
