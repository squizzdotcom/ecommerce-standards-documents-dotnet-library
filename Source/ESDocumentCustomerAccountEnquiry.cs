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
    /// <summary>Ecommerce standards document that holds lists of invoices, transactions, sales orders, back orders, credits and payment records for customer accounts. This document can by used in many ways for enquiring about different data associated to a customer account's finances.</summary>
    /// <example>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, displaying a list of transactions for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry transaction data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 5,
    ///     "configs": {},
    ///     "transactionRecords":
    ///      [
    ///         {
    ///             "keyTransactionID":"",
    ///             "transactionID":"",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "currencyCode": "AUD",
    ///             "description": "Start Balance",
    ///             "balance": 100.00
    ///         },
    ///         {
    ///             "keyTransactionID":"112",
    ///             "transactionID":"T112",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "transactionNumber": "T1113",
    ///             "creationDate": 1449132083084,
    ///             "transactionDate": 1449932083084,
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "debitAmount": 110.00,
    ///             "creditAmount": 0,
    ///             "balance": -10.00,
    ///             "description": "Invoice",
    ///             "language": "EN_AU",
    ///             "currencyCode": "AUD"
    ///         },
    ///         {
    ///             "keyTransactionID":"113",
    ///             "transactionID":"T113",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "transactionNumber": "T1113",
    ///             "creationDate": 1449132083084,
    ///             "transactionDate": 1449932083084,
    ///             "referenceKeyID": "12",
    ///             "referenceType": "ORDER_SALE",
    ///             "referenceNumber": "4324234",
    ///             "debitAmount": 110.00,
    ///             "creditAmount": 0,
    ///             "balance": -220.00,
    ///             "description": "Sales Order",
    ///             "language": "EN_AU",
    ///             "currencyCode": "AUD"
    ///         },
    ///         {
    ///             "keyTransactionID":"114",
    ///             "transactionID":"T114",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "transactionNumber": "T1114",
    ///             "creationDate": 1449132083084,
    ///             "transactionDate": 1449932083084,
    ///             "referenceKeyID": "124",
    ///             "referenceType": "CREDIT",
    ///             "referenceNumber": "654654",
    ///             "debitAmount": 0,
    ///             "creditAmount": 330.00,
    ///             "balance": 110.00,
    ///             "description": "Credit applied against invoice #1234123",
    ///             "language": "EN_AU",
    ///             "currencyCode": "AUD"
    ///         },
    ///         {
    ///             "keyTransactionID":"115",
    ///             "transactionID":"T115",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "transactionNumber": "T1115",
    ///             "creationDate": 1449132083084,
    ///             "transactionDate": 1449932083084,
    ///             "referenceKeyID": "114",
    ///             "referenceType": "PAYMENT",
    ///             "referenceNumber": "654645445",
    ///             "debitAmount": 0,
    ///             "creditAmount": 100.00,
    ///             "balance": 210.00,
    ///             "description": "Payment applied to the customer account",
    ///             "language": "EN_AU",
    ///             "currencyCode": "AUD"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, displaying a list of invoices for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry invoice data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 2,
    ///     "configs":{},
    ///     "invoiceRecords":
    ///      [
    ///         {
    ///             "keyInvoiceID":"111",
    ///             "invoiceID":"INVOICE-111",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalPaid": 110.00,
    ///             "balance": 0
    ///         },
    ///         {
    ///             "keyInvoiceID":"112",
    ///             "invoiceID":"INVOICE-112",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "invoiceNumber": "1234123",
    ///             "creationDate": 1449132083084,
    ///             "invoiceDate": 1449932083084,
    ///             "dueDate": 1449932083084,
    ///             "expectedDeliveryDate": 1449982083084,
    ///             "deliveredDate": 1449982083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "ORDER-123",
    ///             "referenceType": "ORDER",
    ///             "referenceNumber": "123-1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPostcode": "3000",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "freightCarrierCode": "ACME-FREIGHT-001",
    ///             "freightCarrierName": "ACME Freight Shippers",
    ///             "freightSystemRefCode": "SHIP-SYS",
    ///             "freightCarrierConsignCode": "CON-23124123",
    ///             "freightCarrierTrackingCode": "34325-25243-24343",
    ///             "freightCarrierServiceCode": "EXPRESS-24",
    ///             "freightCarrierAccountCode": "ACME-001",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, containing the detail of a single invoice for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry invoice detail data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 1,
    ///     "configs":{},
    ///     "invoiceRecords":
    ///      [
    ///         {
    ///             "keyInvoiceID":"112",
    ///             "invoiceID":"INVOICE-112",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "invoiceNumber": "1234123",
    ///             "creationDate": 1449132083084,
    ///             "invoiceDate": 1449932083084,
    ///             "dueDate": 1449932083084,
    ///             "expectedDeliveryDate": 1449982083084,
    ///             "deliveredDate": 1449982083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "ORDER-123",
    ///             "referenceType": "ORDER",
    ///             "referenceNumber": "123-1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPostcode": "3000",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "freightCarrierCode": "ACME-FREIGHT-001",
    ///             "freightCarrierName": "ACME Freight Shippers",
    ///             "freightSystemRefCode": "SHIP-SYS",
    ///             "freightCarrierConsignCode": "CON-23124123",
    ///             "freightCarrierTrackingCode": "34325-25243-24343",
    ///             "freightCarrierServiceCode": "EXPRESS-24",
    ///             "freightCarrierAccountCode": "ACME-001",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance",
    ///             "lines":
    ///             [
    ///                 {
    ///                     "keyInvoiceLineID":"11234122"
    ///                 },
    ///                 {
    ///                     "keyInvoiceLineID":"11234123",
    ///                     "lineItemID":"PROD1234453",
    ///                     "lineItemCode":"PROD-123",
    ///                     "lineType":"ITEM",
    ///                     "description":"Tea Towels",
    ///                     "language":"EN_AU",
    ///                     "unit":"EACH",
    ///                     "quantityOrdered": 22,
    ///                     "quantityDelivered": 22,
    ///                     "quantityBackordered": 0,
    ///                     "priceExTax": 300.00,
    ///                     "priceIncTax": 330.00,
    ///                     "priceTax": 30.00,
    ///                     "totalPriceExTax":6600.00,
    ///                     "totalPriceIncTax": 7260.00,
    ///                     "totalPriceTax": 660,
    ///                     "taxCode":"GST",
    ///                     "keyLocationID":"456",
    ///                     "locationCode":"LCT-456",
    ///                     "currencyCode":"AUD",
    ///                     "referenceLineItemCode":"",
    ///                     "referenceLineCode":""
    ///                 },
    ///                 {
    ///                     "keyInvoiceLineID":"11234124",
    ///                     "lineType":"TEXT",
    ///                     "description":"Tea towels are packed into cardboard boxes"
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, displaying a list of sales orders for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry sales order data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 2,
    ///     "configs":{},
    ///     "orderSaleRecords":
    ///      [
    ///         {
    ///             "keyOrderSaleID":"11",
    ///             "orderID":"SALESORDER-11",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "totalExTax": 400.00,
    ///             "totalIncTax": 440.00,
    ///             "totalTax": 40.00,
    ///             "totalPaid": 0,
    ///             "balance": 440.00
    ///         },
    ///         {
    ///             "keyOrderSaleID":"12",
    ///             "orderID":"SALESORDER-12",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "orderNumber": "4324234",
    ///             "creationDate": 1449132083084,
    ///             "orderDate": 1449932083084,
    ///             "dueDate": 1449932083084,
    ///             "expectedDeliveryDate": 1449982083084,
    ///             "deliveredDate": 1449982083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPostcode": "3000",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "freightCarrierCode": "ACME-FREIGHT-001",
    ///             "freightCarrierName": "ACME Freight Shippers",
    ///             "freightSystemRefCode": "SHIP-SYS",
    ///             "freightCarrierConsignCode": "CON-23124123",
    ///             "freightCarrierTrackingCode": "34325-25243-24343",
    ///             "freightCarrierServiceCode": "EXPRESS-24",
    ///             "freightCarrierAccountCode": "ACME-001",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, containing the detail of a single sales order for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry sales order detail data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 1,
    ///     "configs":{},
    ///     "orderSaleRecords":
    ///      [
    ///         {
    ///             "keyOrderSaleID":"112",
    ///             "orderID":"SALESORDER-112",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "orderNumber": "4324234",
    ///             "creationDate": 1449132083084,
    ///             "orderDate": 1449932083084,
    ///             "dueDate": 1449932083084,
    ///             "expectedDeliveryDate": 1449982083084,
    ///             "deliveredDate": 1449982083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPostcode": "3000",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "freightCarrierCode": "ACME-FREIGHT-001",
    ///             "freightCarrierName": "ACME Freight Shippers",
    ///             "freightSystemRefCode": "SHIP-SYS",
    ///             "freightCarrierConsignCode": "CON-23124123",
    ///             "freightCarrierTrackingCode": "34325-25243-24343",
    ///             "freightCarrierServiceCode": "EXPRESS-24",
    ///             "freightCarrierAccountCode": "ACME-001",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance",
    ///             "lines":
    ///             [
    ///                 {
    ///                     "keyOrderSaleLineID":"4122"
    ///                 },
    ///                 {
    ///                     "keyOrderSaleLineID":"4123",
    ///                     "lineItemID":"PROD1234453",
    ///                     "lineItemCode":"PROD-123",
    ///                     "lineType":"ITEM",
    ///                     "description":"Tea Towels",
    ///                     "language":"EN_AU",
    ///                     "unit":"EACH",
    ///                     "quantityOrdered": 22,
    ///                     "quantityDelivered": 22,
    ///                     "quantityBackordered": 0,
    ///                     "priceExTax": 300.00,
    ///                     "priceIncTax": 330.00,
    ///                     "priceTax": 30.00,
    ///                     "totalPriceExTax":6600.00,
    ///                     "totalPriceIncTax": 7260.00,
    ///                     "totalPriceTax": 660,
    ///                     "taxCode":"GST",
    ///                     "keyLocationID":"456",
    ///                     "locationCode":"LCT-456",
    ///                     "currencyCode":"AUD",
    ///                     "referenceLineItemCode":"",
    ///                     "referenceLineCode":""
    ///                 },
    ///                 {
    ///                     "keyInvoiceLineID":"11234124",
    ///                     "lineType":"TEXT",
    ///                     "description":"Tea towels are packed into cardboard boxes"
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, displaying a list of credits for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry credit data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 2,
    ///     "configs":{},
    ///     "creditRecords":
    ///      [
    ///         {
    ///             "keyCreditID":"123",
    ///             "creditID":"CREDIT-123",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "totalExTax": 400.00,
    ///             "totalIncTax": 440.00,
    ///             "totalTax": 40.00,
    ///             "totalPaid": 0
    ///         },
    ///         {
    ///             "keyCreditID":"124",
    ///             "creditID":"CREDIT-124",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "creditNumber": "654654",
    ///             "creationDate": 1449132083084,
    ///             "creditDate": 1449932083084,
    ///             "appliedAmount": 330.00,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 330.00,
    ///             "totalIncTax": 300.00,
    ///             "totalTax": 30.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "language": "EN_AU",
    ///             "comment": "Credit applied against invoice #1234123"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, containing the detail of a single credit for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry credit detail data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 1,
    ///     "configs":{},
    ///     "creditRecords":
    ///      [
    ///         {
    ///             "keyCreditID":"124",
    ///             "creditID":"CREDIT-124",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "creditNumber": "654654",
    ///             "creationDate": 1449132083084,
    ///             "creditDate": 1449932083084,
    ///             "appliedAmount": 330.00,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 330.00,
    ///             "totalIncTax": 300.00,
    ///             "totalTax": 30.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "language": "EN_AU",
    ///             "comment": "Credit applied against invoice #1234123",
    ///             "lines":
    ///             [
    ///                 {
    ///                     "keyCreditLineID":"4122"
    ///                 },
    ///                 {
    ///                     "keyCreditLineID":"4123",
    ///                     "lineItemID":"123123",
    ///                     "lineItemCode":"CREDIT-123123",
    ///                     "lineType":"ITEM",
    ///                     "description":"Tea Towels",
    ///                     "language":"EN_AU",
    ///                     "referenceKeyID": "112",
    ///                     "referenceType": "INVOICE",
    ///                     "referenceNumber": "1234123",
    ///                     "unit":"EACH",
    ///                     "quantity": 1,
    ///                     "priceExTax": 300.00,
    ///                     "priceIncTax": 330.00,
    ///                     "priceTax": 30.00,
    ///                     "totalPriceExTax": 300.00,
    ///                     "totalPriceIncTax": 330.00,
    ///                     "totalPriceTax": 30.00,
    ///                     "taxCode":"GST",
    ///                     "currencyCode":"AUD"
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, displaying a list of payments for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry payment data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 2,
    ///     "configs":{},
    ///     "paymentRecords":
    ///      [
    ///         {
    ///             "keyPaymentID":"113",
    ///             "paymentID":"PAYMENT-123",
    ///             "paymentNumber": "654645434",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004"
    ///         },
    ///         {
    ///             "keyPaymentID":"114",
    ///             "paymentID":"PAYMENT-124",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "paymentNumber": "654645445",
    ///             "creationDate": 1449132083084,
    ///             "paymentDate": 1449932083084,
    ///             "appliedAmount": 330.00,
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "totalAmount": 100.00,
    ///             "currencyCode": "AUD",
    ///             "description": "",
    ///             "language": "EN_AU",
    ///             "comment": "Payment applied against invoice #1234123"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, containing the detail of a single payment for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry payment detail data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 1,
    ///     "configs":{},
    ///     "paymentRecords":
    ///      [
    ///         {
    ///             "keyPaymentID":"114",
    ///             "paymentID":"PAYMENT-124",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "paymentNumber": "654645445",
    ///             "creationDate": 1449132083084,
    ///             "paymentDate": 1449932083084,
    ///             "appliedAmount": 330.00,
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "totalAmount": 100.00,
    ///             "currencyCode": "AUD",
    ///             "description": "",
    ///             "language": "EN_AU",
    ///             "comment": "Payment applied against invoice #1234123",
    ///             "lines":
    ///             [
    ///                 {
    ///                     "keyPaymentLineID":"4122"
    ///                 },
    ///                 {
    ///                     "keyPaymentLineID":"4123",
    ///                     "lineItemID":"5435",
    ///                     "lineItemCode":"PAYMENT-5435",
    ///                     "lineType":"ITEM",
    ///                     "referenceKeyID": "112",
    ///                     "referenceType": "INVOICE",
    ///                     "referenceNumber": "1234123",
    ///                     "description":"Payment for invoice #1234123",
    ///                     "language":"EN_AU",
    ///                     "currencyCode":"AUD",
    ///                     "amount": 100.00
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, displaying a list of back orders for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry back order data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 2,
    ///     "configs":{},
    ///     "backOrderRecords":
    ///      [
    ///         {
    ///             "keyBackOrderID":"11",
    ///             "backOrderID":"SALESORDER-11",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "totalExTax": 400.00,
    ///             "totalIncTax": 440.00,
    ///             "totalTax": 40.00,
    ///             "totalPaid": 0,
    ///             "balance": 440.00
    ///         },
    ///         {
    ///             "keyBackOrderID":"12",
    ///             "backOrderID":"SALESORDER-12",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "backOrderNumber": "4324234",
    ///             "creationDate": 1449132083084,
    ///             "backOrderDate": 1449932083084,
    ///             "dueDate": 1449932083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "12",
    ///             "referenceType": "ORDER_SALE",
    ///             "referenceNumber": "4324234",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, containing the detail of a single back order for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry back order detail data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 1,
    ///     "configs":{},
    ///     "backOrderRecords":
    ///      [
    ///         {
    ///             "keyBackOrderID":"112",
    ///             "backOrderID":"BACKORDER-112",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "backOrderNumber": "4324234",
    ///             "creationDate": 1449132083084,
    ///             "backOrderDate": 1449932083084,
    ///             "dueDate": 1449932083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "12",
    ///             "referenceType": "ORDER_SALE",
    ///             "referenceNumber": "4324234",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPostcode": "3000",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance",
    ///             "lines":
    ///             [
    ///                 {
    ///                     "keyBackOrderLineID":"4122"
    ///                 },
    ///                 {
    ///                     "keyBackOrderLineID":"4123",
    ///                     "lineItemID":"PROD1234453",
    ///                     "lineItemCode":"PROD-123",
    ///                     "lineType":"ITEM",
    ///                     "description":"Tea Towels",
    ///                     "language":"EN_AU",
    ///                     "unit":"EACH",
    ///                     "quantityOrdered": 22,
    ///                     "quantityDelivered": 22,
    ///                     "quantityBackordered": 0,
    ///                     "priceExTax": 300.00,
    ///                     "priceIncTax": 330.00,
    ///                     "priceTax": 30.00,
    ///                     "totalPriceExTax":6600.00,
    ///                     "totalPriceIncTax": 7260.00,
    ///                     "totalPriceTax": 660,
    ///                     "taxCode":"GST",
    ///                     "keyLocationID":"456",
    ///                     "locationCode":"LCT-456",
    ///                     "currencyCode":"AUD",
    ///                     "referenceLineItemCode":"",
    ///                     "referenceLineCode":""
    ///                 },
    ///                 {
    ///                     "keyBackOrderLineID":"11234124",
    ///                     "lineType":"TEXT",
    ///                     "description":"Tea towels are packed into cardboard boxes"
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, displaying a list of quotes for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry quote data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 2,
    ///     "configs":{},
    ///     "quoteRecords":
    ///      [
    ///         {
    ///             "keyQuoteID":"11",
    ///             "quoteID":"QUOTE-11",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "totalExTax": 400.00,
    ///             "totalIncTax": 440.00,
    ///             "totalTax": 40.00,
    ///             "totalPaid": 0,
    ///             "balance": 440.00
    ///         },
    ///         {
    ///             "keyQuoteID":"12",
    ///             "quoteID":"QUOTE-12",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "quoteNumber": "4324234",
    ///             "creationDate": 1449132083084,
    ///             "quoteDate": 1449932083084,
    ///             "expiryDate": 1449932083084,
    ///             "expectedDeliveryDate": 1449982083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPostcode": "3000",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "freightCarrierCode": "ACME-FREIGHT-001",
    ///             "freightCarrierName": "ACME Freight Shippers",
    ///             "freightSystemRefCode": "SHIP-SYS",
    ///             "freightCarrierConsignCode": "CON-23124123",
    ///             "freightCarrierTrackingCode": "34325-25243-24343",
    ///             "freightCarrierServiceCode": "EXPRESS-24",
    ///             "freightCarrierAccountCode": "ACME-001",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// An example of the Customer Account Enqury Standards document in its JSON serialised form, containing the detail of a single quote for a customer account
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The customer account enquiry sales order detail data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 1,
    ///     "configs":{},
    ///     "quoteRecords":
    ///      [
    ///         {
    ///             "keyQuoteID":"112",
    ///             "quoteID":"QUOTE-112",
    ///             "keyCustomerAccountID":"222",
    ///             "customerAccountCode":"CUST004",
    ///             "quoteNumber": "4324234",
    ///             "creationDate": 1449132083084,
    ///             "quoteDate": 1449932083084,
    ///             "dueDate": 1449932083084,
    ///             "expiryDate": 1449982083084,
    ///             "keyLocationID": "456",
    ///             "locationCode": "LCT-456",
    ///             "locationLabel": "Warehouse",
    ///             "locationType": "WAREHOUSE",
    ///             "referenceKeyID": "112",
    ///             "referenceType": "INVOICE",
    ///             "referenceNumber": "1234123",
    ///             "customerReference": "PO-12345",
    ///             "salesRepCode": "JD",
    ///             "salesRepName": "John Doe",
    ///             "deliveryContact": "Lee",
    ///             "deliveryOrgName": "Lee's Business Pty Ltd",
    ///             "deliveryAddress1": "22",
    ///             "deliveryAddress2": "Bourkie Street",
    ///             "deliveryAddress3": "Melbourne",
    ///             "deliveryStateProvince": "Victoria",
    ///             "deliveryCountry": "Australia",
    ///             "deliveryCountryCodeISO2": "AU",
    ///             "deliveryCountryCodeISO3": "AUS",
    ///             "deliveryPostcode": "3000",
    ///             "deliveryPurchaseOrderCode": "PO-34342-1",
    ///             "billingContact": "Tom",
    ///             "billingOrgName": "Lee's Business Pty Ltd",
    ///             "billingAddress1": "15",
    ///             "billingAddress2": "Bourkie Street",
    ///             "billingAddress3": "Melbourne",
    ///             "billingStateProvince": "Victoria",
    ///             "billingCountry": "Australia",
    ///             "billingCountryCodeISO2": "AU",
    ///             "billingCountryCodeISO3": "AUS",
    ///             "billingPostcode": "3000",
    ///             "taxNumber": "123 12332 123",
    ///             "taxLabel": "GST",
    ///             "taxRate": 10,
    ///             "totalExTax": 100.00,
    ///             "totalIncTax": 110.00,
    ///             "totalTax": 10.00,
    ///             "totalFreightIncTax": 11.00,
    ///             "totalFreightExTax": 10.00,
    ///             "totalExtraChargesIncTax": 1.10,
    ///             "totalExtraChargesExTax": 1.00,
    ///             "totalDiscountsIncTax": 220.00,
    ///             "totalDiscountsExTax": 22.00,
    ///             "totalLeviesIncTax": 22.00,
    ///             "totalLeviesExTax": 20.00,
    ///             "totalPaid": 50.00,
    ///             "balance": 60.00,
    ///             "currencyCode": "AUD",
    ///             "totalQuantity": 3,
    ///             "description": "",
    ///             "freightCarrierCode": "ACME-FREIGHT-001",
    ///             "freightCarrierName": "ACME Freight Shippers",
    ///             "freightSystemRefCode": "SHIP-SYS",
    ///             "freightCarrierConsignCode": "CON-23124123",
    ///             "freightCarrierTrackingCode": "34325-25243-24343",
    ///             "freightCarrierServiceCode": "EXPRESS-24",
    ///             "freightCarrierAccountCode": "ACME-001",
    ///             "language": "EN_AU",
    ///             "comment": "Please leave goods by the back entrance",
    ///             "lines":
    ///             [
    ///                 {
    ///                     "keyOrderSaleLineID":"4122"
    ///                 },
    ///                 {
    ///                     "keyQuoteLineID":"4123",
    ///                     "lineItemID":"PROD1234453",
    ///                     "lineItemCode":"PROD-123",
    ///                     "lineType":"ITEM",
    ///                     "description":"Tea Towels",
    ///                     "language":"EN_AU",
    ///                     "unit":"EACH",
    ///                     "quantityQuoted": 22,
    ///                     "priceExTax": 300.00,
    ///                     "priceIncTax": 330.00,
    ///                     "priceTax": 30.00,
    ///                     "totalPriceExTax":6600.00,
    ///                     "totalPriceIncTax": 7260.00,
    ///                     "totalPriceTax": 660,
    ///                     "taxCode":"GST",
    ///                     "keyLocationID":"456",
    ///                     "locationCode":"LCT-456",
    ///                     "currencyCode":"AUD",
    ///                     "referenceLineItemCode":"",
    ///                     "referenceLineCode":""
    ///                 },
    ///                 {
    ///                     "keyQuoteLineID":"11234124",
    ///                     "lineType":"TEXT",
    ///                     "description":"Tea towels are packed into cardboard boxes"
    ///                 }
    ///             ]
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentCustomerAccountEnquiry : ESDocument
    {
        /// <summary>list of Customer Account Enquiry Invoice records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryInvoice[] invoiceRecords { get; set; }
        /// <summary>list of Customer Account Enquiry Order Sale records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryOrderSale[] orderSaleRecords { get; set; }
        /// <summary>list of Customer Account Enquiry Back Order records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryBackOrder[] backOrderRecords { get; set; }
        /// <summary>list of Customer Account Enquiry Transaction records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryTransaction[] transactionRecords { get; set; }
        /// <summary>list of Customer Account Enquiry Payment records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryPayment[] paymentRecords { get; set; }
        /// <summary>list of Customer Account Enquiry Credit records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryCredit[] creditRecords { get; set; }
        /// <summary>list of Customer Account Enquiry quote records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryQuote[] quoteRecords { get; set; }

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the customer account record data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.</param>
        public ESDocumentCustomerAccountEnquiry(int resultStatus, string message, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.configs = configs;
        }
        /// <summary>Record Type - Invoice</summary>
        public static readonly string RECORD_TYPE_INVOICE = "INVOICE";
        /// <summary>Record Type - Transaction</summary>
        public static readonly string RECORD_TYPE_TRANSACTION = "TRANSACTION";
        /// <summary>Record Type - Sales Order</summary>
        public static readonly string RECORD_TYPE_ORDER_SALE = "ORDER_SALE";
        /// <summary>Record Type - Purchase Order</summary>
        public static readonly string RECORD_TYPE_ORDER_PURCHASE = "ORDER_PURCHASE";
        /// <summary>Record Type - Back Order</summary>
        public static readonly string RECORD_TYPE_BACKORDER = "BACKORDER";
        /// <summary>Record Type - Credit</summary>
        public static readonly string RECORD_TYPE_CREDIT = "CREDIT";
        /// <summary>Record Type - Payment</summary>
        public static readonly string RECORD_TYPE_PAYMENT = "PAYMENT";
        /// <summary>Record Type - Payment</summary>
        public static readonly string RECORD_TYPE_QUOTE = "QUOTE";

        /// <summary>Record Line Type - Item</summary>
        public static readonly string RECORD_LINE_TYPE_ITEM = "ITEM";
        /// <summary>Record Line Type - Text</summary>
        public static readonly string RECORD_LINE_TYPE_TEXT = "TEXT";
        /// <summary>Record Line Type - Invoice</summary>
        public static readonly string RECORD_LINE_TYPE_INVOICE = "INVOICE";
        /// <summary>Record Line Type - Sales Order</summary>
        public static readonly string RECORD_LINE_TYPE_ORDER_SALE = "ORDER_SALE";
    }
}
