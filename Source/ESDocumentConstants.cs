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

namespace EcommerceStandardsDocuments
{
    /// <summary>
    /// Contains a list of variable constants that can be used in Ecommerce Standards Documents and records
    /// </summary>
    public class ESDocumentConstants
    {
        /// <summary>result status denoting that data was successfully obtained</summary>
        public static readonly int RESULT_SUCCESS = 1;
        /// <summary>result status denoting that an error occurred when trying to obtain/process data</summary>
        public static readonly int RESULT_ERROR = 2;
        /// <summary>result status denoting that an unknown error occurred when trying to obtain/process data</summary>
        public static readonly int RESULT_ERROR_UNKNOWN = 3;
        /// <summary>result status denoting that an error occurred when a connection could not be made to a data source to obtain/process data</summary>
        public static readonly int RESULT_ERROR_DATA_SOURCE_CONNECTION_MISSING = 4;
        /// <summary>result status denoting that an error occurred when a connection was unexpectedly lost from a data source when trying to obtain/process data</summary>
        public static readonly int RESULT_ERROR_DATA_SOURCE_CONNECTION_LOST = 5;
        /// <summary>result status denoting that an error occurred when trying to access a data source because of incorrect credentials given.</summary>
        public static readonly int RESULT_ERROR_DATA_SOURCE_INVALID_CREDENTIALS = 6;
        /// <summary>result status denoting that an error occurred when trying to process data from a data source to obtain/process data.</summary>
        public static readonly int RESULT_ERROR_DATA_SOURCE_PROCESSING = 7;
        /// <summary>result status denoting that an error occurred when a data source was given or sent invalid data.</summary>
        public static readonly int RESULT_ERROR_DATA_SOURCE_INVALID_DATA = 8;
        /// <summary>result status denoting that an error occurred when trying to access a data source because it denied access.</summary>
        public static readonly int RESULT_ERROR_DATA_SOURCE_PERMISSION_DENIED = 13;
        /// <summary>result status denoting that an error occurred when requesting access a data source too many times.</summary>
        public static readonly int RESULT_ERROR_DATA_SOURCE_MAXIMUM_REQUESTS_EXCEEDED = 14;
        /// <summary>result status denoting that an error occurred because incorrect credials were given to a connecting system to obtain/process data.</summary>
        public static readonly int RESULT_ERROR_CONNECTOR_INVALID_CREDENTIALS = 9;
        /// <summary>result status denoting that an error occurred because a connecting system could not process data.</summary>
        public static readonly int RESULT_ERROR_CONNECTOR_PROCESSING = 10;
        /// <summary>result status denoting that an error occurred because incorrect data was sent to or received from a connecting system.</summary>
        public static readonly int RESULT_ERROR_CONNECTOR_INVALID_DATA = 11;
        /// <summary>result status denoting that an error occurred because a connecting system was incorrectly configured to obtain/process data.</summary>
        public static readonly int RESULT_ERROR_CONNECTOR_INCORRECT_CONFIGURATION = 12;

        /// <summary>Result response status denoting the type of data returned is in the JSON format (JavaScript Object Notation)</summary>
        public static readonly string RESULT_RESPONSE_TYPE_JSON = "JSON";
        /// <summary>Result response status denoting the type of data returned is in a raw binary format.</summary>
        public static readonly string RESULT_RESPONSE_TYPE_RAW = "RAW";

        /// <summary>Data mode of the Ecommerce Standards Document is incremental, meaning only changes to data are contained within the document.</summary>
        public static readonly string ESD_DATA_MODE_INCREMENT = "INCREMENT";
        /// <summary>Data mode of the Ecommerce Standards Document is incremental if possible, meaning only changes to data need be contained within the document, but if it is not possible then all the data can be contained in the document.</summary>
        public static readonly string ESD_DATA_MODE_INCREMENT_IF_AVAILABLE = "INCREMENT_AVAILABLE";
        /// <summary>Data mode of the Ecommerce Standards Document is complete, and all the data available is contained within the document.</summary>
        public static readonly string ESD_DATA_MODE_COMPLETE = "COMPLETE";

        /// <summary>Denotes that the record in the Ecommerce Standard Document needs to be inserted into the requesting data source because it is a new record.</summary>
        public static readonly int ESD_RECORD_OPERATION_INSERT = 1;
        /// <summary>Denotes that the record in the Ecommerce Standard Document needs to be updated in the requesting data source because the record has changed.</summary>
        public static readonly int ESD_RECORD_OPERATION_UPDATE = 2;
        /// <summary>Denotes that the record in the Ecommerce Standard Document needs to be deleted from the requesting data source because the record no longer exists.</summary>
        public static readonly int ESD_RECORD_OPERATION_DELETE = 3;
        /// <summary>Denotes that the record in the Ecommerce Standard Document needs can be ignored in the requesting data source from being modified because the record's data has not changed.</summary>
        public static readonly int ESD_RECORD_OPERATION_IGNORE = 4;

        /// <summary>Contains the version that the Ecommerce Standards Documents library is currently at.</summary>
        public static readonly decimal ESD_DOCUMENT_VERSION = Convert.ToDecimal(1.1);

