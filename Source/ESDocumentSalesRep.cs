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
    /// Ecommerce standards document that contains a list of sales representative records
    /// </summary>
    /// <example>
    /// An example of the Sales Representative Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The sales representative data has been successfully obtained.",
    ///     "configs":{"dataFields":"keySalesRepID,name,salesRepCode,contact,isIndividual"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.1,
    ///     "totalDataRecords": 3,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keySalesRepID":"REP-1"
    ///         },
    ///         {
    ///             "keySalesRepID":"REP-2",
    ///             "salesRepCode": "JD",
    ///             "contact": "John Doe",
    ///             "isIndividual": "Y"
    ///         },
    ///         {
    ///             "keySalesRepID":"4533",
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
    public class ESDocumentSalesRep : ESDocument
    {
        /// <summary>List of sales representative records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordSalesRep[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the sales representative data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="salesRepresentativeRecords">list of sales representative records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the sales representative record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentSalesRep(int resultStatus, string message, ESDRecordSalesRep[] salesRepresentativeRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = salesRepresentativeRecords;
            this.configs = configs;
            if (salesRepresentativeRecords != null)
            {
                this.totalDataRecords = salesRepresentativeRecords.Length;
            }
        }
    }
}
