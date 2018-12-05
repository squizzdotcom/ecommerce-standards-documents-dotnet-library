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
    /// <summary>
    /// Ecommerce standards document that holds a list of general ledger account records
    /// </summary>
    /// <example>
    /// An example of the Customer Account Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.3,
    ///     "resultStatus": 1,
    ///     "message":"The general ledger account data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyGLAccountID,glAccountCode,name,description,accountClass,balance,keyTaxcodeID,keyParentGLAccountID,accountType"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyGLAccountID":"GL1",
    ///         },
    ///         {
    ///             "keyGLAccountID":"111",
    ///             "glAccountCode":"3000",
    ///             "name":"Operating Revenue Account",
    ///             "description":"Records transactions for revenue that is generated in day-to-day trading activities",
    ///             "accountClass":"Revenue",
    ///             "balance":200123.34,
    ///             "keyTaxcodeID": "TAXGST",
    ///             "keyParentGLAccountID": "3",
    ///             "accountType":"OPERATING_REVENUE"
    ///         },
    ///         {
    ///             "keyGLAccountID":"2",
    ///             "glAccountCode":"1150",
    ///             "name":"Buildings and land assets",
    ///             "description":"Records transactions associated with building and land assets owned by the business",
    ///             "accountClass":"Asset",
    ///             "balance":100023.43,
    ///             "keyTaxcodeID": "TAXGST",
    ///             "keyParentGLAccountID": "1",
    ///             "accountType":"ASSET"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentGeneralLedgerAccount : ESDocument
    {
        /// <summary>List of general ledger account records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordGeneralLedgerAccount[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the general ledger account record data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="generalLedgerAccountRecords">list of general ledger account records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the general ledger account record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentGeneralLedgerAccount(int resultStatus, string message, ESDRecordGeneralLedgerAccount[] generalLedgerAccountRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = generalLedgerAccountRecords;
            this.configs = configs;
            if (generalLedgerAccountRecords != null)
            {
                this.totalDataRecords = generalLedgerAccountRecords.Length;
            }
        }
    }
}
