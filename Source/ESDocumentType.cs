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
    /// <summary>Contains the types of Ecommerce Standards Documents (ESD) that the library contains</summary>
    public class ESDocumentType
    {
        public const int ALTERNATE_CODE = 9;
        public const int ATTACHMENT = 13;
        public const int ATTRIBUTE = 11;
        public const int CATEGORY = 8;
        public const int CURRENCY_EXCHANGE_RATE = 43;
        public const int CUSTOMER_ACCOUNT = 17;
        public const int CUSTOMER_ACCOUNT_ADDRESS = 20;
        public const int CUSTOMER_ACCOUNT_CONTRACT = 19;
        public const int CUSTOMER_ACCOUNT_ENQUIRY = 29;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_LINE = 30;
        public const int CUSTOMER_ACCOUNT_ENQUIRY_PRODUCT_PRICE = 31;
        public const int CUSTOMER_ACCOUNT_PAYMENT = 32;
        public const int CUSTOMER_INVOICE = 41;
        public const int DELIVERY_NOTICE = 42;
        public const int DOWNLOAD = 33;
        public const int FLAG = 21;
        public const int IMAGE = 12;
        public const int ITEM_GROUP = 34;
        public const int ITEM_RELATION = 14;
        public const int KIT = 22;
        public const int LABOUR = 35;
        public const int LOCATION = 23;
        public const int ORDER_PURCHASE = 24;
        public const int ORDER_SALE = 36;
        public const int PAYMENT_TYPE = 27;
        public const int PRICE = 37;
        public const int PRICE_LEVEL = 2;
        public const int PRODUCT = 3;
        public const int PRODUCT_COMBINATION = 15;
        public const int PURCHASER = 25;
        public const int SALES_REP = 16;
        public const int SELL_UNIT = 28;
        public const int STOCK_QUANTITY = 10;
        public const int SUPPLIER_ACCOUNT = 18;
        public const int SUPPLIER_ACCOUNT_ADDRESS = 38;
        public const int SUPPLIER_ACCOUNT_ENQUIRY = 39;
        public const int SUPPLIER_INVOICE = 40;
        public const int SURCHARGE = 26;
        public const int TAXCODE = 1;
    }
}