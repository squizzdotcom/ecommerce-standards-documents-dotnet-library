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
    /// Ecommerce standards document that contains a list of attribute records associated with products, as well as a list of attribute profile records
    /// </summary>
    /// <example>
    /// An example of the Product Attribute Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product attribute data has been successfully obtained.",
    ///     "configs":{},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 0.5,
    ///     "totalDataRecords": 4,
    ///     "productAttributeProfiles":
    ///     [
    ///         {
    ///             "keyAttributeProfileID":"PAP-001"
    ///         },
    ///         {
    ///             "keyAttributeProfileID":"PAP002",
    ///             "name":"Clothing Styling",
    ///             "description":"View the styling details of clothes",
    ///             "productAttributes":
    ///             [
    ///                 {
    ///                     "keyProductAttributeID":"PAP002-0"
    ///                 },
    ///                 {
    ///                     "keyProductAttributeID":"PAP002-1",
    ///                     "name":"Colour"
    ///                 },
    ///                 {
    ///                     "keyProductAttributeID":"PAP002-2",
    ///                     "name":"Size",
    ///                     "dataType":"NUMBER"
    ///                 },
    ///                 {
    ///                     "keyProductAttributeID":"PAP002-3",
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
    public class ESDocumentProductAttribute : ESDocument
    {
        /// <summary>List of product attribute profile records</summary>
        [JsonProperty(Order = -3, Required = Required.Always)]
        [DataMember(IsRequired = true, Order=1)]
        public ESDRecordProductAttributeProfile[] productAttributeProfiles;
        /// <summary>List of product attribute value records</summary>
        [JsonProperty(Order = -2, Required = Required.Always)]
        [DataMember(IsRequired = true, Order=2)]
        public ESDRecordProductAttributeValue[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product attribute data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="productAttributeProfileRecords">list of product attribute profile records</param>
        /// <param name="productAttributeValueRecords">list of product attribute value records that assign attribute values to products</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the product attribute record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentProductAttribute(int resultStatus, string message, ESDRecordProductAttributeProfile[] productAttributeProfileRecords, ESDRecordProductAttributeValue[] productAttributeValueRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.productAttributeProfiles = productAttributeProfileRecords;
            this.dataRecords = productAttributeValueRecords;
            this.configs = configs;
        }
    }
}
