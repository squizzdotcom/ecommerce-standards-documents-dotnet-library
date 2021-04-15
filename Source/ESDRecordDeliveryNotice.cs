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
    /// <summary>Ecommerce Standards Record that holds data for a single delivery notice. The delivery notice (also known as an Advanced Ship Notice (ASN)) advises of the delivery of products being made by the supplier. The notice can advise when goods are being packed, dispatched, in-transit, held in storage, delivered, lost, or cancelled</summary>
    [DataContract]
    public class ESDRecordDeliveryNotice
    {
	    /// <summary>List of lines  to the invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordDeliveryNoticeLine> lines { get; set; }

        /// <summary>Unique identifier of the delivery notice.</summary>
        [DataMember]
        public string keyDeliveryNoticeID { get; set; }
	
	    /// <summary>Code of the delivery. May or may not be a unique identifier. The code is a human known identifier of the delivery notice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryNoticeCode { get; set; }

        /// <summary>status of the delivery, indicates where the goods are located at within the delivery/shipping process.
	    /// Set it to one of the DELIVERY_STATUS_ constants in the ESDocumentConstants class.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryStatus { get; set; }

        /// <summary>message that advises of the status of the delivery. The message could contain details specific to status of where the delivery is at</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryStatusMessage { get; set; }

        /// <summary>Key identifier of the customer account record that the delivery notice is associated to. The customer indicates the entity of the goods being delivered for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCustomerAccountID { get; set; }

        /// <summary>Key identifier of the supplier account record that the delivery notice is associated to. The supplier indicates the entity of the goods being delivered from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySupplierAccountID { get; set; }

        /// <summary>key identifier of the sales order that the delivery notice is associated to.References the sales order that the goods being delivered were ordered from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySalesOrderID { get; set; }

        /// <summary>Code of the sales order that the delivery notice is associated to. The code is a human known identifier of a sales order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderCode { get; set; }

        /// <summary>Number of the sales order that the delivery notice is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderNumber { get; set; }

        /// <summary>key identifier of the purchase order that the delivery notice is associated to. References the purchase order that the goods being delivered were requested from by the customer.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyPurchaseOrderID { get; set; }

        /// <summary>Code of the purchase order that the delivery notice is associated to. The code is a human known identifier of a purchase order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderCode { get; set; }

        /// <summary>Number of the purchase order that the delivery notice is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderNumber { get; set; }

        /// <summary>key identifier of the customer invoice that the delivery notice is associated to. References the customer invoice that the goods being delivered were confirmed from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCustomerInvoiceID { get; set; }

        /// <summary>Code of the customer invoice that the delivery notice is associated to. The code is a human known identifier of a customer invoice.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerInvoiceCode { get; set; }

        /// <summary>Number of the customer invoice that the delivery notice is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerInvoiceNumber { get; set; }

        /// <summary>key identifier of the supplier invoice that the delivery notice is associated to. References the supplier invoice that the goods being delivered were confirmed from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySupplierInvoiceID { get; set; }

        /// <summary>Code of the supplier invoice that the delivery notice is associated to. The code is a human known identifier of a customer invoice.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplierInvoiceCode { get; set; }

        /// <summary>Number of the supplier invoice that the delivery notice is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplierInvoiceNumber { get; set; }

        /// <summary>key identifier of the location that the delivery notice is associated to. References the location that the goods being located at.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }

        /// <summary>Language that the delivery notice text is written in. Set it to a constant prefixed with LANG_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }

        /// <summary>Date that the products being delivered were packed for safe delivery. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long packedDate { get; set; }
	
	    /// <summary>Date that the products being delivered were loaded onto transport for delivery. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long loadedDate { get; set; }
	
	    /// <summary>Date that the order's goods were sent out. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long dispatchedDate { get; set; }
	
	    /// <summary>Date that the products were successfully delivered to the final destination. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long deliveredDate { get; set; }
	
	    /// <summary>Date that the products were unpacked from any packaging after being delivered to the final destination. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long unpackedDate { get; set; }
	
	    /// <summary>Date that the products were marked as being lost after being unable to be delivered. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long lostDate { get; set; }
	
	    /// <summary>Date that the products were marked as being damaged. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long damagedDate { get; set; }

        /// <summary>Date that the products were delivered. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long deliveryDate { get; set; }
	
	    /// <summary>Date that the products were delivered and received by the final receiving entity. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long receivedDate { get; set; }

        /// <summary>Date that the products were cancelled from being delivered. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long cancelledDate { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the goods are at a known geographic location, based on the latitude and longitude coordinates</summary>
        [DataMember(EmitDefaultValue = false)]
        public string atGeographicLocation = ESDocumentConstants.ESD_VALUE_NO;
	
	    /// <summary>Latitude co-ordinate of the geographic location where the goods are located at. The number must be between 90 and -90</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal locationLatitude { get; set; }

        /// <summary>longitude co-ordinate of the geographic location the goods are located at. The number must be between 180 and -180</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal locationLongitude { get; set; }
	
	    /// <summary>Text describing instructions on how to handle the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string instructions { get; set; }

        /// <summary>Code of the freight carrier delivering the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierCode { get; set; }

        /// <summary>Name of the freight carrier delivering the orders goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierName { get; set; }

        /// <summary>Reference code to the system used to process the freight order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightSystemRefCode { get; set; }

        /// <summary>Consignment code issued by the freight carrier to deliver the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierConsignCode { get; set; }

        /// <summary>Code to track the freight carrier delivering the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierTrackingCode { get; set; }

        /// <summary>Code of the service provided by the freight carrier to deliver the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierServiceCode { get; set; }
	
        /// <summary>Code of the account in the freight carrier's system</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCarrierAccountCode { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the order is being delivered to a different entity from the customer who purchased the products.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isDropship { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or  it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>s default values for members that have no values </summary>
        public void setDefaultValuesForNullMembers()
	    {
		    if (lines == null)
            {
                lines = new List<ESDRecordDeliveryNoticeLine>();
            }
		
            if (keyDeliveryNoticeID == null)
            {
                keyDeliveryNoticeID = "";
            }
		
		    if (deliveryNoticeCode == null)
            {
                deliveryNoticeCode = "";
            }
		
		    if(deliveryStatus == null)
		    {
			    deliveryStatus = ESDocumentConstants.DELIVERY_STATUS_AWAITING_PACKAGING;
		    }
		
		    if (deliveryStatusMessage== null)
            {
                deliveryStatusMessage = "";
            }

            if (keyCustomerAccountID == null)
            {
                keyCustomerAccountID = "";
            }

            if (keySupplierAccountID == null)
            {
                keySupplierAccountID = "";
            }

            if (keySalesOrderID == null)
            {
                keySalesOrderID = "";
            }

            if (salesOrderCode == null)
            {
                salesOrderCode = "";
            }

            if (salesOrderNumber == null)
            {
                salesOrderNumber = "";
            }

            if (keyPurchaseOrderID == null)
            {
                keyPurchaseOrderID = "";
            }

            if (purchaseOrderCode == null)
            {
                purchaseOrderCode = "";
            }

            if (purchaseOrderNumber == null)
            {
                purchaseOrderNumber = "";
            }

            if (keyCustomerInvoiceID == null)
            {
                keyCustomerInvoiceID = "";
            }

            if (customerInvoiceCode == null)
            {
                customerInvoiceCode = "";
            }

            if (customerInvoiceCode == null)
            {
                customerInvoiceCode = "";
            }

            if (customerInvoiceNumber == null)
            {
                customerInvoiceNumber = "";
            }

            if (keySupplierInvoiceID == null)
            {
                keySupplierInvoiceID = "";
            }

            if (supplierInvoiceCode == null)
            {
                supplierInvoiceCode = "";
            }

            if (supplierInvoiceNumber == null)
            {
                supplierInvoiceNumber = "";
            }

            if (keyLocationID == null)
            {
                keyLocationID = "";
            }

            if (atGeographicLocation== null)
            {
                atGeographicLocation = ESDocumentConstants.ESD_VALUE_NO;
            }
		
		    if (freightCarrierCode== null)
            {
                freightCarrierCode = "";
            }
		
		    if (freightCarrierName== null)
            {
                freightCarrierName = "";
            }
		
		    if (freightSystemRefCode== null)
            {
                freightSystemRefCode = "";
            }
		
		    if (freightCarrierConsignCode== null)
            {
                freightCarrierConsignCode = "";
            }
		
		    if (freightCarrierTrackingCode== null)
            {
                freightCarrierTrackingCode = "";
            }
		
		    if (freightCarrierServiceCode == null)
            {
                freightCarrierServiceCode = "";
            }
		
		    if (freightCarrierAccountCode == null)
            {
                freightCarrierAccountCode = "";
            }
		
		    if (isDropship == null)
            {
                isDropship = ESDocumentConstants.ESD_VALUE_NO;
            }
		
		    if (instructions== null)
            {
                instructions = "";
            }
		
		    if (language== null)
            {
                language = "";
            }
         
            if (internalID == null)
            {
                internalID = "";
            }        
        }
    }
}