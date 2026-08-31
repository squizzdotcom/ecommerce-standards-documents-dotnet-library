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
    /// <summary>Ecommerce standards document that contains a list of surcharge records</summary>
    /// <example>
    /// An example of the Surcharge Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The surcharge data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 4,
    ///     "configs":{"dataFields":"keySurchargeID,surchargeCode,surchargeLabel,description,surchargeType"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keySurchargeID":"123"
    ///         },
    ///         {
    ///             "keySurchargeID":"456",
    ///             "surchargeCode": "WEB_FREIGHT",
    ///             "surchargeLabel":"Web Order Freight",
    ///             "description": "Costs to deliver orders created through the website.",
    ///             "surchargeType": "FREIGHT"
    ///         },
    ///         {
    ///             "keySurchargeID":"765",
    ///             "surchargeCode": "WEB_CC_SURCHARGE",
    ///             "surchargeLabel": "Web Credit Card Surcharge",
    ///             "description": "Transaction cost for payment made by credit card.",
    ///             "surchargeType": "CREDITCARD"
    ///         },
    ///         {
    ///             "keySurchargeID":"6765",
    ///             "surchargeCode": "WEB_MIN_ORDER",
    ///             "surchargeLabel": "Web Minimum Order Surcharge",
    ///             "description": "Cost to handle orders when an order's total price is under the allowed minimum.",
    ///             "surchargeType": "MINORDER"
    ///         },
    ///         {
    ///             "keySurchargeID":"a89b",
    ///             "surchargeCode": "IMP_TARIFF",
    ///             "surchargeLabel": "Import Tariff Surcharge",
    ///             "description": "Cost to import products into the country from international locations.",
    ///             "surchargeType": "TARIFF"
    ///         },
    ///         {
    ///             "keySurchargeID":"a893423121",
    ///             "surchargeCode": "FUEL_ENGERGY",
    ///             "surchargeLabel": "Fuel/Energy Surcharge",
    ///             "description": "Cost to pay for fuel/energy to move and deliver ordered goods.",
    ///             "surchargeType": "FUEL"
    ///         },
    ///         {
    ///             "keySurchargeID":"82352AB",
    ///             "surchargeCode": "SC_INSURANCE",
    ///             "surchargeLabel": "Insurance Surcharge",
    ///             "description": "Cost to insure ordered goods and services.",
    ///             "surchargeType": "INSURANCE"
    ///         },
    ///         {
    ///             "keySurchargeID":"1825222",
    ///             "surchargeCode": "BOOKING_FEE",
    ///             "surchargeLabel": "Booking Fee",
    ///             "description": "Cost make a reservation for goods and services.",
    ///             "surchargeType": "BOOKING"
    ///         },
    ///         {
    ///             "keySurchargeID":"37372325",
    ///             "surchargeCode": "SURGE_FEE",
    ///             "surchargeLabel": "Surcharge/Demand Fee",
    ///             "description": "Cost to order goods and services at peak time.",
    ///             "surchargeType": "SURGE"
    ///         },
    ///         {
    ///             "keySurchargeID":"a89b",
    ///             "surchargeCode": "IMP_TARIFF",
    ///             "surchargeLabel": "Holiday/Weekend Surcharge",
    ///             "description": "Cost to order goods and services outside normal business hours, such as weekends and holidays.",
    ///             "surchargeType": "HOLIDAY"
    ///         },
    ///         {
    ///             "keySurchargeID":"a89b",
    ///             "surchargeCode": "LATE_PAY_SUR",
    ///             "surchargeLabel": "Lay Payment Surcharge",
    ///             "description": "Cost to pay for ordered goods and services past the due payment date.",
    ///             "surchargeType": "LATE_PAYMENT"
    ///         },
    ///         {
    ///             "keySurchargeID":"a83423423423",
    ///             "surchargeCode": "PAYROLL_TAX",
    ///             "surchargeLabel": "Payroll Tax Surcharge",
    ///             "description": "Government surcharge that covers payroll tax when earning over 10,000,000 gross per year.",
    ///             "surchargeType": "OTHER"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentSurcharge : ESDocument
    {
        /// <summary>List of surcharge records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordSurcharge[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the surcharge data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="surchargeRecords">list of surcharge records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the surcharge record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentSurcharge(int resultStatus, string message, ESDRecordSurcharge[] surchargeRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = surchargeRecords;
            this.configs = configs;
            if (surchargeRecords != null)
            {
                this.totalDataRecords = surchargeRecords.Length;
            }
        }
    }
}