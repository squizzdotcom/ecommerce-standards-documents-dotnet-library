/// <remarks>
/// Copyright (C) 2018 Squizz PTY LTD
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
    /// <summary>Ecommerce standards document that contains a list of taxcode records</summary>
    /// <example>
    /// An example of the Taxcode Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.2,
    ///     "resultStatus": 1,
    ///     "message":"The taxcode data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 4,
    ///     "configs":{"dataFields":"keyTaxcodeID,taxcode,taxcodeLabel,description,taxcodePercentageRate"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyTaxcodeID":"123"
    ///         },
    ///         {
    ///             "keyTaxcodeID":"456",
    ///             "taxcode": "GST",
    ///             "taxcodeLabel":"Goods And Services Tax",
    ///             "description": "Australian Goods And Services Tax",
    ///             "taxcodePercentageRate": 10
    ///         },
    ///         {
    ///             "keyTaxcodeID":"765",
    ///             "taxcode": "WINE",
    ///             "description": "Wine Tax",
    ///             "taxcodePercentageRate": 15
    ///         },
    ///         {
    ///             "keyTaxcodeID":"6765",
    ///             "taxcode": "FREE",
    ///             "description": "Tax Free",
    ///             "taxcodePercentageRate": 0
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentTaxcode : ESDocument
    {
        /// <summary>List of taxcode records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordTaxcode[] dataRecords;

        /// <summary>Contructor</summary>
        public ESDocumentTaxcode()
        {
        }

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the taxcode data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="taxcodeRecords">list of taxcode records</param>
        public ESDocumentTaxcode(int resultStatus, string message, ESDRecordTaxcode[] taxcodeRecords)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = taxcodeRecords;
        }

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the taxcode data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="taxcodeRecords">list of taxcode records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the taxcode record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentTaxcode(int resultStatus, string message, ESDRecordTaxcode[] taxcodeRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = taxcodeRecords;
            this.configs = configs;
            if (taxcodeRecords != null){
                this.totalDataRecords = taxcodeRecords.Length;
            }
        }
    }
}
