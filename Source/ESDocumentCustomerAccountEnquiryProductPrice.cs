﻿/// <remarks>
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
    /// <summary>Ecommerce standards document that contains a list of pricing records applicable to a customer account for a number of products</summary>
    [DataContract]
    public class ESDocumentCustomerAccountEnquiryProductPrice : ESDocument
    {
        /// <summary>List of account enquiry pricing records.</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordCustomerAccountEnquiryProductPrice[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">result of the import</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="accountProductPrices">array of product kit components</param>
        /// <param name="configs">dictionary containing any configurable information for the import</param>
        public ESDocumentCustomerAccountEnquiryProductPrice(int resultStatus, string message, ESDRecordCustomerAccountEnquiryProductPrice[] accountProductPrices, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = accountProductPrices;
            this.configs = configs;
        }
    }
}
