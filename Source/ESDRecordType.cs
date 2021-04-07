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

namespace EcommerceStandardsDocuments
{
    /// <summary>Contains the types of Ecommerce Standards Document (ESD) records that the library contains</summary>
    public class ESDRecordType
    {
        public const int ALTERNATE_CODE = 1;
        public const int ATTACHMENT = 2;
        public const int ATTRIBUTE = 3;
        public const int ATTRIBUTE_PROFILE = 4;
        public const int ATTRIBUTE_VALUE = 5;
        public const int CATEGORY = 6;
        public const int COMBINATION_PROFILE = 7;
        public const int COMBINATION_PROFILE_FIELD = 8;
        public const int CONTACT = 9;
        public const int CURRENCY_EXCHANGE_RATE = 78;
        public const int CUSTOMER_ACCOUNT = 10;
        public const int CUSTOMER_ACCOUNT_ADDRESS = 11;
        public const int CUSTOMER_ACCOUNT_CONTRACT = 12;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_BACKORDER = 13;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_BACKORDER_LINE = 14;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_CREDIT = 15;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_CREDIT_LINE = 16;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_INVOICE = 17;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_INVOICE_LINE = 18;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_ORDER_SALE = 19;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_ORDER_SALE_LINE = 20;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_PAYMENT = 21;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_PAYMENT_LINE = 22;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_PRODUCT_PRICE = 23;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_TRANSACTION = 24;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_QUOTE = 62;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_QUOTE_LINE = 63;
        public const int CUSTOMER_ACCOUNT_PAYMENT = 25;
        public const int CUSTOMER_ACCOUNT_PAYMENT_RECORD = 26;
        public const int CUSTOMER_INVOICE = 67;
        public const int CUSTOMER_INVOICE_LINE = 68;
        public const int DELIVERY_NOTICE = 76;
        public const int DELIVERY_NOTICE_LINE = 77;
        public const int DOWNLOAD = 27;
        public const int FLAG = 28;
        public const int FLAG_MAPPING = 29;
        public const int IMAGE = 30;
        public const int INVOICE_LINE_ATTRIBUTE = 71;
        public const int INVOICE_LINE_ATTRIBUTE_PROFILE = 72;
        public const int INVOICE_LINE_TAX = 73;
        public const int INVOICE_PAYMENT = 74;
        public const int INVOICE_SURCHARGE = 75;
        public const int ITEM_GROUP = 31;
        public const int ITEM_RELATION = 32;
        public const int KIT_COMPONENT = 33;
        public const int LABOUR = 34;
        public const int LOCATION = 35;
        public const int MAKER = 64;
        public const int MAKER_MODEL = 65;
        public const int MAKER_MODEL_MAPPING = 66;
        public const int ORDER_LINE_ATTRIBUTE = 36;
        public const int ORDER_LINE_ATTRIBUTE_PROFILE = 37;
        public const int ORDER_LINE_TAX = 38;
        public const int ORDER_PAYMENT = 39;
        public const int ORDER_PRODUCT_DELIVERY = 40;
        public const int ORDER_PURCHASE = 41;
        public const int ORDER_PURCHASE_LINE = 42;
        public const int ORDER_SALE = 43;
        public const int ORDER_SALE_LINE = 44;
        public const int ORDER_SURCHARGE = 45;
        public const int PAYMENT_TYPE = 46;
        public const int PRICE = 47;
        public const int PRICE_LEVEL = 48;
        public const int PRODUCT = 49;
        public const int PRODUCT_COMBINATION = 50;
        public const int PRODUCT_COMBINATION_PARENT = 51;
        public const int PURCHASER = 52;
        public const int SALES_REP = 53;
        public const int SELL_UNIT = 54;
        public const int STOCK_QUANTITY = 55;
        public const int SUPPLIER_ACCOUNT = 56;
        public const int SUPPLIER_ACCOUNT_ADDRESS = 57;
        public const int SUPPLIER_ACCOUNT_ENQUIRY_ORDER_PURCHASE = 58;
        public const int SUPPLIER_ACCOUNT_ENQUIRY_ORDER_PURCHASE_LINE = 59;
        public const int SUPPLIER_INVOICE = 69;
        public const int SUPPLIER_INVOICE_LINE = 70;
        public const int SURCHARGE = 60;
        public const int TAXCODE = 61;
    }
}