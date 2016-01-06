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
    /// Ecommerce standards document that holds a list of contract records for customer accounts
    /// </summary>
    /// <example>
    /// An example of the Customer Account Address Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The customer account contract data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyContractID,contractCode,description,forceContractPrice,type,expireDate"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 3,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyContractID":"CNT-003",
    ///             "contractCode":"CONTRACT-003",
    ///         },
    ///         {
    ///             "keyContractID":"34",
    ///             "contractCode":"SALE-34",
    ///             "description":"VIP Sales Contract #34",
    ///             "forceContractPrice":"N",
    ///             "type":"",
    ///             "expireDate": 1446798878
    ///         },
    ///         {
    ///             "keyContractID":"22",
    ///             "contractCode":"VIP-21",
    ///             "description":"VIP Contract",
    ///             "forceContractPrice":"Y",
    ///             "type":"Special",
    ///             "expireDate": 1456798878,
    ///             "keyAccountIDs":["15C1","222"],
    ///             "keyProductIDs":["PD001","PD022"]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentCustomerAccountContract : ESDocument
    {
        /// <summary>List of customer account contract records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordCustomerAccountContract[] dataRecords;
        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the customer account contract data</param>
        /// <param name="message">message describing the status of obtaining the data for the document</param>
        /// <param name="customerAccountContractRecords">list of customer account contract records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the customer account contract record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentCustomerAccountContract(int resultStatus, string message, ESDRecordCustomerAccountContract[] customerAccountContractRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = customerAccountContractRecords;
            this.configs = configs;
            if (customerAccountContractRecords != null)
            {
                this.totalDataRecords = customerAccountContractRecords.Length;
            }
        }
    }
}
