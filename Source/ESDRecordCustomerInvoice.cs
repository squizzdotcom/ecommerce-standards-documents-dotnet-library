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

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standards Record that holds data for a single invoice raised against a customer. A customer invoice specifies goods and/or services that have been purchased from a customer, and the monetary amount that the customer owes.</summary>
    [DataContract]
    public class ESDRecordCustomerInvoice
    {
        /// <summary>List of lines stored against the invoice. Each line specifies a product, labour, download or text line stored within the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public List<ESDRecordCustomerInvoiceLine> lines { get; set; }

        /// <summary>List of surcharge lines stored against the invoice. Each surcharge indicates a charge applied against the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public List<ESDRecordInvoiceSurcharge> surcharges { get; set; }

        /// <summary>List of payment lines to the invoice. Each payment line indicates the amount paid by the customer against the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public List<ESDRecordInvoicePayment> payments { get; set; }

        /// <summary>Key that allows the customer invoice record to be uniquely identified and linked to.</summary>
		[DataMember]
        public string keyCustomerInvoiceID { get; set; }

        /// <summary>Code of the customer invoice, may or may not be a unique identifier, the code may be made up of the customer invoice number and any prefix or suffix text</summary>
		[DataMember]
        public string customerInvoiceCode { get; set; }

        /// <summary>Number of the customer invoice, may or may not be a unique identifier</summary>
		[DataMember(EmitDefaultValue = false)]
        public string customerInvoiceNumber { get; set; }

        /// <summary>Key of the customer account record that is assigned to the invoice. The customer indicates the the entity supplying the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string keyCustomerAccountID { get; set; }

        /// <summary>Code of the customer account, may or not be a unique identifier of the account. human known identifier of the customer account.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string customerAccountCode { get; set; }

        /// <summary>Name of the customer account. Could be an organisation name, person's name, or an other label.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string customerAccountName { get; set; }
	
	    /// <summary>Key of the sales order record that allows the customer invoice record to be linked to an associated sales order originally raised</summary>
		[DataMember(EmitDefaultValue = false)]
        public string keySalesOrderID { get; set; }

        /// <summary>Code of the sales order record that may be linked to the customer invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public string salesOrderCode { get; set; }

        /// <summary>Number of the sales order record that may be linked to the customer invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public string salesOrderNumber { get; set; }

        /// <summary>Date that the invoice was sent</summary>
		[DataMember(EmitDefaultValue = false)]
        public long sentDate{ get; set; }

        /// <summary>Date that the invoice was processed. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
		[DataMember(EmitDefaultValue = false)]
        public long processedDate{ get; set; }

        /// <summary>Date that the invoiced goods were sent out. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
		[DataMember(EmitDefaultValue = false)]
        public long dispatchedDate{ get; set; }

        /// <summary>Date that the invoiced goods were received. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
		[DataMember(EmitDefaultValue = false)]
        public long receivedDate{ get; set; }

        /// <summary>Date that the customer invoice was last modified. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
		[DataMember(EmitDefaultValue = false)]
        public long modifiedDate{ get; set; }

        /// <summary>Date that the invoice was created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
		[DataMember(EmitDefaultValue = false)]
        public long createdDate{ get; set; }
	
	    /// <summary>Date that the invoice is due to be paid. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
		[DataMember(EmitDefaultValue = false)]
        public long paymentDueDate{ get; set; }
	
	    /// <summary>Date that the invoice was fully paid. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
		[DataMember(EmitDefaultValue = false)]
        public long fullyPaidDate{ get; set; }

        /// <summary>ID of the user in the associated Ecommerce system where the invoice was created.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string eCommerceUserID { get; set; }

        /// <summary>Name of the user in the associated Ecommerce system where the order was created. Ideally this is  to a label of the user, and not the credentials used for a user to login (since that could be a security issue passing around such information).</summary>
		[DataMember(EmitDefaultValue = false)]
        public string eCommerceUserName { get; set; }

        /// <summary>ID of the associated Ecommerce system where the invoice was created. Ideally each system s its own unique identifier, formatted such as ORG_NAME.SYSTEM_NAME</summary>
		[DataMember(EmitDefaultValue = false)]
        public string eCommerceSystemID { get; set; }

        /// <summary>Key of the sales representative record linked to the customer invoice. May indicate the person, organisation or other entity who raised the invoice, or sold the goods/services for the supplier</summary>
		[DataMember(EmitDefaultValue = false)]
        public string keySalesRepID { get; set; }

        /// <summary>Code of the sales representative</summary>
		[DataMember(EmitDefaultValue = false)]
        public string salesRepCode { get; set; }

        /// <summary>Name of the sales representative. It could be the name of the organisation, person, or other entity who raised in the invoice, or sold the goods/services  for the supplier</summary>
		[DataMember(EmitDefaultValue = false)]
        public string salesRepName { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the sales representative is an individual person, otherwise is a organisation or other entity.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string salesRepIndividual { get; set; }

        /// <summary>Type of entity purchasing goods/services in the invoice. Set it to one of the constants in the ESDocumentConstants class prefixed with ENTITY_TYPE_</summary>
		[DataMember(EmitDefaultValue = false)]
        public string customerEntity { get; set; }

        /// <summary>Name of the person who is the customer of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string customerPersonName { get; set; }

        /// <summary>Name of the organisation who is the customer of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string customerOrgName { get; set; }

        /// <summary>Authority numbers of the customer of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string[] customerAuthorityNumbers { get; set; }

        /// <summary>list of Labels  for the customer authority numbers. Ensure that the array length is the same as the authorityNumbers property, or left empty</summary>
		[DataMember(EmitDefaultValue = false)]
        public string[] customerAuthorityNumberLabels { get; set; }

        /// <summary>list of authority number types matching the customer authority numbers. If set must use the ESDocumentConstants that are prefixed with "AUTHORITY_NUM_". Ensure that the array length is the same as the authorityNumbers property, or left empty.</summary>
		[DataMember(EmitDefaultValue = false)]
        public int[] customerAuthorityNumberTypes { get; set; }

        /// <summary>Currency that all monetary amounts of the invoice are made with. This currency code must be the 3 digit ISO currency code.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string currencyISOCode { get; set; }

        /// <summary>Status indicating how the invoice has been paid for. Set it to one of the ESDocumentConstants constants in the class prefixed with PAYMENT_STATUS_</summary>
		[DataMember(EmitDefaultValue = false)]
        public string paymentStatus { get; set; }

        /// <summary>Method on how the invoice is being paid for. The field must be one of the ESDocumentConstants class's constants prefixed by PAYMENT_METHOD_</summary>
		[DataMember(EmitDefaultValue = false)]
        public string paymentMethod { get; set; }

        /// <summary>Code the proprietary system that is used as the payment method for the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string paymentProprietaryCode { get; set; }

        /// <summary>Number that contains a reference to the payment applied against the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public string paymentReceipt { get; set; }

        /// <summary>Monetary amount paid for the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal paymentAmount{ get; set; }

        /// <summary>Key of the payment type record that is associated to the payment. The payment type record indicates how the payment was made for the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string keyPaymentTypeID { get; set; }

        /// <summary>Number of the customer's purchase order that may be associated to the customer invoice. This may be used for referencing purposes.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string purchaseOrderNumber { get; set; }

        /// <summary>ID of the system that the purchasing entity stores its data within.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string purchaserSystemID { get; set; }

        /// <summary>Name of the system that the purchasing entity stores its data within.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string purchaserSystemName { get; set; }

        /// <summary>Code of the system that the purchasing entity stores its data within.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string purchaserSystemCode { get; set; }

        /// <summary>ID of the system that the selling entity stores its data within.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string sellerSystemID { get; set; }

        /// <summary>Name of the system that the selling entity stores its data within.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string sellerSystemName { get; set; }

        /// <summary>Code of the system that the selling entity stores its data within.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string sellerSystemCode { get; set; }

        /// <summary>Description of the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryDescription { get; set; }

        /// <summary>Name of the organisation at the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryOrgName { get; set; }

        /// <summary>Name of the contact person at the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryContact { get; set; }

        /// <summary>Email of the contact person at the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryEmail { get; set; }

        /// <summary>Phone number at the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryPhone { get; set; }

        /// <summary>Fax number at the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryFax { get; set; }

        /// <summary>First delivery address field that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryAddress1 { get; set; }

        /// <summary>Second delivery address field that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryAddress2 { get; set; }

        /// <summary>Third delivery address field that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryAddress3 { get; set; }

        /// <summary>Post code of the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryPostcode { get; set; }

        /// <summary>Name of the region/state/province at the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryRegionName { get; set; }

        /// <summary>Name of the country at the address that the invoiced goods are being delivered to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryCountryName { get; set; }

        /// <summary>Code of the country at the address that the invoiced goods are being delivered to as a 2 digit code  by ISO standards.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO2 { get; set; }

        /// <summary>Code of the country at the address that the invoiced goods are being delivered to as a 3 digit code  by ISO standards.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO3 { get; set; }

        /// <summary>Description of the address associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingDescription { get; set; }

        /// <summary>Name of the contact person at the address associated with the billing of the invoiced.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingContact { get; set; }

        /// <summary>Name of the organisation that the invoiced goods are being billing to</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingOrgName { get; set; }

        /// <summary>Email address at the address associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingEmail { get; set; }

        /// <summary>Phone number at the address associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingPhone { get; set; }

        /// <summary>Fax number at the address associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingFax { get; set; }

        /// <summary>First address field associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingAddress1 { get; set; }

        /// <summary>Second address field associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingAddress2 { get; set; }

        /// <summary>Third address field associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingAddress3 { get; set; }

        /// <summary>Postcode of the address associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingPostcode { get; set; }

        /// <summary>Name of the region/state/province of the address associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingRegionName { get; set; }

        /// <summary>Name of the country of the address associated with the billing of the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingCountryName { get; set; }

        /// <summary>Code of the country of the address associated with the billing of the invoice as a two digit code  by the ISO standards.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingCountryCodeISO2 { get; set; }

        /// <summary>Code of the country of the address associated with the billing of the invoice as a three digit code  by the ISO standards.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string billingCountryCodeISO3 { get; set; }

        /// <summary>Email address  for the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>Total number of lines in the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public int totalLines{ get; set; }

        /// <summary>Total number of product lines in the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public int totalProducts{ get; set; }

        /// <summary>Total number of labour lines in the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public int totalLabour{ get; set; }

        /// <summary>Total number of download lines in the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public int totalDownloads{ get; set; }

        /// <summary>Total monetary price of the invoice exclusive of tax</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalPriceExTax{ get; set; }

        /// <summary>Total monetary price of the invoice inclusive of tax</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalPriceIncTax{ get; set; }

        /// <summary>Total monetary amount of taxes applied to the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalTax{ get; set; }

        /// <summary>Total volume of the invoiced goods</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalVolume{ get; set; }

        /// <summary>Total weight of the invoiced goods</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalWeight{ get; set; }

        /// <summary>Total number of surcharges applied to the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public int totalSurchargeItems{ get; set; }

        /// <summary>Total monetary amount of surcharges applied to the invoice exclusive of taxes</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeExTax{ get; set; }

        /// <summary>Total monetary amount of surcharges applied to the invoice inclusive of taxes</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeIncTax{ get; set; }

        /// <summary>Total monetary amount of taxes applied to surcharges in the invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeTax{ get; set; }

        /// <summary>Total monetary amount of the invoice before discounts were applied, exclusive of taxes. This amount may be useful when showing discounts applied to an order.</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalPriceUndiscountedExTax{ get; set; }

        /// <summary>Total monetary amount of the invoice before discounts were applied, inclusive of taxes. This amount may be useful when showing discounts applied to an order.</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalPriceUndiscountedIncTax{ get; set; }

        /// <summary>Total monetary amount of taxes applied to the invoice before discounts were applied. This amount may be useful when showing discounts applied to an order.</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal totalPriceUndiscountedTax { get; set; }

        /// <summary>Text describing instructions on how to handle the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string instructions { get; set; }

        /// <summary>Code of the freight carrier delivering the invoiced goods</summary>
		[DataMember(EmitDefaultValue = false)]
        public string freightCarrierCode { get; set; }

        /// <summary>Name of the freight carrier delivering the invoiced goods</summary>
		[DataMember(EmitDefaultValue = false)]
        public string freightCarrierName { get; set; }

        /// <summary>Reference code to the system used to process the freight invoice</summary>
		[DataMember(EmitDefaultValue = false)]
        public string freightSystemRefCode { get; set; }

        /// <summary>Consignment code issued by the freight carrier to delivery the invoiced goods</summary>
		[DataMember(EmitDefaultValue = false)]
        public string freightCarrierConsignCode { get; set; }

        /// <summary>Code to track the freight carrier delivering the invoiced goods</summary>
		[DataMember(EmitDefaultValue = false)]
        public string freightCarrierTrackingCode { get; set; }

        /// <summary>Code of the service provided by the freight carrier to deliver the invoiced goods</summary>
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
        /// If 'Y' then indicates that the is being delivered to a different entity from the customer assigned to the invoice.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string isDropship { get; set; }

        /// <summary>key of the location where the products for the invoice can be found. The key stores the unique identifier of the location. The location may be a warehouse, site, office or other location.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }

        /// <summary>Code of the location</summary>
		[DataMember(EmitDefaultValue = false)]
        public string locationCode { get; set; }

        /// <summary>Name of the location</summary>
		[DataMember(EmitDefaultValue = false)]
        public string locationName { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the invoiced goods are to be obtained across multiple locations.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isMultiLocation { get; set; }
	
	    /// <summary>key of the external location where the products for the invoice can be found. This external location may be the location where goods are being delivered to or held at.</summary>
		[DataMember(EmitDefaultValue = false)]
	    public string externalKeyLocationID { get; set; }
	
	    /// <summary>Code of the external location. This external location may be the location where goods are being delivered to or held at.</summary>
		[DataMember(EmitDefaultValue = false)]
	    public string externalLocationCode { get; set; }
	
	    /// <summary>Name of the external location. This external location may be the location where goods are being delivered to or held at.</summary>
		[DataMember(EmitDefaultValue = false)]
	    public string externalLocationName { get; set; }

        /// <summary>Method that the invoice is being shipped by</summary>
		[DataMember(EmitDefaultValue = false)]
        public string shippingMethod { get; set; }

        /// <summary>Percentage rate discounted off the invoice monetary total.</summary>
		[DataMember(EmitDefaultValue = false)]
        public decimal accountDiscountRate{ get; set; }

        /// <summary>Territory associated with the customer account</summary>
		[DataMember(EmitDefaultValue = false)]
        public string accountTerritory { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that all products for the invoice have been delivered.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string isProductsDelivered { get; set; }

        /// <summary>Code of the unit of measure for the volume</summary>
		[DataMember(EmitDefaultValue = false)]
        public string totalVolumeMeasureCode { get; set; }

        /// <summary>Code of the unit of measure for the weight</summary>
		[DataMember(EmitDefaultValue = false)]
        public string totalWeightMeasureCode { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or  it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
		[DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>Constructor</summary>
        public ESDRecordCustomerInvoice()
        {
            lines = new List<ESDRecordCustomerInvoiceLine>();
            surcharges = new List<ESDRecordInvoiceSurcharge>();
            payments = new List<ESDRecordInvoicePayment>();
        }

        /// <summary>sets default values for members that have no values</summary>
        public void setDefaultValuesForNullMembers(){
            if (lines == null)
            {
                lines = new List<ESDRecordCustomerInvoiceLine>();
            }
         
            if (surcharges == null)
            {
                surcharges = new List<ESDRecordInvoiceSurcharge>();
            }
         
            if (payments == null)
            {
                payments = new List<ESDRecordInvoicePayment>();
            }
            else
            {
                foreach(ESDRecordInvoicePayment payment in payments)
                {
                    payment.setDefaultValuesForNullMembers();
                }
            }
		
            if (keyCustomerInvoiceID== null)
            {
                keyCustomerInvoiceID = "";
            }
		
		    if (customerInvoiceCode== null)
            {
                customerInvoiceCode = "";
            }
		
		    if (customerInvoiceNumber== null)
            {
                customerInvoiceNumber = "";
            }

		    if (keySalesOrderID== null)
            {
                keySalesOrderID = "";
            }
         
            if (salesOrderCode == null)
            {
                salesOrderCode = "";
            }
         
            if (purchaseOrderNumber == null)
            {
                purchaseOrderNumber = "";
            }
         
            if (salesRepIndividual == null)
            {
                salesRepIndividual = "";
            }
         
            if (currencyISOCode == null)
            {
                currencyISOCode = "";
            }
         
            if (customerAuthorityNumbers == null)
            {
                customerAuthorityNumbers = new string[0];
            }
         
            if (keyCustomerAccountID == null)
            {
                keyCustomerAccountID = "";
            }
         
            if (customerAccountCode == null)
            {
                customerAccountCode = "";
            }
         
            if (customerAccountName == null)
            {
                customerAccountName = "";
            }
         
            if (keySalesRepID == null)
            {
                keySalesRepID = "";
            }
         
            if (salesRepCode == null)
            {
                salesRepCode = "";
            }
         
            if (salesRepName == null)
            {
                salesRepName = "";
            }
         
            if (purchaserSystemID == null)
            {
                purchaserSystemID = "";
            }
         
            if (purchaserSystemName == null)
            {
                purchaserSystemName = "";
            }
         
            if (purchaserSystemCode == null)
            {
                purchaserSystemCode = "";
            }
         
            if (sellerSystemID == null)
            {
                sellerSystemID = "";
            }
         
            if (sellerSystemName == null)
            {
                sellerSystemName = "";
            }
         
            if (sellerSystemCode == null)
            {
                sellerSystemCode = "";
            }
         
            if (eCommerceUserID == null)
            {
                eCommerceUserID = "";
            }
         
            if (eCommerceUserName == null)
            {
                eCommerceUserName = "";
            }
         
            if (eCommerceSystemID == null)
            {
                eCommerceSystemID = "";
            }
         
            if (customerEntity == null)
            {
                customerEntity = "";
            }
         
            if (customerPersonName == null)
            {
                customerPersonName = "";
            }
         
            if (customerOrgName == null)
            {
                customerOrgName = "";
            }
         
            if (customerAuthorityNumbers == null)
            {
                customerAuthorityNumbers = new string[0];
            }
         
            if (customerAuthorityNumberLabels == null)
            {
                customerAuthorityNumberLabels = new string[0];
            }
         
            if (customerAuthorityNumberTypes == null)
            {
                customerAuthorityNumberTypes = new int[0];
            }
         
            if (paymentStatus == null)
            {
                paymentStatus = ESDocumentConstants.PAYMENT_STATUS_UNPAID;
            }
         
            if (paymentMethod == null)
            {
                paymentMethod = ESDocumentConstants.PAYMENT_METHOD_UNPAID;
            }
         
            if (paymentProprietaryCode == null)
            {
                paymentProprietaryCode = "";
            }
         
            if (paymentReceipt == null)
            {
                paymentReceipt = "";
            }
         
            if (instructions == null)
            {
                instructions = "";
            }
         
            if (salesOrderNumber == null)
            {
                salesOrderNumber = "";
            }
         
            if (keyLocationID == null)
            {
                keyLocationID = "";
            }
         
            if (locationCode == null)
            {
                locationCode = "";
            }
         
            if (locationName == null)
            {
                locationName = "";
            }
		
		    if (externalKeyLocationID == null)
		    {
			    externalKeyLocationID = "";
		    }

		    if (externalLocationCode == null)
		    {
			    externalLocationCode = "";
		    }

		    if (externalLocationName == null)
		    {
			    externalLocationName = "";
		    }
         
            if (freightCarrierCode == null)
            {
                freightCarrierCode = "";
            }
         
            if (freightCarrierName == null)
            {
                freightCarrierName = "";
            }
         
            if (freightSystemRefCode == null)
            {
                freightSystemRefCode = "";
            }
         
            if (freightCarrierConsignCode == null)
            {
                freightCarrierConsignCode = "";
            }
         
            if (freightCarrierTrackingCode == null)
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
         
            if (deliveryDescription == null)
            {
                deliveryDescription = "";
            }
         
            if (deliveryOrgName == null)
            {
                deliveryOrgName = "";
            }
         
            if (deliveryContact == null)
            {
                deliveryContact = "";
            }
         
            if (deliveryEmail == null)
            {
                deliveryEmail = "";
            }
         
            if (deliveryPhone == null)
            {
                deliveryPhone = "";
            }
         
            if (deliveryFax == null)
            {
                deliveryFax = "";
            }
         
            if (email == null)
            {
                email = "";
            }
         
            if (deliveryAddress1 == null)
            {
                deliveryAddress1 = "";
            }
         
            if (deliveryAddress2 == null)
            {
                deliveryAddress2 = "";
            }
         
            if (deliveryAddress3 == null)
            {
                deliveryAddress3 = "";
            }
         
            if (deliveryPostcode == null)
            {
                deliveryPostcode = "";
            }
         
            if (deliveryRegionName == null)
            {
                deliveryRegionName = "";
            }
         
            if (deliveryCountryName == null)
            {
                deliveryCountryName = "";
            }
         
            if (deliveryPostcode == null)
            {
                deliveryPostcode = "";
            }
         
            if (deliveryCountryCodeISO2 == null)
            {
                deliveryCountryCodeISO2 = "";
            }
         
            if (deliveryCountryCodeISO3 == null)
            {
                deliveryCountryCodeISO3 = "";
            }
         
            if (billingDescription == null)
            {
                billingDescription = "";
            }
         
            if (billingOrgName == null)
            {
                billingOrgName = "";
            }
         
            if (billingContact == null)
            {
                billingContact = "";
            }
         
            if (billingEmail == null)
            {
                billingEmail = "";
            }
         
            if (billingPhone == null)
            {
                billingPhone = "";
            }
         
            if (billingFax == null)
            {
                billingFax = "";
            }
         
            if (billingAddress1 == null)
            {
                billingAddress1 = "";
            }
         
            if (billingAddress2 == null)
            {
                billingAddress2 = "";
            }
         
            if (billingAddress3 == null)
            {
                billingAddress3 = "";
            }
         
            if (billingPostcode == null)
            {
                billingPostcode = "";
            }
         
            if (billingRegionName == null)
            {
                billingRegionName = "";
            }
         
            if (billingCountryName == null)
            {
                billingCountryName = "";
            }
         
            if (billingCountryCodeISO2 == null)
            {
                billingCountryCodeISO2 = "";
            }
         
            if (billingCountryCodeISO3 == null)
            {
                billingCountryCodeISO3 = "";
            }
         
            if (billingCountryCodeISO3 == null)
            {
                billingCountryCodeISO3 = "";
            }
         
            if (totalVolumeMeasureCode == null)
            {
                totalVolumeMeasureCode = "";
            }
         
            if (totalWeightMeasureCode == null)
            {
                totalWeightMeasureCode = "";
            }
         
            if (isProductsDelivered == null)
            {
                isProductsDelivered = ESDocumentConstants.ESD_VALUE_NO;
            }
         
            if (isDropship == null)
            {
                isDropship = ESDocumentConstants.ESD_VALUE_NO;
            }
         
            if (isMultiLocation== null)
            {
                isMultiLocation= ESDocumentConstants.ESD_VALUE_NO;
            }
         
            if (shippingMethod== null)
            {
                shippingMethod = "";
            }
         
            if (accountTerritory== null)
            {
                accountTerritory = "";
            }
         
            if (isProductsDelivered== null)
            {
                isProductsDelivered = ESDocumentConstants.ESD_VALUE_NO;
            }
         
            if (internalID== null)
            {
                internalID = "";
            }        
        }
    }
}