        /// <summary>Denotes that the location is a warehouse</summary>
        public static readonly string LOCATION_TYPE_WAREHOUSE = "WAREHOUSE";
        /// <summary>Denotes that the location is a store</summary>
        public static readonly string LOCATION_TYPE_STORE = "STORE";
        /// <summary>Denotes that the location is a site</summary>
        public static readonly string LOCATION_TYPE_SITE = "SITE";
        /// <summary>Denotes that the location is an office</summary>
        public static readonly string LOCATION_TYPE_OFFICE = "OFFICE";

        /// <summary>Language - English Australia</summary>
        public static readonly string LANG_EN_AU = "EN_AU";
        /// <summary>Language - English USA</summary>
        public static readonly string LANG_EN_US = "EN_US";

        /// <summary>Authority Number - Australian Business Number</summary>
        public static readonly int AUTHORITY_NUM_AUS_ABN = 1;
        /// <summary>Authority Number - Australian Company Number</summary>
        public static readonly int AUTHORITY_NUM_AUS_ACN = 2;
        /// <summary>Authority Number - Great Britain Company Registration Number</summary>
        public static readonly int AUTHORITY_NUM_GBR_CRN = 3;
        /// <summary>Authority Number - New Zealand Business Number</summary>
        public static readonly int AUTHORITY_NUM_NZL_NZBN = 4;
        /// <summary>Authority Number - United States Employer Identification Number</summary>
        public static readonly int AUTHORITY_NUM_USA_EIN = 5;

        /// <summary>Order Line Type - Text</summary>
        public static readonly string ORDER_LINE_TYPE_TEXT = "TEXT";
        /// <summary>Order Line Type - Product</summary>
        public static readonly string ORDER_LINE_TYPE_PRODUCT = "PRODUCT";
        /// <summary>Order Line Type - Download</summary>
        public static readonly string ORDER_LINE_TYPE_DOWNLOAD = "DOWNLOAD";
        /// <summary>Order Line Type - Labour</summary>
        public static readonly string ORDER_LINE_TYPE_LABOUR = "LABOUR";

        /// <summary>Entity Type - Org, denotes an organisation</summary>
        public static readonly string ENTITY_TYPE_ORG = "ORG";
        /// <summary>Entity Type - Personal, denotes a human individual</summary>
        public static readonly string ENTITY_TYPE_PERSON = "PERSON";

        /// <summary>Entity Set Price - system automatically calculated the price</summary>
        public static readonly string ENTITY_SET_PRICE_SYSTEM = "SYSTEM";
        /// <summary>Entity Set Price - price set by a sales representative</summary>
        public static readonly string ENTITY_SET_PRICE_SALESREP = "SALESREP";
        /// <summary>Entity Set Price - price set by an employee</summary>
        public static readonly string ENTITY_SET_PRICE_EMPLOYEE = "EMPLOYEE";

        /// <summary>Surcharge Type - Freight</summary>
        public static readonly string SURCHARGE_TYPE_FREIGHT = "FREIGHT";
        /// <summary>Surcharge Type - Credit Card</summary>
        public static readonly string SURCHARGE_TYPE_CREDIT_CARD = "CREDITCARD";
        /// <summary>Surcharge Type - Minimum Order Total</summary>
        public static readonly string SURCHARGE_TYPE_MIN_ORDER = "MINORDER";
        /// <summary>Surcharge Type - Other</summary>
        public static readonly string SURCHARGE_TYPE_OTHER = "OTHER";

        /// <summary>Payment method - UNPAID - No payment was received as yet</summary>
        public static readonly string PAYMENT_METHOD_UNPAID = "UNPAID";
        /// <summary>Payment method - CREDIT - A payment was made with a credit card</summary>
        public static readonly string PAYMENT_METHOD_CREDIT = "CREDITCARD";
        /// <summary>Payment method - COD - Payment will be made with cash when the goods are delivered to the delivery location</summary>
        public static readonly string PAYMENT_METHOD_CASHONDELIVERY = "COD";
        /// <summary>Payment method - DIRECTDEPOSIT - Payment has been made with a direct bank transfer</summary>
        public static readonly string PAYMENT_METHOD_DIRECTDEPOSIT = "DIRECTDEPOSIT";
        /// <summary>Payment method - QUOTE - No payment was made as a quote was only required</summary>
        public static readonly string PAYMENT_METHOD_QUOTE = "QUOTE";
        /// <summary>Payment method - NONE - No payment was made or needed</summary>
        public static readonly string PAYMENT_METHOD_NONE = "NONE";
        /// <summary>Payment method - PROPRIETARY - A payment was made using a proprietary payment system. PayPal could be one example of this.</summary>
        public static readonly string PAYMENT_METHOD_PROPRIETARY = "PROPRIETARY";
        /// <summary>Payment method - ACCOUNT - A payment will be assigned to a customer account and paid based on the agreed payment terms</summary>
        public static readonly string PAYMENT_METHOD_ACCOUNT = "ACCOUNT";
    }
}
