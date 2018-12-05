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
    /// Ecommerce standards document that contains a list of maker model mappings records that associate product, download, or labour records to categories within models manufactured or assembled by makers/manufacturers
    /// </summary>
    /// <example>
    /// An example of the Maker Model Item Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.2,
    ///     "resultStatus": 1,
    ///     "message":"The maker-model-mapping data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyMakerModelID,keyCategoryID,keyProductID,quantity,attributes"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyMakerModelID":"2",
    ///             "keyCategoryID":"CAR-TYRE",
    ///             "keyProductID":"CAR-TYRE-LONG-LASTING",
    ///             "quantity": 4,
    ///             "attributes":
    ///             [
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-WHEELSIZE-RADIUS-INCH",
    ///                     "numberValue": 21
    ///                 },
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-WHEELSIZE-TREAD",
    ///                     "stringValue": "All Weather"
    ///                 }
    ///             ]
    ///         },
    ///         {
    ///             "keyMakerModelID":"2",
    ///             "keyCategoryID":"CAR-TYRE",
    ///             "keyProductID":"CAR-TYRE-CHEAP",
    ///             "quantity": 4,
    ///             "attributes":
    ///             [
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-WHEELSIZE-RADIUS-INCH",
    ///                     "numberValue": 20
    ///                 },
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-WHEELSIZE-TREAD",
    ///                     "stringValue": "BITUMEN"
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentMakerModelMapping : ESDocument
    {
        /// <summary>List of maker/manufacturer model records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordMakerModelMapping[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the model mapping data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="modelMappingRecords">list of model mapping records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the model mapping record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentMakerModelMapping(int resultStatus, string message, ESDRecordMakerModelMapping[] modelMappingRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = modelMappingRecords;
            this.configs = configs;
            if (modelMappingRecords != null)
            {
                this.totalDataRecords = modelMappingRecords.Length;
            }
        }
    }
}
