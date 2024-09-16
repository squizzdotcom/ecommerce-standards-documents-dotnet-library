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
    /// Ecommerce standards document that contains a list of asset component records, that define the relationships between assets, and the components that make up an asset.
    /// </summary>
    /// <example>
    /// An example of the Asset Component Ecommerce Standards document in its JSON serialised form
    /// <code>
    ///  {
    ///     "resultStatus":"1",
    ///     "message":"The asset data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyAssetID,assetCode,keyTaxcodeID,assetSearchCode,barcode,barcodeInner,brand,name,description1,description2,description3,description4,assetClass,keySellUnitID,unit,createdDate,destroyedDate,weight,width,height,depth,widthUnitMeasureCode,heightUnitMeasureCode,depthUnitMeasureCode,weightUnitMeasureCode,isPriceTaxInclusive"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.5,
    ///     "totalDataRecords": 2,
    ///     "dataRecords":
    ///     [
    ///         {
    ///             "keyAssetID":"123A",
    ///             "keyCategoryID":"PAPER",
    ///             "keyChildAssetID":"1234",
    ///             "attributes": [
    ///                 {
    ///                     "keyAttributeProfileID": "PAPER",
    ///                     "keyAttributeID": "PAPER-COLOUR",
    ///                     "stringValue": "GREEN"
    ///                 },
    ///                 {
    ///                     "keyAttributeProfileID": "PAPER",
    ///                     "keyAttributeID": "PAPER-WIDTH-MM",
    ///                     "numberValue": "2"
    ///                 }
    ///             ]
    ///         },
    ///         {
    ///             "keyAssetID":"1236",
    ///             "keyCategoryID":"ASSET-001",
    ///             "keyChildAssetID":"1234-ABC1",
    ///             "attributes":[]
    ///         }
    ///     ]
    ///  }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentAssetComponent : ESDocument
    {
        /// <summary>List of asset component records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordAssetComponent[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the asset component data</param>
        /// <param name="message">message describing the status of obtaining the data for the document</param>
        /// <param name="assetComponentRecords">list of asset component records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the asset component record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentAssetComponent(int resultStatus, string message, ESDRecordAssetComponent[] assetComponentRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = assetComponentRecords;
            this.configs = configs;
            if (assetComponentRecords != null)
            {
                this.totalDataRecords = assetComponentRecords.Length;
            }
        }
    }
}
