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
    /// <summary>Ecommerce Standards record that contains the data of a single Purchase Order that can be queried for a supplier account. A purchase order record contains information about items ordered by a supplier account. The account enquiry aspect denotes that the record may be queried in real time and contain additional information associated with the record.</summary>
    [DataContract]
    public class ESDRecordSupplierAccountEnquiryOrderPurchase
    {
        /// <summary>Key that allows the supplier account purchase order record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyOrderPurchaseID { get; set; }
        /// <summary>ID that allows the purchase order to be identified with. May or may not be unique.</summary>
        [DataMember]
        public string orderID { get; set; }
        /// <summary>Number that is associated to the purchase order. This number can be used for referencing purposes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string orderNumber { get; set; }
        /// <summary>Key of the supplier account record assigned to the purchase order.</summary>
        [DataMember]
        public string keySupplierAccountID { get; set; }
        /// <summary>Code of the suppier account assigned to the purchase order.</summary>
        [DataMember]
        public string supplierAccountCode { get; set; }
        /// <summary>Date that the purchase order record was created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long creationDate { get; set; }
        /// <summary>Date set to the purchase order. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long orderDate { get; set; }
        /// <summary>Date that the purchase order is due. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long dueDate { get; set; }
        /// <summary>Date that the ordered goods/services are expected to be delivered. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long expectedDeliveryDate { get; set; }
        /// <summary>Date that the ordered goods/services were delivered. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long deliveredDate { get; set; }
        /// <summary>Key of the location record associated to the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }
        /// <summary>Code of the location associated to the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationCode { get; set; }
        /// <summary>Label of the location associated to the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationLabel { get; set; }
        /// <summary>The type of location associated to the purchase order. Set it to one of the LOCATION_TYPE constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationType { get; set; }
        /// <summary>Key of an entity that is linked to the purchase order as a reference. A Reference could be an ID of a record such as a purchase order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceKeyID { get; set; }
        /// <summary>Type of entity that is linked to the purchase order as a reference.  A Reference could be a record such as a purchase order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceType { get; set; }
        /// <summary>Number that provides a reference to the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceNumber { get; set; }
        /// <summary>Code of the purchase representative associated to the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaserCode { get; set; }
        /// <summary>Name of the purchase representative associated to the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaserName { get; set; }
        /// <summary>Name of the contact person at the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryContact { get; set; }
        /// <summary>Name of the organisation that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryOrgName { get; set; }
        /// <summary>First address field that the purchase order is being delivered to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress1 { get; set; }
        /// <summary>Second address field that the purchase order is being delivered to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress2 { get; set; }
        /// <summary>Third address field that the purchase order is being delivered to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress3 { get; set; }
        /// <summary>Name of the state/province/region that the purchase order is being delivered to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryStateProvince { get; set; }
        /// <summary>Name of the country that the purchase order is being delivered to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountry { get; set; }
        /// <summary>Code of the country at the address that the ordered goods are being delivered to as a 2 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO2 { get; set; }
        /// <summary>Code of the country at the address that the ordered goods are being delivered to as a 3 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO3 { get; set; }
        /// <summary>Post code of the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryPostcode { get; set; }
        /// <summary>Code of the purchase order to include in the delivery information, that is contains the code of the purchase order relevant to the delivery receiver</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryPurchaseOrderCode { get; set; }
        /// <summary>Name of the contact person at the address associated with the billing of the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingContact { get; set; }
        /// <summary>Name of the organisation that the orders goods are being billed to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingOrgName { get; set; }
        /// <summary>First address field of the billing address set for the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress1 { get; set; }
        /// <summary>Second address field of the billing address set for the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress2 { get; set; }
        /// <summary>Third address field of the billing address set for the purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress3 { get; set; }
        /// <summary>Name of the region/state/province that the purchase order is being billed to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingStateProvince { get; set; }
        /// <summary>Name of the country that the purchase order is being billed to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingCountry { get; set; }
        /// <summary>Code of the country at the billing address as a 2 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingCountryCodeISO2 { get; set; }
        /// <summary>Code of the country at the billing address as a 3 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingCountryCodeISO3 { get; set; }
        /// <summary>Post code at the billing address</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingPostcode { get; set; }
        /// <summary>Tax number displayed on the purchase order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxNumber { get; set; }
        /// <summary>Label of the taxes assigned to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxLabel { get; set; }
        /// <summary>Percentage amount of tax that the applied to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal taxRate { get; set; }
        /// <summary>Total monetary amount of the purchase order excluding taxes</summary>
        [DataMember]
        public decimal totalExTax { get; set; }
        /// <summary>Total monetary amount of the purchase order including taxes</summary>
        [DataMember]
        public decimal totalIncTax { get; set; }
        /// <summary>Total monetary amount of tax applied to the purchase order's total</summary>
        [DataMember]
        public decimal totalTax { get; set; }
        /// <summary>Total monetary amount of freight inclusive of tax applied to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalFreightIncTax { get; set; }
        /// <summary>Total monetary amount of freight excluding tax applied to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalFreightExTax { get; set; }
        /// <summary>Total monetary amount of extra charges inclusive of tax applied to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalExtraChargesIncTax { get; set; }
        /// <summary>Total monetary amount of extra charges exclusive of tax applied to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalExtraChargesExTax { get; set; }
        /// <summary>Total monetary amount of discounts inclusive of tax discounted off the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalDiscountsIncTax { get; set; }
        /// <summary>Total monetary amount of discounts exclusive of tax discounted off the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalDiscountsExTax { get; set; }
        /// <summary>Total monetary amount of levies inclusive of tax applied to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalLeviesIncTax { get; set; }
        /// <summary>Total monetary amount of levies exclusive of tax applied to the purchase order's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalLeviesExTax { get; set; }
        /// <summary>Total monetary amount paid for the purchase order</summary>
        [DataMember]
        public decimal totalPaid { get; set; }
        /// <summary>Total monetary amount still to be paid for the purchase order</summary>
        [DataMember]
        public decimal balance { get; set; }
        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored in the purchase order with</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyCode { get; set; }
        /// <summary>Total quantity across all the purchase order lines</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalQuantity { get; set; }
        /// <summary>Text that describes any information associated with the purchase order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Language that all text is described in. Set it to one of the LANG constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }
        /// <summary>Text that contains additional comments that have been made for the purchase order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string comment { get; set; }
        /// <summary>Code of the freight carrier who delivered the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierCode { get; set; }
        /// <summary>Name of the freight carrier who delivered the orders goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierName { get; set; }
        /// <summary>Reference code to the system used to process the freight</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightSystemRefCode { get; set; }
        /// <summary>Consignment code issued by the freight carrier to delivery the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierConsignCode { get; set; }
        /// <summary>Code to track the freight carrier who delivered the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierTrackingCode { get; set; }
        /// <summary>Code of the service provided by the freight carrier to deliver the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierServiceCode { get; set; }
        /// <summary>Code of the account in the freight carrier's system</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierAccountCode { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
        /// <summary>List of lines in the purchase order</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordSupplierAccountEnquiryOrderPurchaseLine[] lines { get; set; }

        /// <summary>Converts the supplier account enquiry order purchase record into a purchase order record</summary>
        /// <returns>purchase order record and its lines</returns>
        public ESDRecordOrderPurchase convertToOrderPurchaseRecord()
        {
            ESDRecordOrderPurchase orderPurchaseRecord = new ESDRecordOrderPurchase();
            List<ESDRecordOrderPurchaseLine> orderLines = new List<ESDRecordOrderPurchaseLine>();
            long dateNotSet = 0;
            int totalProducts = 0;

            //iterate through each order line and add to the purchase order record
            for (int i = 0; i < lines.Count(); i++)
            {
                ESDRecordOrderPurchaseLine orderLine = new ESDRecordOrderPurchaseLine();
                List<ESDRecordOrderLineTax> taxes = new List<ESDRecordOrderLineTax>();
                orderLine.lineType = ESDocumentConstants.ORDER_LINE_TYPE_PRODUCT;
                orderLine.salesOrderLineCode = "";
                orderLine.salesOrderLineNumber = "";
                orderLine.locationCode = lines[i].locationCode;
                orderLine.locationName = "";
                orderLine.keyLocationID = lines[i].keyLocationID;
                orderLine.UNSPSC = lines[i].UNSPSC;
                orderLine.language = lines[i].language;
                orderLine.quantity = lines[i].quantityOrdered;
                orderLine.priceExTax = lines[i].priceExTax;
                orderLine.priceIncTax = lines[i].priceIncTax;
                orderLine.priceTax = lines[i].priceTax;
                orderLine.priceUndiscountedExTax = lines[i].priceExTax;
                orderLine.priceUndiscountedIncTax = lines[i].priceIncTax;
                orderLine.priceUndiscountedTax = lines[i].priceTax;
                orderLine.priceTotalExTax = lines[i].totalPriceExTax;
                orderLine.priceTotalIncTax = lines[i].totalPriceIncTax;
                orderLine.priceTotalTax = lines[i].totalPriceTax;
                orderLine.priceTotalUndiscountedExTax = lines[i].totalPriceExTax;
                orderLine.priceTotalUndiscountedIncTax = lines[i].totalPriceIncTax;
                orderLine.priceTotalUndiscountedTax = lines[i].totalPriceTax;
                orderLine.isPriceFree = ESDocumentConstants.ESD_VALUE_NO;
                orderLine.entitySetPrice = "";
                orderLine.unitName = lines[i].unit;
                orderLine.keySellUnitID = "";
                orderLine.sellUnitBaseQuantity = lines[i].quantityOrdered;
                orderLine.priceReferenceCode = "";
                orderLine.priceReferenceType = "";
                orderLine.isKitted = ESDocumentConstants.ESD_VALUE_NO;;
                orderLine.kittedProductSetPrice = ESDocumentConstants.ESD_VALUE_NO;
                orderLine.isReserved = ESDocumentConstants.ESD_VALUE_NO;

                //set product details if the line is for an item
                if(lines[i].lineType == ESDocumentConstants.RECORD_LINE_TYPE_ITEM)
                { 
                    orderLine.keyProductID = lines[i].lineItemID;
                    orderLine.productCode = lines[i].lineItemCode;
                    orderLine.productName = "";
                    orderLine.productDescription = lines[i].description;
                    orderLine.salesOrderProductCode = "";
                    orderLine.width  = 0;
                    orderLine.height = 0;
                    orderLine.depth = 0;
                    orderLine.volume = 0;
                    orderLine.weight = 0;
                    orderLine.widthUnitMeasureCode = "";
                    orderLine.heightUnitMeasureCode = "";
                    orderLine.depthUnitMeasureCode = "";
                    orderLine.volumeUnitMeasureCode = "";
                    orderLine.weightUnitMeasureCode = "";
                    orderLine.drop = lines[i].drop;
                    orderLine.internalID = lines[i].internalID;

                    //add tax record
                    if(!String.IsNullOrWhiteSpace(lines[i].taxCode))
                    {
                        ESDRecordOrderLineTax lineTax = new ESDRecordOrderLineTax();
                        lineTax.keyTaxcodeID = "";
                        lineTax.taxcode = lines[i].taxCode;
                        lineTax.taxcodeLabel = "";
                        lineTax.taxRate = lines[i].taxCodeRatePercent;
                        lineTax.language = lines[i].language;
                        lineTax.quantity = lines[i].quantityOrdered;
                        lineTax.priceTax = lines[i].priceTax;
                        lineTax.priceTotalTax = lines[i].totalPriceTax;
                        lineTax.drop = 0;
                        lineTax.internalID = "";
                        taxes.Add(lineTax);
                    }
                }
                else if(lines[i].lineType == ESDocumentConstants.RECORD_LINE_TYPE_TEXT)
                {
                    orderLine.lineType = ESDocumentConstants.ORDER_LINE_TYPE_TEXT;
                    orderLine.textDescription = lines[i].description;
                }
                orderLine.productDeliveries = new List<ESDRecordOrderProductDelivery>();
                orderLine.attributes = new List<ESDRecordOrderLineAttributeProfile>();
                orderLine.taxes = taxes;
                orderLines.Add(orderLine);
            }

            //set details of the purchase order record
            orderPurchaseRecord.lines = orderLines;
            orderPurchaseRecord.payments = new List<ESDRecordOrderPayment>();
            orderPurchaseRecord.surcharges = new List<ESDRecordOrderSurcharge>();
            orderPurchaseRecord.purchaseOrderCode = orderID;
            orderPurchaseRecord.purchaseOrderNumber = orderNumber;
            orderPurchaseRecord.supplierAccountName = "";
            orderPurchaseRecord.sentDate = dateNotSet;
            orderPurchaseRecord.processedDate = dateNotSet;
            orderPurchaseRecord.dispatchedDate = dateNotSet;
            orderPurchaseRecord.receivedDate = deliveredDate;
            orderPurchaseRecord.modifiedDate = orderDate;
            orderPurchaseRecord.createdDate = creationDate;
            orderPurchaseRecord.eCommerceUserID = "";
            orderPurchaseRecord.eCommerceUserName = "";
            orderPurchaseRecord.eCommerceSystemID = "";
            orderPurchaseRecord.keyPurchaserID = "";
            orderPurchaseRecord.purchaserCode = purchaserCode;
            orderPurchaseRecord.purchaserName = purchaserName;
            orderPurchaseRecord.purchaserIndividual = ESDocumentConstants.ESD_VALUE_NO;
            orderPurchaseRecord.invoiceNumbers = new string[0];
            orderPurchaseRecord.supplierEntity = "";
            orderPurchaseRecord.supplierPersonName = "";
            orderPurchaseRecord.supplierOrgName = "";
            orderPurchaseRecord.supplierAuthorityNumbers = new string[0];
            orderPurchaseRecord.supplierAuthorityNumberLabels = new string[0];
            orderPurchaseRecord.supplierAuthorityNumberTypes = new int[0];
            orderPurchaseRecord.currencyISOCode = currencyCode;
            orderPurchaseRecord.paymentStatus = "";
            orderPurchaseRecord.paymentMethod = "";
            orderPurchaseRecord.paymentProprietaryCode = "";
            orderPurchaseRecord.paymentReceipt = "";
            orderPurchaseRecord.paymentAmount = 0;
            orderPurchaseRecord.keyPaymentTypeID = "";
            orderPurchaseRecord.salesOrderNumber = "";

            if (referenceType == ESDocumentConstants.RECORD_LINE_TYPE_ORDER_SALE)
            {
                orderPurchaseRecord.salesOrderNumber = referenceNumber;
            }
            orderPurchaseRecord.purchaserSystemID = "";
            orderPurchaseRecord.purchaserSystemName = "";
            orderPurchaseRecord.purchaserSystemCode = "";
            orderPurchaseRecord.sellerSystemID = "";
            orderPurchaseRecord.sellerSystemName = "";
            orderPurchaseRecord.sellerSystemCode = "";
            orderPurchaseRecord.deliveryDescription = "";
            orderPurchaseRecord.deliveryOrgName = deliveryOrgName;
            orderPurchaseRecord.deliveryContact = deliveryContact;
            orderPurchaseRecord.deliveryEmail = "";
            orderPurchaseRecord.deliveryPhone = "";
            orderPurchaseRecord.deliveryFax = "";
            orderPurchaseRecord.deliveryAddress1 = deliveryAddress1;
            orderPurchaseRecord.deliveryAddress2 = deliveryAddress2;
            orderPurchaseRecord.deliveryAddress3 = deliveryAddress3;
            orderPurchaseRecord.deliveryPostcode = deliveryPostcode;
            orderPurchaseRecord.deliveryRegionName = deliveryStateProvince;
            orderPurchaseRecord.deliveryCountryName = deliveryCountry;
            orderPurchaseRecord.deliveryCountryCodeISO2 = deliveryCountryCodeISO2;
            orderPurchaseRecord.deliveryCountryCodeISO3 = deliveryCountryCodeISO3;
            orderPurchaseRecord.billingDescription = "";
            orderPurchaseRecord.billingContact = billingContact;
            orderPurchaseRecord.billingOrgName = billingOrgName;
            orderPurchaseRecord.billingEmail = "";
            orderPurchaseRecord.billingPhone = "";
            orderPurchaseRecord.billingFax = "";
            orderPurchaseRecord.billingAddress1 = billingAddress1;
            orderPurchaseRecord.billingAddress2 = billingAddress2;
            orderPurchaseRecord.billingAddress3 = billingAddress3;
            orderPurchaseRecord.billingPostcode = billingPostcode;
            orderPurchaseRecord.billingRegionName = billingStateProvince;
            orderPurchaseRecord.billingCountryName = billingCountry;
            orderPurchaseRecord.billingCountryCodeISO2 = billingCountryCodeISO2;
            orderPurchaseRecord.billingCountryCodeISO3 = billingCountryCodeISO3;
            orderPurchaseRecord.email = "";
            orderPurchaseRecord.totalLines = lines.Count();
            orderPurchaseRecord.totalProducts = totalProducts;
            orderPurchaseRecord.totalLabour = 0;
            orderPurchaseRecord.totalDownloads = 0;
            orderPurchaseRecord.totalPriceExTax = totalExTax;
            orderPurchaseRecord.totalPriceIncTax = totalIncTax;
            orderPurchaseRecord.totalTax = totalTax;
            orderPurchaseRecord.totalVolume = 0;
            orderPurchaseRecord.totalWeight = 0;
            orderPurchaseRecord.totalSurchargeItems = 0;
            orderPurchaseRecord.totalSurchargeExTax = 0;
            orderPurchaseRecord.totalSurchargeIncTax = 0;
            orderPurchaseRecord.totalSurchargeTax = 0;
            orderPurchaseRecord.totalPriceUndiscountedExTax = totalExTax;
            orderPurchaseRecord.totalPriceUndiscountedIncTax = totalIncTax;
            orderPurchaseRecord.totalPriceUndiscountedTax = totalTax;
            orderPurchaseRecord.instructions = comment;
            orderPurchaseRecord.freightCarrierCode = freightCarrierCode;
            orderPurchaseRecord.freightCarrierName = freightCarrierName;
            orderPurchaseRecord.freightSystemRefCode = freightSystemRefCode;
            orderPurchaseRecord.freightCarrierConsignCode = freightCarrierConsignCode;
            orderPurchaseRecord.freightCarrierTrackingCode = freightCarrierTrackingCode;
            orderPurchaseRecord.freightCarrierServiceCode = freightCarrierServiceCode;
            orderPurchaseRecord.freightCarrierAccountCode = freightCarrierAccountCode;
            orderPurchaseRecord.isDropship = ESDocumentConstants.ESD_VALUE_NO;
            orderPurchaseRecord.keyLocationID = keyLocationID;
            orderPurchaseRecord.locationCode = locationCode;
            orderPurchaseRecord.locationName = locationLabel;
            orderPurchaseRecord.isMultiLocation = ESDocumentConstants.ESD_VALUE_NO;
            orderPurchaseRecord.shippingMethod = "";
            orderPurchaseRecord.accountDiscountRate = 0;
            orderPurchaseRecord.accountTerritory = "";
            orderPurchaseRecord.isProductsDelivered = ESDocumentConstants.ESD_VALUE_NO;
            orderPurchaseRecord.totalVolumeMeasureCode = "";
            orderPurchaseRecord.totalWeightMeasureCode = "";
            orderPurchaseRecord.drop = drop;
            orderPurchaseRecord.internalID = internalID;

            return orderPurchaseRecord;
        }
    }
}
