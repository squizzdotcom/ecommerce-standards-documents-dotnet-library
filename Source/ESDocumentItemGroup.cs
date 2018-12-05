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
    /// <summary>Ecommerce standards document that contains a list of item group records</summary>
    /// <example>
    /// An example of the item group Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.2,
    ///     "resultStatus": 1,
    ///     "message":"The item group data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyItemGroupID,groupCode,groupLabel,groupDescription,keyDefaultProductID,keyDefaultDownloadID,keyDefaultLabourID"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyItemGroupID":"1"
    ///         },
    ///         {
    ///             "keyItemGroupID":"2",
    ///             "groupCode": "COL-TEATOWEL",
    ///             "groupLabel": "Coloured Teatowels",
    ///             "groupDescription": "Group contains an assorted number of teatowels, each styled with vibrant colours.",
    ///             "keyDefaultProductID": "456",
    ///             "keyDefaultDownloadID": "",
    ///             "keyDefaultLabourID": "",
    ///             "keyProductIDs": ["123","456","789","1000"],
    ///             "keyDownloadIDs": [],
    ///             "keyLabourIDs": []
    ///         },
    ///         {
    ///             "keyItemGroupID":"3",
    ///             "groupCode": "GRP-TV-SETUP",
    ///             "groupLabel": "Amazing TV Bundle",
    ///             "groupDescription": "Bundle contains everything you need to get a TV. It contains a television, labour to install the TV, and a downloadable manual to be able to use the TV.",
    ///             "keyDefaultProductID": "0987",
    ///             "keyDefaultDownloadID": "",
    ///             "keyDefaultLabourID": "",
    ///             "keyProductIDs": ["0987"],
    ///             "keyDownloadIDs": ["DOWN-9898"],
    ///             "keyLabourIDs": ["LAB-INSTALL"]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentItemGroup : ESDocument
    {
        /// <summary>List of item group records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordItemGroup[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the item group data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="itemGroupRecords">list of item group records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the item group record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentItemGroup(int resultStatus, string message, ESDRecordItemGroup[] itemGroupRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = itemGroupRecords;
            this.configs = configs;
            if (itemGroupRecords != null)
            {
                this.totalDataRecords = itemGroupRecords.Length;
            }
        }
    }
}