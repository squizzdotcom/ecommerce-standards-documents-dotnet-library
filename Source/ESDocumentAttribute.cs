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
    /// Ecommerce standards document that contains a list of attribute records associated with products, download, and labour, as well as a list of attribute profile records
    /// </summary>
    /// <example>
    /// An example of the Attribute Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product attribute data has been successfully obtained.",
    ///     "configs":{},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 4,
    ///     "attributeProfiles":
    ///     [
    ///         {
    ///             "keyAttributeProfileID":"PAP-001"
    ///         },
    ///         {
    ///             "keyAttributeProfileID":"PAP002",
    ///             "name":"Clothing Styling",
    ///             "description":"View the styling details of clothes",
    ///             "attributes":
    ///             [
    ///                 {
    ///                     "keyAttributeID":"PAP002-0"
    ///                 },
    ///                 {
    ///                     "keyAttributeID":"PAP002-1",
    ///                     "name":"Colour"
    ///                 },
    ///                 {
    ///                     "keyAttributeID":"PAP002-2",
    ///                     "name":"Size",
    ///                     "dataType":"NUMBER"
    ///                 },
    ///                 {
    ///                     "keyAttributeID":"PAP002-3",
    ///                     "name":"Texture",
    ///                     "dataType":"STRING"
    ///                 }
    ///             ]
    ///         }
    ///     ],
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"PROD-001",
    ///             "keyAttributeProfileID":"PAP002",
    ///             "keyAttributeID":"PAP002-0"
    ///         },
    ///         {
    ///             "keyProductID":"PROD-001",
    ///             "keyAttributeProfileID":"PAP002",
    ///             "keyAttributeID":"PAP002-1",
    ///             "stringValue":"RED"
    ///         },
    ///         {
    ///             "keyProductID":"PROD-001",
    ///             "keyAttributeProfileID":"PAP002",
    ///             "keyAttributeID":"PAP002-2",
    ///             "numberValue": 8
    ///         },
    ///         {
    ///             "keyProductID":"PROD-001",
    ///             "keyAttributeProfileID":"PAP002",
    ///             "keyAttributeID":"PAP002-3",
    ///             "stringValue": "soft"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentAttribute : ESDocument
    {
        /// <summary>List of attribute profile records</summary>
        [JsonProperty(Order = -3, Required = Required.Always)]
        [DataMember(IsRequired = true, Order=1)]
        public ESDRecordAttributeProfile[] attributeProfiles;
        /// <summary>List of attribute value records</summary>
        [JsonProperty(Order = -2, Required = Required.Always)]
        [DataMember(IsRequired = true, Order=2)]
        public ESDRecordAttributeValue[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the attribute data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="attributeProfileRecords">list of attribute profile records</param>
        /// <param name="attributeValueRecords">list of attribute value records that assign attribute values to products, downloads, and labour</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the attribute record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentAttribute(int resultStatus, string message, ESDRecordAttributeProfile[] attributeProfileRecords, ESDRecordAttributeValue[] attributeValueRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.attributeProfiles = attributeProfileRecords;
            this.dataRecords = attributeValueRecords;
            this.configs = configs;
            if (attributeValueRecords != null)
            {
                this.totalDataRecords = attributeValueRecords.Length;
            }
        }
    }
}
