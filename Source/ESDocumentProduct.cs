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
    /// Ecommerce standards document that contains a list of product records
    /// </summary>
    /// <example>
    /// An example of the Product Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The product data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyProductID,productCode,keyTaxcodeID,productSearchCode,barcode,barcodeInner,brand,name,description1,description2,description3,description4,productClass,keySellUnitID,unit,weight,width,height,depth,averageCost,warehouse,supplier,deliveryTimeNoStock,deliveryTimeInStock,stockQuantity,stockNoneQuantity,stockLowQuantity,stockLowQuantity,isPriceTaxInclusive,isKitted,kitProductsSetPrice"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 0.5,
    ///     "totalDataRecords": 2,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductID":"123A",
    ///             "productCode":"PROD-123",
    ///             "keyTaxcodeID":"FREE"
    ///         },
    ///         {
    ///             "keyProductID":"1234",
    ///             "productCode":"PROD-001",
    ///             "keyTaxcodeID":"GST",
    ///             "productSearchCode":"Green-Recycled-Paper-Swisho",
    ///             "barcode":"03423404230",
    ///             "barcodeInner":"234234",
    ///             "brand":"Swisho Paper",
    ///             "name":"Swisho Green Paper",
    ///             "description1":"Swisho green coloured paper is the ultimate green paper.",
    ///             "description2":"Paper built strong and tough by Swisho",
    ///             "description3":"Recommended to be used with dark inks.",
    ///             "description4":"",
    ///             "productClass":"paper",
    ///             "keySellUnitID": 2,
    ///             "unit":"REAM",
    ///             "weight": 20.1,
    ///             "width":"21,
    ///             "height": 29.7,
    ///             "depth": 10,
    ///             "averageCost": 10.00,
    ///             "warehouse":"Swisho Warehouse",
    ///             "supplier":"Swisho",
    ///             "deliveryTimeNoStock": 112112,
    ///             "deliveryTimeInStock": 1212,
    ///             "stockQuantity": 200,
    ///             "stockNoneQuantity": 0,
    ///             "stockLowQuantity": 10,
    ///             "isPriceTaxInclusive": "N",
    ///             "isKitted":"N",
    ///             "kitProductsSetPrice":"N"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// 
    /// An example of the Product Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// using System;
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using System.Text;
    /// using EcommerceStandardsDocuments;
    /// 
    /// namespace MyApp
    /// {
    ///     public class MyClass
    ///     {
    ///     /// &lt;summary&gt; Obtains a list of products records contained within an a products Ecommerce Standards Document&lt;/summary&gt;
    ///     public ESDocumentProducts getProducts()
    ///     {
    ///         List&lt;ESDRecordProduct&gt; products = new List&lt;ESDRecord&gt;();
    ///         Dictionary&lt;string, string&gt; docConfigs = new Dictionary&lt;string, string&gt;();
    /// 
    ///         //create a new product Ecomerce Standards Document
    ///         ESDocumentProduct productsDoc = new ESDocumentProduct(ESDocumentConstants.RESULT_ERROR_UNKNOWN, "Unable to get product data.", null, null);
    ///         
    ///         //create a record for a tea towel product
    ///         ESDRecordProduct product1 = new ESDRecordProduct();
    ///         product1.keyProductID = "1";
    ///         product1.productCode = "PROD-1";
    ///         product1.name = "Tea Towels";
    ///         products.add(product1);
    ///        
    ///         //create another record for a kettle product
    ///        ESDRecordProduct product2 = new ESDRecordProduct();
    ///         product2.keyProductID = "2";
    ///         product2.productCode = "PROD-2";
    ///         product2.name = "Kettle";
    ///         products.add(product2);
    ///         
    ///         //in the document configs list all the properties of the product records that are being set, any properties not in the list can be ignored by the system when processing the product records
    ///         docConfigs.Add("dataFields","keyProductID,productCode,name");
    /// 
    ///         productsDoc.configs = docConfigs;
    ///         productsDoc.dataRecords = products.ToArray();
    ///         productsDoc.resultStatus = ESDocumentConstants.RESULT_SUCCESS;
    ///         productsDoc.message = "Product data has been successfully obtained.";
    ///         
    ///         return productsDoc;
    ///      }
    ///     }
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentProduct : ESDocument
    {
        /// <summary>List of product records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordProduct[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="productRecords">list of product records</param>
        public ESDocumentProduct(int resultStatus, string message, ESDRecordProduct[] productRecords)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = productRecords;
            configs = new Dictionary<string, string>();
        }

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the product data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="productRecords">list of product records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the product record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentProduct(int resultStatus, string message, ESDRecordProduct[] productRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = productRecords;
            this.configs = configs;
        }
    }
}
