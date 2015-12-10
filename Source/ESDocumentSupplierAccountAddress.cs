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
    /// Ecommerce standards document that holds a list of address records for supplier accounts
    /// </summary>
    /// <example>
    /// An example of the Supplier Account Address Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "resultStatus":"1",
    ///     "message":"The supplier account address data has been successfully obtained.",
    ///     "configs":{"dataFields":"keyAddressID,keySupplierAccountID,description,orgName,contact,phone,fax,address1,address2,address3,region,country,postcode,freightCode,isPrimary,isDelivery"},
    ///     "dataTransferMode": "COMPLETE",
    ///     "version": 1.0,
    ///     "totalDataRecords": 3,
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyAddressID":"ADD-001"
    ///         },
    ///         {
    ///             "keyAddressID":"ADD002",
    ///             "keySupplierAccountID":"10",
    ///             "description":"Billing Address",
    ///             "orgName":"ESD Industries",
    ///             "contact":"John Doe",
    ///             "phone":"+61234567890",
    ///             "fax":"+612345678901",
    ///             "address1":"22",
    ///             "address2":"Bourkie Street",
    ///             "address3":"Melbourne",
    ///             "region":"Victoria",
    ///             "country":"Australia",
    ///             "postcode":"3000",
    ///             "freightCode":"01FRE",
    ///             "isPrimary":"Y",
    ///             "isDelivery":"N"
    ///         },
    ///         {
    ///             "keyAddressID":"ADD003",
    ///             "keySupplierAccountID":"10",
    ///             "description":"Delivery Address",
    ///             "orgName":"ESD Industries",
    ///             "contact":"John Doe",
    ///             "phone":"+61234567890",
    ///             "fax":"+612345678901",
    ///             "address1":"25",
    ///             "address2":"Bourkie Street",
    ///             "address3":"Melbourne",
    ///             "region":"Victoria",
    ///             "country":"Australia",
    ///             "postcode":"3000",
    ///             "freightCode":"02FRE",
    ///             "isPrimary":"N",
    ///             "isDelivery":"Y"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentSupplierAccountAddress : ESDocument
    {
        /// <summary>List of supplier account address records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordSupplierAccountAddress[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the supplier account address record data</param>
        /// <param name="message">message describing the status of obtaining the data for the document</param>
        /// <param name="supplierAccountAddresses">list of supplier account address records</param>
        /// <param name="configs">A list of key value pairs that contain additionally information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the supplier account address record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.</param>
        public ESDocumentSupplierAccountAddress(int resultStatus, string message, ESDRecordSupplierAccountAddress[] supplierAccountAddresses, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = supplierAccountAddresses;
            this.configs = configs;
        }
    }
}
