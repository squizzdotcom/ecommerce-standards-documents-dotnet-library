/// <remarks>
/// Copyright (C) Squizz PTY LTD
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
    /// Ecommerce standards document that contains a list of category records, and a list of category tree records
    /// </summary>
    /// <example>
    /// An example of the Category Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.4,
    ///     "resultStatus": 1,
    ///     "message":"The category data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{
    ///         "dataFieldsCategoryTree":"keyCategoryTreeID,categoryTreeCode,name,description,ordering,isMakerModelCategoryTree",
    ///         "dataFields":"keyCategoryID,categoryCode,keyCategoryParentID,name,description1,description2,description3,description4,metaTitle,metaKeywords,metaDescription,ordering"
    ///     },
    ///     "categoryTreeRecords":
    ///     [
    ///         {
    ///             "keyCategoryTreeID":"1",
    ///             "name":"Product Catalogue",
    ///         },
    ///         {
    ///             "keyCategoryTreeID":"2-BRANDS",
    ///             "categoryTreeCode":"BRANDS",
    ///             "name":"Product Brands",
    ///             "description":"View all the brands of products we sell.",
    ///             "ordering":2,
    ///             "isMakerModelCategoryTree": "N"
    ///         },
    ///         {
    ///             "keyCategoryTreeID":"3-MAKE-MODEL",
    ///             "categoryTreeCode":"MAKEMODEL",
    ///             "name":"Make Model",
    ///             "description":"Contains categories that allow products belonging to each model of a maker/manufacturer to be assigned to.",
    ///             "ordering":3,
    ///             "isMakerModelCategoryTree": "Y"
    ///         }
    ///     ],
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyCategoryID":"2",
    ///             "categoryCode":"Home and Stationery"
    ///         },
    ///         {
    ///             "keyCategoryID":"123",
    ///             "categoryCode":"tables-chairs",
    ///             "keyCategoryTreeID":"1",
    ///             "keyCategoryParentID":"2",
    ///             "name":"Tables and Chairs",
    ///             "description1":"View our extensive range of tables and chairs",
    ///             "description2":"Range includes products from the ESD designers",
    ///             "description3":"",
    ///             "description4":"",
    ///             "metaTitle":"Tables and Chairs From ESD Designers",
    ///             "metaKeywords":"tables chairs esd furniture designers",
    ///             "metaDescription":"Tables and chairs from the ESD designers",
    ///             "ordering": 2,
    ///             "keyProductIDs":["TAB-1","53432","CHAIR-5"],
    ///             "keyDownloadIDs":[],
    ///             "keyLabourIDs":[]
    ///         },
    ///         {
    ///             "keyCategoryID":"124",
    ///             "categoryCode":"paper",
    ///             "keyCategoryTreeID":"1",
    ///             "keyCategoryParentID":"2",
    ///             "name":"Paper Products",
    ///             "description1":"View our extensive range of paper",
    ///             "description2":"Range includes paper only sources from sustainable environments",
    ///             "description3":"",
    ///             "description4":"",
    ///             "metaTitle":"Paper Products",
    ///             "metaKeywords":"paper products environmental",
    ///             "metaDescription":"Paper products from sustainable environments",
    ///             "ordering": 1,
    ///             "keyProductIDs":["PROD-001","PROD-002"],
    ///             "keyDownloadIDs":["DOWN-1", "DOWN-2","DOWN-3"],
    ///             "keyLabourIDs":[]
    ///         },
    ///         {
    ///             "keyCategoryID":"124",
    ///             "categoryCode":"acme-brand",
    ///             "keyCategoryTreeID":"2-BRANDS",
    ///             "keyCategoryParentID":null,
    ///             "name":"Paper Products",
    ///             "description1":"View All Acme Brand's products",
    ///             "description2":"Range shows all products made by the Acme corporation.",
    ///             "description3":"",
    ///             "description4":"",
    ///             "metaTitle":"Acme Products",
    ///             "metaKeywords":"",
    ///             "metaDescription":"",
    ///             "ordering": 1,
    ///             "keyProductIDs":["PROD-003","PROD-004"],
    ///             "keyDownloadIDs":[],
    ///             "keyLabourIDs":[]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentCategory : ESDocument
    {
        /// <summary>List of category tree records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordCategoryTree[] categoryTreeRecords;

        /// <summary>List of category records</summary>
        [JsonProperty(Order = -3)]
        [DataMember]
        public ESDRecordCategory[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the category data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="categoryRecords">list of category records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the category record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentCategory(int resultStatus, string message, ESDRecordCategory[] categoryRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.categoryTreeRecords = new ESDRecordCategoryTree[0];
            this.dataRecords = categoryRecords;
            this.configs = configs;
            if (categoryRecords != null)
            {
                this.totalDataRecords = categoryRecords.Length;
            }
        }

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the category data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="categoryTreeRecords">list of category tree records</param>
        /// <param name="categoryRecords">list of category records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the category record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        [JsonConstructor]
        public ESDocumentCategory(int resultStatus, string message, ESDRecordCategoryTree[] categoryTreeRecords, ESDRecordCategory[] categoryRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.categoryTreeRecords = categoryTreeRecords;
            this.dataRecords = categoryRecords;
            this.configs = configs;
            if (categoryRecords != null)
            {
                this.totalDataRecords = categoryRecords.Length;
            }
        }
    }
}
