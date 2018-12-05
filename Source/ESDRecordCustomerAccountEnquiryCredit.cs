/// <remarks>
/// Copyright (C) 2019 Squizz PTY LTD
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
    /// <summary>Ecommerce Standards record that contains the data of a single Credit that can be queried for a customer account. A credit record contains information about a monetary amount applied to the account's balance. The account enquiry aspect denotes that the record may be queried in real time and contain additional information associated with the record.</summary>
    [DataContract]
    public class ESDRecordCustomerAccountEnquiryCredit
    {
        /// <summary>Key that allows the customer account credit record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyCreditID { get; set; }
        /// <summary>ID that allows the credit to be identified with. May or may not be unique.</summary>
        [DataMember]
        public string creditID { get; set; }
        /// <summary>Number that is associated to the credit. This number can be used for referencing purposes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string creditNumber { get; set; }
        /// <summary>Key of the customer account record assigned to the credit.</summary>
        [DataMember]
        public string keyCustomerAccountID { get; set; }
        /// <summary>Code of the customer account assigned to the credit.</summary>
        [DataMember]
        public string customerAccountCode { get; set; }
        /// <summary>Date that the credit record was created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long creationDate { get; set; }
        /// <summary>Date set to the credit. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long creditDate { get; set; }
        /// <summary>Monetary amount that the credit applies for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal appliedAmount { get; set; }
        /// <summary>Key of the location record associated to the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }
        /// <summary>Code of the location associated to the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationCode { get; set; }
        /// <summary>Label of the location associated to the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationLabel { get; set; }
        /// <summary>The type of location associated to the credit. Set it to one of the LOCATION_TYPE constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationType { get; set; }
        /// <summary>Key of an entity that is linked to the credit as a reference. A Reference could be a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceKeyID { get; set; }
        /// <summary>Type of entity that is linked to the credit as a reference.  A Reference could be a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceType { get; set; }
        /// <summary>Number that provides a reference to the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceNumber { get; set; }
        /// <summary>Text, number or code that the customer uses to identify the credit record. This could be the customer's purchase order order, supplier invoice code, or an other identifier.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerReference { get; set; }
        /// <summary>Code of the sales representative associated to the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesRepCode { get; set; }
        /// <summary>Name of the sales representative associated to the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesRepName { get; set; }
        /// <summary>Name of the contact person associated with the delivery address</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryContact { get; set; }
        /// <summary>Name of the organisation associated to the delivery address</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryOrgName { get; set; }
        /// <summary>First delivery address field set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress1 { get; set; }
        /// <summary>Second delivery address field set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress2 { get; set; }
        /// <summary>Third delivery address field set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryAddress3 { get; set; }
        /// <summary>Region/State/Province delivery address field set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryStateProvince { get; set; }
        /// <summary>Country delivery address field set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountry { get; set; }
        /// <summary>Code of the country at the delivery address as a 2 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO2 { get; set; }
        /// <summary>Code of the country at the delivery address as a 3 digit code set by ISO standards.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryCountryCodeISO3 { get; set; }
        /// <summary>Post code at the delivery address.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryPostcode { get; set; }
        /// <summary>Name of the contact person at the address associated with the billing of the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingContact { get; set; }
        /// <summary>Name of the organisation set against the billing address for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingOrgName { get; set; }
        /// <summary>First address field of the billing address set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress1 { get; set; }
        /// <summary>Second address field of the billing address set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress2 { get; set; }
        /// <summary>Third address field of the billing address set for the credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingAddress3 { get; set; }
        /// <summary>Name of the region/state/province that the credit is being billed to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string billingStateProvince { get; set; }
        /// <summary>Name of the country that the credit is being billed to.</summary>
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
        /// <summary>Tax number displayed on the credit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxNumber { get; set; }
        /// <summary>Label of the taxes assigned to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxLabel { get; set; }
        /// <summary>Percentage amount of tax that the applied to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal taxRate { get; set; }
        /// <summary>Total monetary amount of the credit excluding taxes</summary>
        [DataMember]
        public decimal totalExTax { get; set; }
        /// <summary>Total monetary amount of the credit including taxes</summary>
        [DataMember]
        public decimal totalIncTax { get; set; }
        /// <summary>Total monetary amount of tax applied to the credit's total</summary>
        [DataMember]
        public decimal totalTax { get; set; }
        /// <summary>Total monetary amount of freight inclusive of tax applied to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalFreightIncTax { get; set; }
        /// <summary>Total monetary amount of freight excluding tax applied to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalFreightExTax { get; set; }
        /// <summary>Total monetary amount of extra charges inclusive of tax applied to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalExtraChargesIncTax { get; set; }
        /// <summary>Total monetary amount of extra charges exclusive of tax applied to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalExtraChargesExTax { get; set; }
        /// <summary>Total monetary amount of discounts inclusive of tax discounted off the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalDiscountsIncTax { get; set; }
        /// <summary>Total monetary amount of discounts exclusive of tax discounted off the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalDiscountsExTax { get; set; }
        /// <summary>Total monetary amount of levies inclusive of tax applied to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalLeviesIncTax { get; set; }
        /// <summary>Total monetary amount of levies exclusive of tax applied to the credit's total</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalLeviesExTax { get; set; }
        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored in the credit with</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyCode { get; set; }
        /// <summary>Total quantity across all the credit lines</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalQuantity { get; set; }
        /// <summary>Text that describes any information associated with the credit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Language that all text is described in. Set it to one of the LANG constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }
        /// <summary>Text that contains additional comments that have been made for the credit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string comment { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
        /// <summary>List of lines in the credit</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryCreditLine[] lines { get; set; }
    }
}
