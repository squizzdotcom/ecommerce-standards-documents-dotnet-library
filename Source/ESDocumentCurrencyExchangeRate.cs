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
    /// Ecommerce standards document that holds a list of currency exchange rate records
    /// </summary>
    /// <example>
    /// An example of the currency exchange rate Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The currency exchange rate data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 5,
    ///     "configs":{"dataFields":"keyCurrencyExchangeRateID,sellCurrencyCode,sellCurrencyName,sellCurrencyType,buyCurrencyCode,buyCurrencyName,buyCurrencyType,exchangeRate"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyCurrencyExchangeRateID":"1"
    ///         },
    ///         //exchange rate from Australian Dollars to US dollars, $1 AUD sells for $0.70 USD
    ///         {
    ///             "keyCurrencyExchangeRateID":"2",
    ///             "sellCurrencyCode":"AUD",
    ///             "sellCurrencyName":"Australian Dollars",
    ///             "sellCurrencyType":"FIAT",
    ///             "buyCurrencyCode":"USD",
    ///             "buyCurrencyName":"United States Dollars",
    ///             "buyCurrencyType":"FIAT",
    ///             "exchangeRate": 0.7000
    ///         },
    ///         //exchange rate USD to AUD, $1 USD sells for $1.30 AUD
    ///         {
    ///             "keyCurrencyExchangeRateID":"3",
    ///             "sellCurrencyCode":"USD",
    ///             "sellCurrencyName":"United States Dollars",
    ///             "sellCurrencyType":"FIAT",
    ///             "buyCurrencyCode":"AUD",
    ///             "buyCurrencyName":"Australian Dollars",
    ///             "buyCurrencyType":"FIAT",
    ///             "exchangeRate": 1.3000
    ///         },
    ///         //exchange rate USD to EUR, $1 USD sells for €0.7727 EUR
    ///         {
    ///             "keyCurrencyExchangeRateID":"4AB",
    ///             "sellCurrencyCode":"USD",
    ///             "sellCurrencyName":"United States Dollars",
    ///             "sellCurrencyType":"FIAT",
    ///             "buyCurrencyCode":"EUR",
    ///             "buyCurrencyName":"Euros",
    ///             "buyCurrencyType":"FIAT",
    ///             "exchangeRate": 0.7727
    ///         },
    ///         //exchange rate Bitcoin to US Dollars, 1 Bitcoin sells for $8023.60 US Dollars
    ///         {
    ///             "keyCurrencyExchangeRateID":"5CC",
    ///             "sellCurrencyCode":"BTC",
    ///             "sellCurrencyName":"Bitcoins",
    ///             "sellCurrencyType":"CRYPTO",
    ///             "buyCurrencyCode":"USD",
    ///             "buyCurrencyName":"United States Dollars",
    ///             "buyCurrencyType":"FIAT",
    ///             "exchangeRate": 8023.6000
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentCurrencyExchangeRate : ESDocument
    {
        /// <summary>List of currency exchange rate records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordCurrencyExchangeRate[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the currency exchange rate record data</param>
        /// <param name="message">message describing the status of obtaining the data for the document</param>
        /// <param name="currencyExchangeRateRecords">list of currency exchange rate records</param>
        /// <param name="configs">A list of key value pairs that contain additionally information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the currency exchange rate record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentCurrencyExchangeRate(int resultStatus, string message, ESDRecordCurrencyExchangeRate[] currencyExchangeRateRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = currencyExchangeRateRecords;
            this.configs = configs;
            if (currencyExchangeRateRecords != null)
            {
                this.totalDataRecords = currencyExchangeRateRecords.Length;
            }
        }
    }
}
