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
using System.Data;
using System.Runtime.Serialization;

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standards Record that holds data for a single sales order. A sales order indicates an intent of a customer account to make a purchase.</summary>
    [DataContract]
    public class ESDRecordOrderSale
    {
        /// <summary>UNPAID - No payment was received as yet</summary>
        public static readonly string PAYMENT_METHOD_UNPAID = "UNPAID";
        /// <summary>CREDIT - A payment was made with a credit card</summary>
        public static readonly string PAYMENT_METHOD_CREDIT = "CREDITCARD";
        /// <summary>COD - Payment will be made with cash when the goods are delivered to the delivery location</summary>
        public static readonly string PAYMENT_METHOD_CASHONDELIVERY = "COD";
        /// <summary>DIRECTDEPOSIT - Payment has been made with a direct bank transfer</summary>
        public static readonly string PAYMENT_METHOD_DIRECTDEPOSIT = "DIRECTDEPOSIT";
        /// <summary>QUOTE - No payment was made as a quote was only required</summary>
        public static readonly string PAYMENT_METHOD_QUOTE = "QUOTE";
        /// <summary>NONE - No payment was made or needed</summary>
        public static readonly string PAYMENT_METHOD_NONE = "NONE";
        /// <summary>PROPRIETARY - A payment was made using a proprietary payment system. PayPal could be one example of this.</summary>
        public static readonly string PAYMENT_METHOD_PROPRIETARY = "PROPRIETARY";
        /// <summary>ACCOUNT - A payment will be assigned to a customer account and paid based on the agreed payment terms</summary>
        public static readonly string PAYMENT_METHOD_ACCOUNT = "ACCOUNT";

        /// <summary>UNPAID - The order has not been paid for</summary>
        public static readonly string PAYMENT_STATUS_UNPAID = "UNPAID";
        /// <summary>PENDING - A payment is currently in the process of being paid for, or is waiting on a process to complete</summary>
        public static readonly string PAYMENT_STATUS_PENDING = "PENDING";
        /// <summary>PAID - The order has been paid</summary>
        public static readonly string PAYMENT_STATUS_PAID = "PAID";
        /// <summary>DECLINED - A payment failed when trying to be paid</summary>
        public static readonly string PAYMENT_STATUS_DECLINED = "DECLINED";
        /// <summary>NONREQUIRED - No payment is required to pay for the order</summary>
        public static readonly string PAYMENT_STATUS_NONREQUIRED = "NONREQUIRED";

        /// <summary>List of lines set to the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordOrderSaleLine> lines { get; set; }
        /// <summary>List of surcharge lines set to the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordOrderSurcharge> surcharges { get; set; }
        /// <summary>List of payments set to the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordOrderPayment> payments { get; set; }

        /// <summary>Key that allows the sale order record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keySalesOrderID { get; set; }
        /// <summary>Code of the sales order, may or may not be a unqiue indentifier</summary>
        [DataMember]
        public string salesOrderCode { get; set; }
        /// <summary>Number of the sales order, may or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderNumber { get; set; }
        /// <summary>Key of the customer account record that is assigned to the order. The customer indicates the purchaser of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCustomerAccountID { get; set; }
        /// <summary>Code of the customer account, may or not be a unique identifier of the account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerAccountCode { get; set; }
        /// <summary>Name of the customer account</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerAccountName { get; set; }
        /// <summary>Date that the order was sent</summary>
        [DataMember]
        public long sentDate { get; set; }
        /// <summary>Date that the order was processed. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember]
        public long processedDate { get; set; }
        /// <summary>Date that the order's goods were sent out. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember]
        public long dispatchedDate { get; set; }
        /// <summary>Date that the order's goods were received by the purchaser. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember]
        public long receivedDate { get; set; }
        /// <summary>Date that the order was last modified. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember]
        public long modifiedDate { get; set; }
        /// <summary>Date that the order was created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember]
        public long createdDate { get; set; }
        /// <summary>ID of the user in the associated Ecommerce system where the order was created.</summary>
        [DataMember]
        public string eCommerceUserID { get; set; }
        /// <summary>Name of the user in the associated Ecommerce system where the order was created. Ideally this is set to a label of the user, and not the credentials used for a user to login (since that could be a security issue passing around such information).</summary>
        [DataMember]
        public string eCommerceUserName { get; set; }
        /// <summary>ID of the associated Ecommerce system where the order was created. Ideally each system sets its own unique identifier, formatted such as ORG_NAME.SYSTEM_NAME</summary>
        [DataMember]
        public string eCommerceSystemID { get; set; }
        /// <summary>Key of the sales representative record linked to the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySalesRepID { get; set; }
        /// <summary>Code of the sales representative.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesRepCode { get; set; }
        /// <summary>Name of the sales representative.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesRepName { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the sales representative is an individual person.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesRepIndividual { get; set; }
        /// <summary>Customer entity buying the order. Set it to one of the constants in the ESDocumentConstants class prefixed with ENTITY_TYPE_</summary>
        [DataMember]
        public string customerEntity { get; set; }
        /// <summary>Name of the person who is the customer of the order.</summary>
        [DataMember]
        public string customerPersonName { get; set; }
        /// <summary>Name of the organisation who is the customer of the order.</summary>
        [DataMember]
        public string customerOrgName { get; set; }
        /// <summary>Authority numbers of the customer of the order.</summary>
        [DataMember]
        public string[] customerAuthorityNumbers { get; set; }
        /// <summary> list of Labels set for the customer authority numbers. Ensure that the array length is the same as the authorityNumbers property, or left empty</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] customerAuthorityNumberLabels { get; set; }
        /// <summary>list of authority number types matching the customer authority numbers. If set, must use the ESDocumentConstants that are prefixed with "AUTHORITY_NUM_". Ensure that the array length is the same as the authorityNumbers property, or left empty.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int[] customerAuthorityNumberTypes { get; set; }
        /// <summary>Currency that all monetary amounts of the order are set with. This currency code must be the 3 digit ISO currency code.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyISOCode { get; set; }
        /// <summary>Status indicating how the order has been paid for. Set it to one of the constants in the class prefixed with PAYMENT_STATUS_</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentStatus { get; set; }
        /// <summary>Method on how the order is being paid for. The field must be set to one of the class's constants prefixed by PAYMENT_METHOD_</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentMethod { get; set; }
        /// <summary>Code the proprietary system that is used as the payment method for the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentProprietaryCode { get; set; }
        /// <summary>Number that contains a reference to the payment applied against the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentReceipt { get; set; }
        /// <summary>Monetary amount already paid for the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal paymentAmount { get; set; }
        /// <summary>Number of the purchase order that may be associated to the sales order. This may be used for referencing purposes.</summary>
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
        /// <summary>List of the invoice numbers linked to this sales order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] invoiceNumbers = new string[0];
        /// <summary>Description of the address that the ordered goods are being delivered to</summary>
        [DataMember]
        public string deliveryDescription { get; set; }
        /// <summary>Name of the contact person at the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryContact { get; set; }
        /// <summary>Name of the organisation that the orders goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryOrgName { get; set; }
        /// <summary>Email of the contact person at the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryEmail { get; set; }
        /// <summary>Phone number at the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryPhone { get; set; }
        /// <summary>Fax number at the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryFax { get; set; }
        /// <summary>First delivery address field that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress1 { get; set; }
        /// <summary>Second delivery address field that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress2 { get; set; }
        /// <summary>Third delivery address field that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress3 { get; set; }
        /// <summary>Post code of the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryPostcode { get; set; }
        /// <summary>Name of the region/state/province at the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryRegionName { get; set; }
        /// <summary>Name of the country at the address that the ordered goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountryName { get; set; }
        /// <summary>Code of the country at the address that the ordered goods are being delivered to as a 2 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO2 { get; set; }
        /// <summary>Code of the country at the address that the ordered goods are being delivered to as a 3 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO3 { get; set; }
        /// <summary>Description of the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingDescription { get; set; }
        /// <summary>Name of the contact person at the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingContact { get; set; }
        /// <summary>Name of the organisation that the orders goods are being billing to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingOrgName { get; set; }
        /// <summary>Email address at the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingEmail { get; set; }
        /// <summary>Phone number at the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingPhone { get; set; }
        /// <summary>Fax number at the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingFax { get; set; }
        /// <summary>First address field associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress1 { get; set; }
        /// <summary>Second address field associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress2 { get; set; }
        /// <summary>Third address field associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress3 { get; set; }
        /// <summary>Postcode of the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingPostcode { get; set; }
        /// <summary>Name of the region/state/province of the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingRegionName { get; set; }
        /// <summary>Name of the country of the address associated with the billing of the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingCountryName { get; set; }
        /// <summary>Code of the country of the address associated with the billing of the order as a two digit code set by the ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingCountryCodeISO2 { get; set; }
        /// <summary>Code of the country of the address associated with the billing of the order as a three digit code set by the ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingCountryCodeISO3 { get; set; }
        /// <summary>Email address set for the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string email { get; set; }
        /// <summary>Total number of lines in the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int totalLines { get; set; }
        /// <summary>Total number of product lines in the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public int totalProducts { get; set; }
        /// <summary>Total number of labour lines in the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public int totalLabour { get; set; }
        /// <summary>Total number of download lines in the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public int totalDownloads { get; set; }
        /// <summary>Total monetary price of the order exclusive of tax</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceExTax { get; set; }
        /// <summary>Total monetary price of the order inclusive of tax</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceIncTax { get; set; }
        /// <summary>Total monetary amount of taxes applied to the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalTax { get; set; }
        /// <summary>Total weight of the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalWeight { get; set; }
        /// <summary>Total volume of the ordered goods</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalVolume { get; set; }
        /// <summary>Total number of surcharges applied to the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public int totalSurchargeItems { get; set; }
        /// <summary>Total monetary amount of surcharges applied to the order exclusive of taxes</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeExTax { get; set; }
        /// <summary>Total monetary amount of surcharges applied to the order inclusive of taxes</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeIncTax { get; set; }
        /// <summary>Total monetary amount of taxes applied to surcharges in the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeTax { get; set; }
        /// <summary>Total monetary amount of the order before discounts were applied, exclusive of taxes. This amount may be useful when showing discounts applied to an order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceUndiscountedExTax { get; set; }
        /// <summary>Total monetary amount of the order before discounts were applied, inclusive of taxes. This amount may be useful when showing discounts applied to an order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceUndiscountedIncTax { get; set; }
        /// <summary>Total monetary amount of taxes applied to the order before discounts were applied. This amount may be useful when showing discounts applied to an order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceUndiscountedTax { get; set; }
        /// <summary>Text describing instructions on how to handle the order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string instructions { get; set; }
        /// <summary>Code of the freight carrier delivering the ordered goods</summary>
        [DataMember]
        public string freightCarrierCode { get; set; }
        /// <summary>Name of the freight carrier delivering the orders goods</summary>
        [DataMember]
        public string freightCarrierName { get; set; }
        /// <summary>Reference code to the system used to process the freight order</summary>
        [DataMember]
        public string freightSystemRefCode { get; set; }
        /// <summary>Consignment code issued by the freight carrier to delivery the ordered goods</summary>
        [DataMember]
        public string freightCarrierConsignCode { get; set; }
        /// <summary>Code to track the freight carrier delivering the ordered goods</summary>
        [DataMember]
        public string freightCarrierTrackingCode { get; set; }
        /// <summary>Code of the service provided by the freight carrier to deliver the ordered goods</summary>
        [DataMember]
        public string freightCarrierServiceCode { get; set; }
        /// <summary>Code of the account in the freight carrier's system</summary>
        [DataMember]
        public string freightCarrierAccountCode { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the order is being supplied by a different entity from supplier assigned to the order.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string isDropship { get; set; }
        /// <summary>key of the location where the products for the order can be found.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }
        /// <summary>Code of the location</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationCode { get; set; }
        /// <summary>Name of the location</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationName { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the ordered goods are to be obtained across multiple locations.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string isMultiLocation { get; set; }
        /// <summary>Method that the order is being shipped by</summary>
        [DataMember(EmitDefaultValue = false)]
        public string shippingMethod { get; set; }
        /// <summary>Percentage rate discounted off the order monetary total based on the discount assigned to the order's customer account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal accountDiscountRate { get; set; }
        /// <summary>Territory associated with the customer account</summary>
        [DataMember(EmitDefaultValue = false)]
        public string accountTerritory { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that all products for the order have been delivered.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string isProductsDelivered { get; set; }
        /// <summary>Code of the unit of measure for the volume</summary>
        [DataMember]
        public string totalVolumeMeasureCode { get; set; }
        /// <summary>Code of the unit of measure for the weight</summary>
        [DataMember]
        public string totalWeightMeasureCode { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>constructor</summary>
        public ESDRecordOrderSale()
        {
            lines = new List<ESDRecordOrderSaleLine>();
            surcharges = new List<ESDRecordOrderSurcharge>();
            payments = new List<ESDRecordOrderPayment>();
        }

        /// <summary>sets default values for members that have no values set</summary>
        public void setDefaultValuesForNullMembers()
        {
            if (lines == null)
            {
                lines = new List<ESDRecordOrderSaleLine>();
            }

            if (surcharges == null){
                surcharges = new List<ESDRecordOrderSurcharge>();
            }

            if (payments == null){
                payments = new List<ESDRecordOrderPayment>();
            }

            if(keySalesOrderID == null){
                keySalesOrderID = "";
            }

            if (billingDescription == null){
                billingDescription = "";
            }
            
            if (billingContact == null){
                billingContact = "";
            }

            if (billingOrgName == null)
            {
                billingOrgName = "";
            }
            
            if (billingEmail == null){
                billingEmail = "";
            }
            
            if (billingPhone == null){
                billingPhone = "";
            }
            
            if (billingFax == null){
                billingFax = "";
            }
            
            if (billingAddress1 == null){
                billingAddress1 = "";
            }
            
            if (billingAddress2 == null){
                billingAddress2 = "";
            }
            
            if (billingAddress3 == null){
                billingAddress3 = "";
            }
            
            if (billingPostcode == null){
                billingPostcode = "";
            }
            
            if (billingRegionName == null){
                billingRegionName = "";
            }
            
            if (billingCountryName == null){
                billingCountryName = "";
            }
            
            if (billingCountryCodeISO2 == null){
                billingCountryCodeISO2 = "";
            }

            if (billingCountryCodeISO3 == null){
                billingCountryCodeISO3 = "";
            }

            if (deliveryDescription == null){
                deliveryDescription = "";
            }

            if (deliveryContact == null){
                deliveryContact = "";
            }

            if (deliveryOrgName == null){
                deliveryOrgName = "";
            }

            if (deliveryEmail == null){
                deliveryEmail = "";
            }

            if (deliveryPhone == null){
                deliveryPhone = "";
            }

            if (deliveryFax == null){
                deliveryFax = "";
            }

            if (deliveryAddress1 == null){
                deliveryAddress1 = "";
            }

            if (deliveryAddress2 == null){
                deliveryAddress2 = "";
            }

            if (deliveryAddress3 == null){
                deliveryAddress3 = "";
            }

            if (deliveryPostcode == null){
                deliveryPostcode = "";
            }

            if (deliveryRegionName == null){
                deliveryRegionName = "";
            }

            if (deliveryCountryName == null){
                deliveryCountryName = "";
            }

            if (deliveryCountryCodeISO2 == null){
                deliveryCountryCodeISO2 = "";
            }

            if (deliveryCountryCodeISO3 == null){
                deliveryCountryCodeISO3 = "";
            }

            if (salesOrderCode == null){
                salesOrderCode = "";
            }

            if (keyCustomerAccountID == null){
                keyCustomerAccountID = "";
            }

            if (customerAccountCode == null){
                customerAccountCode = "";
            }

            if (customerAccountName == null){
                customerAccountName = "";
            }

            if (salesOrderNumber == null){
                salesOrderNumber = "";
            }

            if (customerAuthorityNumbers == null){
                customerAuthorityNumbers = new string[0];
            }

            if (customerAuthorityNumberLabels == null){
                customerAuthorityNumberLabels = new string[0];
            }

            if (customerAuthorityNumberTypes == null){
                customerAuthorityNumberTypes = new int[0];
            }

            if(eCommerceUserID == null){
                eCommerceUserID="";
            }

            if (eCommerceUserName == null){
                eCommerceUserName = "";
            }

            if (eCommerceSystemID == null){
                eCommerceSystemID="";
            }

            if (keySalesRepID == null){
                keySalesRepID = "";
            }
             
            if(salesRepCode == null){
                salesRepCode="";
            }

            if(salesRepName == null){
                salesRepName="";
            }

            if (salesRepIndividual == null){
                salesRepIndividual = "";
            }

            if (customerEntity == null){
                customerEntity = "";
            }

            if (customerPersonName == null){
                customerPersonName = "";
            }

            if (customerOrgName == null){
                customerOrgName = "";
            }

            if (currencyISOCode == null){
                currencyISOCode = "";
            }    

            if(paymentStatus == null){
                paymentStatus="";
            }
                        
            if(purchaseOrderNumber == null){
                purchaseOrderNumber="";
            }

            if (purchaserSystemID == null){
                purchaserSystemID = "";
            }

            if (purchaserSystemName == null){
                purchaserSystemName = "";
            }

            if(purchaserSystemCode == null){
                purchaserSystemCode = "";
            }

            if (sellerSystemID == null){
                sellerSystemID = "";
            }

            if(sellerSystemName == null){
                sellerSystemName = "";
            }

            if (sellerSystemCode == null){
                sellerSystemCode = "";
            }

            if (invoiceNumbers == null){
                invoiceNumbers=new string[0];
            }

            if(email == null){
                email="";
            }

            if(instructions == null){
                instructions="";
            }
            
            if(paymentMethod == null){
                paymentMethod="";
            }

            if(paymentProprietaryCode==null){
                paymentProprietaryCode = "";
            }
                                    
            if(paymentReceipt == null){
                paymentReceipt="";
            }

            if(freightCarrierCode == null){
                freightCarrierCode="";
            }

            if(freightCarrierName == null){
                freightCarrierName="";
            }

            if(freightSystemRefCode == null){
                freightSystemRefCode="";
            }

            if(freightCarrierConsignCode == null){
                freightCarrierConsignCode="";
            }

            if(freightCarrierTrackingCode == null){
                freightCarrierTrackingCode="";
            }

            if(freightCarrierServiceCode == null){
                freightCarrierServiceCode="";
            }

            if(freightCarrierAccountCode == null){
                freightCarrierAccountCode="";
            }

            if(isDropship == null){
                isDropship="N";
            }

            if(keyLocationID == null){
                keyLocationID="";
            }

            if(locationCode == null){
                locationCode="";
            }

            if(locationName == null){
                locationName="";
            }

            if (isMultiLocation == null){
                isMultiLocation = "N";
            }

            if(shippingMethod == null){
                shippingMethod="";
            }

            if(accountTerritory == null){
                accountTerritory="";
            }

            if (isProductsDelivered == null){
                isProductsDelivered = "N";
            }

            if (totalVolumeMeasureCode == null){
                totalVolumeMeasureCode = "";
            }

            if (totalWeightMeasureCode == null){
                totalWeightMeasureCode = "";
            }

            if (internalID == null){
                internalID = "";
            }
        }
    }
}
