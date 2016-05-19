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
    /// Ecommerce standards document that contains a list of pricing records for either products, downloads, or labour
    /// </summary>
    /// <example>
    /// An example of the Product Pricing Ecommerce Standards document in its JSON serialised form, containing product price-level data
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product price-level pricing data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyProductID,keyPriceLevelID,keySellUnitID,price"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.1,
    ///     "totalDataRecords": 4,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-001",
    ///             "keySellUnitID": 1,
    ///             "price": 10.00
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-002",
    ///             "keySellUnitID": 1,
    ///             "price": 8.00
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-003",
    ///             "keySellUnitID": 1,
    ///             "price": 5.00
    ///         },
    ///         {
    ///             "keyProductID":"PROD-456",
    ///             "keyPriceLevelID":"PL-001",
    ///             "keySellUnitID": 1,
    ///             "price": 22.00
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Product Pricing Ecommerce Standards document in its JSON serialised form, containing product price-level quantity break data
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product price-level quantity break pricing data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyProductID,keyPriceLevelID,price,quantity"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 4,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-001",
    ///             "price": 10.00,
    ///             "quantity": 5
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-001",
    ///             "price": 5.00,
    ///             "quantity": 10
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-001",
    ///             "price": 2.00,
    ///             "quantity": 20
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-002",
    ///             "price": 4.10,
    ///             "quantity": 5
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Product Pricing Ecommerce Standards document in its JSON serialised form, containing customer account product pricing data
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product customer account pricing data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyProductID,keyAccountID,price,quantity,referenceID,referenceType"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 4,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyAccountID":"ACC-123",
    ///             "price": 70.00,
    ///             "quantity": 5,
    ///             "referenceID": "FORCED-CONTRACT-1",
    ///             "referenceType": "CF"
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyAccountID":"ACC-123",
    ///             "price": 1.00,
    ///             "quantity": 20,
    ///             "referenceID": "FORCED-CONTRACT-1",
    ///             "referenceType": "CF"
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyAccountID":"ACC-456",
    ///             "price": 7.30,
    ///             "quantity": 1,
    ///             "referenceID": "CONTRACT-222",
    ///             "referenceType": "C"
    ///         },
    ///         {
    ///             "keyProductID":"PROD-456",
    ///             "keyAccountID":"ACC-456",
    ///             "price": 3.30
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Product Pricing Ecommerce Standards document in its JSON serialised form, containing product pricing data that has been grouped and applied to multiple customer accounts assigned to each group
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product customer account pricing data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyProductID,keyPriceGroupID,keySellUnitID,price,quantity,referenceID,referenceType"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 4,
    ///     "priceGroups":
    ///     {
    ///         "PRICE-GROUP-1": ["ACC-1","ACC-2","ACC-3","ACC-4"],
    ///         "PRICE-GROUP-2": ["ACC-5","ACC-6","ACC-7","ACC-8"]
    ///     },
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceGroupID":"PRICE-GROUP-1",
    ///             "price": 3.30,
    ///             "quantity": 1
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceGroupID":"PRICE-GROUP-2",
    ///             "keySellUnitID": 1,
    ///             "price": 2.90,
    ///             "quantity": 1,
    ///             "referenceID": "FORCED-CONTRACT-1",
    ///             "referenceType": "CF"
    ///         },
    ///         {
    ///             "keyProductID":"PROD-456",
    ///             "keyPriceGroupID":"PRICE-GROUP-2",
    ///             "keySellUnitID": 1,
    ///             "price": 0.255,
    ///             "quantity": 50
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Product Pricing Ecommerce Standards document in its JSON serialised form, containing product price-level data with only record changes
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product price-level pricing data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyProductID,keyPriceLevelID,keySellUnitID,drop"},
    ///     "dataTransferMode": "INCREMENT",
    ///     "version": 1.0,
    ///     "totalDataRecords": 5,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-006",
    ///             "keySellUnitID": 1,
    ///             "price": 22.00,
    ///             "drop": 1
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-002",
    ///             "keySellUnitID": 1,
    ///             "price": 11.00,
    ///             "drop": 2
    ///         },
    ///         {
    ///             "keyProductID":"PROD-123",
    ///             "keyPriceLevelID":"PL-003",
    ///             "keySellUnitID": 1,
    ///             "drop": 3
    ///         },
    ///         {
    ///             "keyProductID":"PROD-456",
    ///             "keyPriceLevelID":"PL-001",
    ///             "keySellUnitID": 1,
    ///             "drop": 4
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentPrice : ESDocument
    {
        /// <summary>Dictionary that contains records keyed on keyPriceGroupID, containing arrays of customer accounts for each group, based on setting the customer account's keyCustomerAccountID in each array</summary>
        [JsonProperty(Order = -3)]
        [DataMember(EmitDefaultValue = false, Order = 1)]
        public Dictionary<string, string[]> priceGroups { get; set; }

        /// <summary>List of product price records</summary>
        [JsonProperty(Order = -2)]
        [DataMember(Order=2)]
        public ESDRecordPrice[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product pricing data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="productPriceRecords">list of product price records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the product price record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentPrice(int resultStatus, string message, ESDRecordPrice[] productPriceRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = productPriceRecords;
            this.configs = configs;
            if (productPriceRecords != null)
            {
                this.totalDataRecords = productPriceRecords.Length;
            }
        }
    }
}
