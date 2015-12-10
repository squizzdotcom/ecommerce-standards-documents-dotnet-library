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
    /// <summary>Ecommerce standards document that contains a list of labour records.</summary>
    /// <example>
    /// An example of the Labour Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The labour data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyLabourID,labourCode,keyTaxcodeID,labourSearchCode,brand,name,description1,description2,description3,description4,labourClass,averageCost,supplier,labourQuantity,labourNoneQuantity,labourLowQuantity,isPriceTaxInclusive"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 2,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyLabourID":"LAB1",
    ///             "labourCode":"Labour 123",
    ///             "keyTaxcodeID":"FREE"
    ///         },
    ///         {
    ///             "keyLabourID":"LAB2",
    ///             "labourCode":"Labour 2",
    ///             "keyTaxcodeID":"GST",
    ///             "labourSearchCode":"Installation Labour",
    ///             "brand":"Joey's Labour",
    ///             "name":"Installation Labour",
    ///             "description1":"Labour to provide installation of equipment.",
    ///             "description2":"",
    ///             "description3":"",
    ///             "description4":"",
    ///             "labourClass":"ABC",
    ///             "averageCost": 10.00,
    ///             "supplier":"Joey's Contractors Firm",
    ///             "labourQuantity": 200,
    ///             "labourNoneQuantity": 0,
    ///             "labourLowQuantity": 10,
    ///             "isPriceTaxInclusive": "N"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentLabour : ESDocument
    {
        /// <summary>List of labour records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordProduct[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the labour data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="labourRecords">list of labour records</param>
        public ESDocumentLabour(int resultStatus, string message, ESDRecordProduct[] labourRecords)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = labourRecords;
            configs = new Dictionary<string, string>();
        }

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the labour data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="labourRecords">list of labour records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the labour record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentLabour(int resultStatus, string message, ESDRecordProduct[] labourRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = labourRecords;
            this.configs = configs;
        }
    }
}
