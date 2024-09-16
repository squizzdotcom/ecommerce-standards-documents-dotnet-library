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
    /// Ecommerce standards document that contains a list of delivery notice records
    /// </summary>
    /// <example>
    /// An example of the Delivery Notice Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    /// 	"resultStatus": "1",
    /// 	"message": "The delivery notice data has been successfully obtained.",
    /// 	"configs": {
    /// 		
    /// 	},
    /// 	"dataTransferMode": "COMPLETE",
    /// 	"version": 1.4,
    /// 	"totalDataRecords": 2,
    /// 	"dataRecords": [{
    /// 		"keyDeliveryNoticeID": "123"
    /// 	},
    /// 	{
    /// 		"keyDeliveryNoticeID": "2231321",
    /// 		"deliveryNoticeCode": "DEL-123",
    /// 		"deliveryStatus": "IN_TRANSIT",
    /// 		"deliveryStatusMessage": "The ordered goods have left the warehouse and are in transit.",
    /// 		"keyCustomerAccountID": "222",
    /// 		"keySupplierAccountID": "",
    /// 		"deliveryPurchaseOrderCode": "PO-34342-1",
    /// 		"language": "EN_AU",
    /// 		"packedDate": 1448130083084,
    /// 		"loadedDate": 1449131083084,
    /// 		"dispatchedDate": 1450132083084,
    /// 		"deliveryDate": 1450133083084,
    /// 		"receivedDate": 0,
    /// 		"deliveredDate": 0,
    /// 		"unpackedDate": 0,
    /// 		"lostDate": 0,
    /// 		"damagedDate": 0,
    /// 		"cancelledDate": 0,
    /// 		"atGeographicLocation": "Y",
    /// 		"locationLatitude": -37.8102907,
    /// 		"locationLongitude": 144.9608443,
    /// 		"instructions": "Please leave the goods at the back door",
    /// 		"freightCarrierCode": "ACME-F",
    /// 		"freightCarrierName": "Acme Freight Carrier",
    /// 		"freightSystemRefCode": "334234-23423-234-343242",
    /// 		"freightCarrierConsignCode": "34423423424",
    /// 		"freightCarrierTrackingCode": "767567-56765-5676567",
    /// 		"freightCarrierServiceCode": "ROUTING-FREIGHT",
    /// 		"freightCarrierAccountCode": "FREI-1234",
    /// 		"isDropship": "N",
    /// 		"lines": [{
    /// 			"keyDeliveryNoticeLineID": "123"
    /// 		},
    /// 		{
    /// 			"keyDeliveryNoticeLineID": "456",
    /// 			"deliveryLineCode": "DEL-LINE-001",
    /// 			"invoiceCode": "INV-123",
    /// 			"invoiceLineCode": "INV-LINE-001",
    /// 			"purchaseOrderLineCode": "PO-LINE-3",
    /// 			"purchaseOrderLineNumber": "3",
    /// 			"keySellUnitID": "EACH",
    /// 			"keyProductID": "123",
    /// 			"productCode": "SWISH-123",
    /// 			"productName": "Swisho Paper A4",
    /// 			"customerProductCode": "PAPER-A4-SWISHO",
    /// 			"quantityDelivered": 5
    /// 		}]
    /// 	}]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentDeliveryNotice : ESDocument
    {
        /// <summary>List of delivery notices</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordDeliveryNotice[] dataRecords = new ESDRecordDeliveryNotice[]{};

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the delivery notice data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="deliveryNotices">list of delivery notice records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.</param>
        public ESDocumentDeliveryNotice(int resultStatus, string message, ESDRecordDeliveryNotice[] deliveryNotices, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = deliveryNotices;
            this.configs = configs;
            if (deliveryNotices != null)
            {
                this.totalDataRecords = deliveryNotices.Length;
            }    
        }
    }
}