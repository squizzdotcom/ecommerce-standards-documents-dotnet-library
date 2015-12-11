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
    /// <summary>Ecommerce standards document that contains a list of product combination records, and a list of product combination profile records</summary>
    /// <example>
    /// An example of the Product Combinations Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product combination data has been successfully obtained.",
    ///     "configs":{},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 2,
    ///     "combinationProfiles":
    ///     [
    ///         {
    ///             "keyComboProfileID":"PROF-123",
    ///             "combinationFields":[]
    ///         },
    ///         {
    ///             "keyComboProfileID":"PROF-456",
    ///             "profileName":"Furniture Styling",
    ///             "description":"Styling of Furniture Products",
    ///             "combinationFields":
    ///             [
    ///                 {
    ///                     "keyComboProfileFieldID":"PROF-456-1",
    ///                     "fieldValues":[],
    ///                     "fieldValueIDs":[]
    ///                 },
    ///                 {
    ///                     "keyComboProfileFieldID":"PROF-456-2",
    ///                     "fieldName":"Size",
    ///                     "ordering": 2,
    ///                     "fieldValues": ["Small","Medium","Large","Jumbo"],
    ///                     "fieldValueIDs": ["PROF-456-2-SM","PROF-456-2-MED","PROF-456-2-LARG","PROF-456-2-JUM"]
    ///                 },
    ///                 {
    ///                     "keyComboProfileFieldID":"PROF-456-4",
    ///                     "fieldName":"Style",
    ///                     "ordering": 1,
    ///                     "fieldValues": ["Classic","Modern","Vintage","Minimalist"],
    ///                     "fieldValueIDs": ["COMBO-VAL-CL","COMBO-VAL-MOD","COMBO-VAL-VINT","COMBO-VAL-MIN"]
    ///                 }
    ///             ]
    ///         }
    ///     ],
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"678",
    ///             "keyComboProfileID":"PROF-123",
    ///             "productCombinations":[]
    ///         },
    ///         {
    ///             "keyProductID": "679",
    ///             "keyComboProfileID": "PROF-456",
    ///             "productCombinations": 
    ///             [
    ///                 {
    ///                     "keyProductID":"SOFTA-123",
    ///                     "keyComboProfileID":"PROF-456",
    ///                     "fieldValueCombinations"[
    ///                         ["PROF-456-2","PROF-456-2-SM"],
    ///                         ["PROF-456-4","COMBO-VAL-CL"]
    ///                     ]
    ///                 },
    ///                 {
    ///                     "keyProductID":"SOFTA-456",
    ///                     "keyComboProfileID":"PROF-456",
    ///                     "fieldValueCombinations"[
    ///                         ["PROF-456-2","PROF-456-2-SM"],
    ///                         ["PROF-456-4","COMBO-VAL-CL"]
    ///                     ]
    ///                 },
    ///                 {
    ///                     "keyProductID":"SOFTA-098",
    ///                     "keyComboProfileID":"PROF-456",
    ///                     "fieldValueCombinations"[
    ///                         ["PROF-456-2","PROF-456-2-MED"],
    ///                         ["PROF-456-4","COMBO-VAL-CL"]
    ///                     ]
    ///                 }
    ///             ],
    ///             "defaultCombination": 2
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentProductCombination: ESDocument
    {
        /// <summary>List of product combination profile records</summary>
        [JsonProperty(Order = -3, Required = Required.Always)]
        [DataMember(IsRequired = true, Order = 1)]
        public ESDRecordCombinationProfile[] combinationProfiles;
        /// <summary>List of product combination records</summary>
        [JsonProperty(Order = -2, Required = Required.Always)]
        [DataMember(IsRequired = true, Order = 2)]
        public ESDRecordProductCombinationParent[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product combination data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="productCombinationParentRecords">list of product combination parent records</param>
        /// <param name="combinationProfileRecords">list of product combination profile records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the product combination record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentProductCombination(int resultStatus, string message, ESDRecordProductCombinationParent[] productCombinationParentRecords, ESDRecordCombinationProfile[] combinationProfileRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = productCombinationParentRecords;
            this.configs = configs;
            this.combinationProfiles = combinationProfileRecords;
        }
    }
}
