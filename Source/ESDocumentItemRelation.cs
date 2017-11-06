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
    /// <summary>Ecommerce standards document that contains a list of item relation records</summary>
    /// <example>
    /// An example of the item relation Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.2,
    ///     "resultStatus": 1,
    ///     "message":"The item relation data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 4,
    ///     "configs":{"dataFields":"keyProductID,keyDownloadID,keyLabourID,keyRelatedDownloadID,keyRelatedProductID,keyRelatedLabourID"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"123",
    ///             "keyRelatedProductID":"456"
    ///         },
    ///         {
    ///             "keyProductID":"123",
    ///             "keyRelatedDownloadID": "DWN1"
    ///         },
    ///         {
    ///             "keyDownloadID":"DWN1",
    ///             "keyRelatedLabourID": "LAB2"
    ///         },
    ///         {
    ///             "keyLabourID":"LAB1",
    ///             "keyRelatedProductID": "123"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentItemRelation : ESDocument
    {
        /// <summary>List of item relation records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordItemRelation[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the item relation data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="itemRelationRecords">list of item relation records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the item relation record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentItemRelation(int resultStatus, string message, ESDRecordItemRelation[] itemRelationRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = itemRelationRecords;
            this.configs = configs;
            if (itemRelationRecords != null)
            {
                this.totalDataRecords = itemRelationRecords.Length;
            }
        }
    }
}