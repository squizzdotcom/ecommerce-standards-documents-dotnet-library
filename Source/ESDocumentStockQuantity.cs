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
    /// <summary>Ecommerce standards document that contains a list of stock quantity records</summary>
    /// <example>
    /// An example of the Stock Quantity Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The product stock quantity data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyProductID,qtyAvailable,qtyOnHand,qtyOrdered,qtyOrdered,qtyBackordered,qtyReserved,qtyConsigned"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"123A",
    ///             "qtyAvailable": 22
    ///         },
    ///         {
    ///             "keyProductID":"1234",
    ///             "qtyAvailable": 16,
    ///             "qtyOnHand": 20,
    ///             "qtyOrdered": 15,
    ///             "qtyOrderable": 1000
    ///             "qtyBackordered": 10,
    ///             "qtyReserved": 2,
    ///             "qtyConsigned": 12
    ///         },
    ///         {
    ///             "keyProductID":"7890",
    ///             "qtyAvailable": -23,
    ///             "qtyOnHand": 20,
    ///             "qtyOrdered": 15
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentStockQuantity : ESDocument
    {
        /// <summary>List of stock quantity records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordStockQuantity[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the stock quantity data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="stockQuantityRecords">list of stock quantity records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the stock quantity record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentStockQuantity(int resultStatus, string message, ESDRecordStockQuantity[] stockQuantityRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = stockQuantityRecords;
            this.configs = configs;
            if (stockQuantityRecords != null)
            {
                this.totalDataRecords = stockQuantityRecords.Length;
            }
        }
    }
}
