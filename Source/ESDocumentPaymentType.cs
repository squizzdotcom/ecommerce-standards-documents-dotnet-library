/// <remarks>
/// Copyright (C) 2018 Squizz PTY LTD
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
    /// <summary>Ecommerce standards document that contains a list of payment type records</summary>
    /// <example>
    /// An example of the payment type Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.2,
    ///     "resultStatus": 1,
    ///     "message":"The payment type data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 4,
    ///     "configs":{"dataFields":"keyPaymentTypeID,paymentTypeCode,paymentTypeLabel,description,paymentMethod"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyPaymentTypeID":"123"
    ///         },
    ///         {
    ///             "keyPaymentTypeID":"456",
    ///             "paymentTypeCode": "WEBCC",
    ///             "paymentTypeLabel":"Credit Card",
    ///             "description": "Credit Card payment made through a website",
    ///             "paymentMethod": "CREDITCARD"
    ///         },
    ///         {
    ///             "keyPaymentTypeID":"765",
    ///             "paymentTypeCode": "DD",
    ///             "paymentTypeLabel": "Direct Deposit",
    ///             "description": "Payment made using a direct deposit bank transfer",
    ///             "paymentMethod": "DIRECTDEPOSIT"
    ///         },
    ///         {
    ///             "keyPaymentTypeID":"6765",
    ///             "paymentTypeCode": "AC",
    ///             "paymentTypeLabel": "On Account",
    ///             "description": "Payment will be made at a time based on aggreed upon account terms",
    ///             "paymentMethod": "ACCOUNT"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentPaymentType : ESDocument
    {
        /// <summary>List of payment type records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordPaymentType[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the payment type data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="paymentTypeRecords">list of payment type records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the payment type record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentPaymentType(int resultStatus, string message, ESDRecordPaymentType[] paymentTypeRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = paymentTypeRecords;
            this.configs = configs;
            if (paymentTypeRecords != null)
            {
                this.totalDataRecords = paymentTypeRecords.Length;
            }
        }
    }
}