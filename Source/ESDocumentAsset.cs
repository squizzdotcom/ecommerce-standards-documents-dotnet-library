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
    /// Ecommerce standards document that contains a list of asset records
    /// </summary>
    /// <example>
    /// An example of the Asset Ecommerce Standards document in its JSON serialised form
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
    ///             "assetCode":"ASSET-123",
    ///             "keyTaxcodeID":"FREE"
    ///         },
    ///         {
    ///             "keyAssetID":"1234",
    ///             "assetCode":"ASSET-001",
    ///             "keyTaxcodeID":"GST",
    ///             "assetSearchCode":"Green-Recycled-Paper-Swisho",
    ///             "barcode":"03423404230",
    ///             "barcodeInner":"234234",
    ///             "brand":"Swisho Paper",
    ///             "name":"Swisho Green Paper",
    ///             "description1":"Swisho green coloured paper is the ultimate green paper.",
    ///             "description2":"Paper built strong and tough by Swisho",
    ///             "description3":"Recommended to be used with dark inks.",
    ///             "description4":"",
    ///             "assetClass":"paper",
    ///             "unit":"REAM",
    ///             "weight": 20.1,
    ///             "width": 21,
    ///             "height": 29.7,
    ///             "depth": 10,
    ///             "widthUnitMeasureCode": "CM",
    ///             "heightUnitMeasureCode": "CM",
    ///             "depthUnitMeasureCode": "CM",
    ///             "weightUnitMeasureCode": "KG",
    ///             "isPriceTaxInclusive": "N",
    ///             "keySellUnitID": 2,
    ///             "sellUnits":[
    ///                 {
    ///                     "keySellUnitID":"2",
    ///                     "weight": 1.2,
    ///                     "width": 6.1,
    ///                     "height": 4.4,
    ///                     "depth": 2.9,
    ///                     "packageWeight": 2.3,
    ///                     "packageWidth": 8.0,
    ///                     "packageHeight": 9.2,
    ///                     "packageDepth": 10.1,
    ///                     "widthUnitMeasureCode":"CM",
    ///                     "heightUnitMeasureCode":"CM",
    ///                     "depthUnitMeasureCode":"CM",
    ///                     "weightUnitMeasureCode":"KG"
    ///                 }
    ///             ]
    ///         }
    ///     ]
    ///  }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentAsset : ESDocument
    {
        /// <summary>List of asset records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordAsset[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the asset data</param>
        /// <param name="message">message describing the status of obtaining the data for the document</param>
        /// <param name="assetRecords">list of asset records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the asset record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentAsset(int resultStatus, string message, ESDRecordAsset[] assetRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = assetRecords;
            this.configs = configs;
            if (assetRecords != null)
            {
                this.totalDataRecords = assetRecords.Length;
            }
        }
    }
}
