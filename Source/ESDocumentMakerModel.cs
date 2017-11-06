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
    /// <summary>
    /// Ecommerce standards document that contains a list of model records associated to makers/manufacturers
    /// </summary>
    /// <example>
    /// An example of the Maker Model Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.2,
    ///     "resultStatus": 1,
    ///     "message":"The model data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyMakerModelID,keyMakerID,modelCode,modelSubCode,name,modelSearchCode,groupClass,releasedDate,createdDate,attributes"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyMakerModelID":"1"
    ///         },
    ///         {
    ///             "keyMakerModelID":"2",
    ///             "keyMakerID":"2",
    ///             "modelCode":"SEDAN1",
    ///             "modelSubCode":"1ABC",
    ///             "name":"Sahara Luxury Sedan 2016",
    ///             "modelSearchCode":"Car-Manufacturer-A-Saraha-Luxury-Sedan-2016",
    ///             "groupClass":"SEDAN",
    ///             "releasedDate": 1456750800000,
    ///             "createdDate": 1430748000000,
    ///             "attributes":
    ///             [
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-TYPE",
    ///                     "stringValue": "Sedan"
    ///                 },
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-ENGINE-CYLINDERS",
    ///                     "numberValue": 4
    ///                 },
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-FUEL-TANK-LITRES",
    ///                     "numberValue": 80.5
    ///                 }
    ///             ]
    ///         },
    ///         {
    ///             "keyMakerModelID":"3",
    ///             "keyMakerID":"2",
    ///             "modelCode":"TRUCK22",
    ///             "modelSubCode":"EX",
    ///             "name":"City Truck 2016",
    ///             "modelSearchCode":"Car-Manufacturer-A-City-Truck-2016",
    ///             "groupClass":TRUCK",
    ///             "releasedDate": 1456750800000,
    ///             "createdDate": 1430748000000,
    ///             "attributes":
    ///             [
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-TYPE",
    ///                     "stringValue": "Truck"
    ///                 },
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-ENGINE-CYLINDERS",
    ///                     "numberValue": 6
    ///                 },
    ///                 {
    ///                     "keyAttributeProfileID":"MAKEMODELCAR",
    ///                     "keyAttributeID":"MMCAR-FUEL-TANK-LITRES",
    ///                     "numberValue": 140
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentMakerModel : ESDocument
    {
        /// <summary>List of maker/manufacturer model records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordMakerModel[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the model data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="modelRecords">list of model records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the model record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentMakerModel(int resultStatus, string message, ESDRecordMakerModel[] modelRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = modelRecords;
            this.configs = configs;
            if (modelRecords != null)
            {
                this.totalDataRecords = modelRecords.Length;
            }
        }
    }
}
