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
    /// Ecommerce standards document that holds a list of customer account records
    /// </summary>
    /// <example>
    /// An example of the Customer Account Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyCustomerAccountID,keyPriceLevelID,customerAccountCode,accountName,contactName,orgName,authorityNumbers,authorityNumberLabels,authorityNumberTypes,email,accountClass,paymentTypes,territory,discount,shippingMethod,isOnHold,isOutsideBalance,isOutsideTerms,onHoldAction,outTermsAction,outCreditAction,balance,limit,termsType,termsDescription,termsValue1,termsValue2"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyCustomerAccountID":"15C1",
    ///             "keyPriceLevelID":"PL001",
    ///             "customerAccountCode":"CUSTOMER001"
    ///         },
    ///         {
    ///             "keyCustomerAccountID":"222",
    ///             "keyPriceLevelID":"PL004",
    ///             "customerAccountCode":"CUST004",
    ///             "accountName":"John Smith",
    ///             "contactName":"John Smith",
    ///             "orgName":"",
    ///             "authorityNumbers":["2342342334","3432424424243"],
    ///             "authorityNumberLabels":["ABN", "ACN"],
    ///             "authorityNumberTypes":[1,2],
    ///             "phone":"+61123456789",
    ///             "email":"js@esdstandards.somewhere",
    ///             "accountClass":"primary",
    ///             "paymentTypes":"CC",
    ///             "territory":"Melb Rural",
    ///             "discount":10,
    ///             "shippingMethod":"Truck",
    ///             "isOnHold":"N",
    ///             "isOutsideBalance":"N",
    ///             "isOutsideTerms":"N",
    ///             "onHoldAction":"OFF",
    ///             "outTermsAction":"OFF",
    ///             "outCreditAction":"OFF",
    ///             "balance":1000.00,
    ///             "limit":0,
    ///             "termsType":"GND",
    ///             "termsDescription":"Pay before 14 days",
    ///             "termsValue1":"14",
    ///             "termsValue2":"",
    ///             "keyLocationIDs":[],
    ///             "keyGLAccountID","1240-SALES"
    ///         },
    ///         {
    ///             "keyCustomerAccountID":"10",
    ///             "keyPriceLevelID":"PL001",
    ///             "customerAccountCode":"CUSTOMER002",
    ///             "accountName":"ESD Industries",
    ///             "contactName":"Joey Joe Joe",
    ///             "orgName":"ESD Industries",
    ///             "authorityNumber":"1234567890",
    ///             "authorityNumberLabel":"ABN",
    ///             "phone":"+610987654321",
    ///             "email":"esd@esdstandards.somewhere",
    ///             "accountClass":"secondary",
    ///             "paymentTypes":"AC,CC,DD",
    ///             "territory":"Melb Metro",
    ///             "discount":0,
    ///             "shippingMethod":"",
    ///             "isOnHold":"N",
    ///             "isOutsideBalance":"Y",
    ///             "isOutsideTerms":"N",
    ///             "onHoldAction":"BLOCK",
    ///             "outTermsAction":"WARN",
    ///             "outCreditAction":"WARNCC",
    ///             "balance":-2000.00,
    ///             "limit":1000,
    ///             "termsType":"DOM",
    ///             "termsDescription":"Pay on the 15th day of the month",
    ///             "termsValue1":"15",
    ///             "termsValue2":"",
    ///             "keyLocationIDs":["LOC1","LOC3","RURA"],
    ///             "keyGLAccountID","1240-SALES"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentCustomerAccount : ESDocument
    {   
        /// <summary>List of customer account records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordCustomerAccount[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the customer account record data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="customerAccountRecords">list of customer account records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the customer account record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentCustomerAccount(int resultStatus, string message, ESDRecordCustomerAccount[] customerAccountRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = customerAccountRecords;
            this.configs = configs;
            if (customerAccountRecords != null)
            {
                this.totalDataRecords = customerAccountRecords.Length;
            }
        }
    }
}
