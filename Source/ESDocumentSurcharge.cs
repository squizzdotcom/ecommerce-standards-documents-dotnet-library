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
    /// <summary>Ecommerce standards document that contains a list of surcharge records</summary>
    /// <example>
    /// An example of the Surcharge Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.3,
    ///     "resultStatus": 1,
    ///     "message":"The surcharge data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 4,
    ///     "configs":{"dataFields":"keySurchargeID,surchargeCode,surchargeLabel,description,surchargeType"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keySurchargeID":"123"
    ///         },
    ///         {
    ///             "keySurchargeID":"456",
    ///             "surchargeCode": "WEB_FREIGHT",
    ///             "surchargeLabel":"Web Order Freight",
    ///             "description": "Costs to deliver orders created through the website.",
    ///             "surchargeType": "FREIGHT"
    ///         },
    ///         {
    ///             "keySurchargeID":"765",
    ///             "surchargeCode": "WEB_CC_SURCHARGE",
    ///             "surchargeLabel": "Web Credit Card Surcharge",
    ///             "description": "Transaction cost for payment made by credit card.",
    ///             "surchargeType": "CREDITCARD"
    ///         },
    ///         {
    ///             "keySurchargeID":"6765",
    ///             "surchargeCode": "WEB_MIN_ORDER",
    ///             "surchargeLabel": "Web Minimum Order Surcharge",
    ///             "description": "Cost to handle orders when an order's total price is under the allowed minimum.",
    ///             "surchargeType": "MINORDER"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentSurcharge : ESDocument
    {
        /// <summary>List of surcharge records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordSurcharge[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the surcharge data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="surchargeRecords">list of surcharge records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the surcharge record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentSurcharge(int resultStatus, string message, ESDRecordSurcharge[] surchargeRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = surchargeRecords;
            this.configs = configs;
            if (surchargeRecords != null)
            {
                this.totalDataRecords = surchargeRecords.Length;
            }
        }
    }
}