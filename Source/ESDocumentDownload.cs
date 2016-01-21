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
    /// <summary>Ecommerce standards document that contains a list of download records.</summary>
    /// <example>
    /// An example of the Download Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The download data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyDownloadID,downloadCode,keyTaxcodeID,downloadSearchCode,downloadLocation,downloadKey,downloadSize,brand,name,description1,description2,description3,description4,downloadClass,averageCost,supplier,deliveryTimeNoStock,deliveryTimeInStock,downloadQuantity,downloadNoneQuantity,downloadLowQuantity,isPriceTaxInclusive,isKitted,kitSetPrice"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 2,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyDownloadID":"DWN1",
    ///             "downloadCode":"Download 123",
    ///             "keyTaxcodeID":"FREE"
    ///         },
    ///         {
    ///             "keyDownloadID":"DOW2",
    ///             "downloadCode":"Download 2",
    ///             "keyTaxcodeID":"GST",
    ///             "downloadSearchCode":"Music-My-Rock-Band-Standards-Track",
    ///             "downloadLocation":"http://www.somelocation.com/MyRockBand/Track01.mp3",
    ///             "downloadKey":"234234wASFD#EF#2342342S23432234324332ASAFSD",
    ///             "downloadSize": 123451235123,
    ///             "brand":"My Rock Band",
    ///             "name":"Track01 - Standards",
    ///             "description1":"Listen to My Rock Band's first track off their new album called Standards.",
    ///             "description2":"",
    ///             "description3":"",
    ///             "description4":"",
    ///             "downloadClass":"ABC",
    ///             "averageCost": 10.00,
    ///             "supplier":"ESD Music Distributor",
    ///             "deliveryTimeNoStock": 112112,
    ///             "deliveryTimeInStock": 1212,
    ///             "downloadQuantity": 200,
    ///             "downloadNoneQuantity": 0,
    ///             "downloadLowQuantity": 10,
    ///             "isPriceTaxInclusive": "N",
    ///             "isKitted":"N",
    ///             "kitSetPrice":"N"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentDownload : ESDocument
    {
        /// <summary>List of download records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordProduct[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the download data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="downloadRecords">list of download records</param>
        [JsonConstructor]
        public ESDocumentDownload(int resultStatus, string message, ESDRecordProduct[] downloadRecords)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = downloadRecords;
            configs = new Dictionary<string, string>();
        }

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the download data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="downloadRecords">list of download records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the download record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentDownload(int resultStatus, string message, ESDRecordProduct[] downloadRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = downloadRecords;
            this.configs = configs;
            if (downloadRecords != null)
            {
                this.totalDataRecords = downloadRecords.Length;
            }
        }
    }
}
