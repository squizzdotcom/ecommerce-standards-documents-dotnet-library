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
    /// Ecommerce standards document that holds a list of supplier account records
    /// </summary>
    /// <example>
    /// An example of the Supplier Account Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.4,
    ///     "resultStatus": 1,
    ///     "message":"The supplier account data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keySupplierAccountID,keyPriceLevelID,supplierAccountCode,accountName,contactName,orgName,authorityNumbers,authorityNumberLabels,authorityNumberTypes,email,accountClass,paymentTypes,territory,shippingMethod,isOnHold,isOutsideBalance,isOutsideTerms,balance,limit,termsType,termsDescription,termsValue1,termsValue2"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keySupplierAccountID":"SUP1",
    ///             "keyPriceLevelID":"PL001",
    ///             "supplierAccountCode":"SUP001"
    ///         },
    ///         {
    ///             "keySupplierAccountID":"SUP2",
    ///             "keyPriceLevelID":"PL004",
    ///             "supplierAccountCode":"SUPL004",
    ///             "accountName":"Suppliers Inc.",
    ///             "contactName":"John Smith",
    ///             "orgName":"Suppliers Inc.",
    ///             "authorityNumbers":["2342342334","3432424424243"],
    ///             "authorityNumberLabels":["ABN", "ACN"],
    ///             "authorityNumberTypes":[1,2],
    ///             "phone":"+610987654321",
    ///             "email":"js@esdstandards.somewhere",
    ///             "accountClass":"primary",
    ///             "paymentTypes":"CC",
    ///             "territory":"Melb Rural",
    ///             "shippingMethod":"Truck",
    ///             "isOnHold":"N",
    ///             "isOutsideBalance":"N",
    ///             "isOutsideTerms":"N",
    ///             "balance":1000.00,
    ///             "limit":0,
    ///             "termsType":"GND",
    ///             "termsDescription":"Pay before 14 days",
    ///             "termsValue1":"14",
    ///             "termsValue2":"",
    ///             "keyGLAccountID","6011-Stationery"
    ///         },
    ///         {
    ///             "keySupplierAccountID":"SUP3",
    ///             "keyPriceLevelID":"PL001",
    ///             "supplierAccountCode":"SUP003",
    ///             "accountName":"ESD Industries",
    ///             "contactName":"Joey Joe Joe",
    ///             "orgName":"ESD Industries",
    ///             "authorityNumber":"1234567890",
    ///             "authorityNumberLabel":"ABN",
    ///             "phone":"+61123456789",
    ///             "email":"esd@esdstandards.somewhere",
    ///             "accountClass":"secondary",
    ///             "paymentTypes":"AC,CC,DD",
    ///             "territory":"Melb Metro",
    ///             "discount":0,
    ///             "shippingMethod":"",
    ///             "isOnHold":"N",
    ///             "isOutsideBalance":"Y",
    ///             "isOutsideTerms":"N",
    ///             "balance":-2000.00,
    ///             "limit":1000,
    ///             "termsType":"DOM",
    ///             "termsDescription":"Pay on the 15th day of the month",
    ///             "termsValue1":"15",
    ///             "keyGLAccountID","6012-Electricity"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentSupplierAccount : ESDocument
    {
        /// <summary>List of supplier account records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordSupplierAccount[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the supplier account record data</param>
        /// <param name="message">message describing the status of obtaining the data for the document</param>
        /// <param name="supplierAccountRecords">list of supplier account records</param>
        /// <param name="configs">A list of key value pairs that contain additionally information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the supplier account record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentSupplierAccount(int resultStatus, string message, ESDRecordSupplierAccount[] supplierAccountRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = supplierAccountRecords;
            this.configs = configs;
            if (supplierAccountRecords != null)
            {
                this.totalDataRecords = supplierAccountRecords.Length;
            }
        }
    }
}
