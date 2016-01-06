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
    /// Ecommerce standards document that contains a list of sell unit records
    /// </summary>
    /// <example>
    /// An example of the Sell Unit Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The sell unit data has been successfully obtained.",
    ///     "configs":{"dataFields":"keySellUnitID,sellUnitCode,sellUnitLabel,isBaseUnit,baseQuantity,parentQuantity,keySellUnitParentID"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 3,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keySellUnitID":"1"
    ///         },
    ///         {
    ///             "keySellUnitID":"2",
    ///             "sellUnitCode":"EA",
    ///             "sellUnitLabel":"EACH",
    ///             "isBaseUnit":"Y",
    ///             "baseQuantity": 1
    ///         },
    ///         {
    ///             "keySellUnitID":"3",
    ///             "sellUnitCode":"PK6",
    ///             "sellUnitLabel":"Pack Of 6",
    ///             "isBaseUnit":"N",
    ///             "baseQuantity": 6,
    ///             "parentQuantity": 6,
    ///             "keySellUnitParentID":"2"
    ///         },
    ///         {
    ///             "keySellUnitID":"4",
    ///             "sellUnitCode":"CT-4-6",
    ///             "sellUnitLabel":"Carton (4 packs of 6)",
    ///             "isBaseUnit":"N",
    ///             "baseQuantity": 24,
    ///             "parentQuantity": 4,
    ///             "keySellUnitParentID":"3"
    ///         },
    ///         {
    ///             "keySellUnitID":"5",
    ///             "sellUnitCode":"CN-50",
    ///             "sellUnitLabel":"Container (50 Cartons)",
    ///             "isBaseUnit":"N",
    ///             "baseQuantity": 1200,
    ///             "parentQuantity": 50,
    ///             "keySellUnitParentID":"4"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentSellUnit : ESDocument
    {
        /// <summary>List of sell unit records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordSellUnit[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="sellUnitRecords">list of sell unit records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the sell unit record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentSellUnit(int resultStatus, string message, ESDRecordSellUnit[] sellUnitRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = sellUnitRecords;
            this.configs = configs;
            if (sellUnitRecords != null)
            {
                this.totalDataRecords = sellUnitRecords.Length;
            }
        }
    }
}
