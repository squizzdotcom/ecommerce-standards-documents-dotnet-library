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
    /// <summary>Ecommerce Standards record that contains the data of a single Payment that can be queried for a customer account. A payment record contains information about a positive monetary amount paid to the customer account's balance. The account enquiry aspect denotes that the record may be queried in real time and contain additional information associated with the record.</summary>
    [DataContract]
    public class ESDRecordCustomerAccountEnquiryPayment
    {
        /// <summary>Key that allows the customer account payment record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyPaymentID { get; set; }
        /// <summary>ID that allows the payment to be identified with. May or may not be unique.</summary>
        [DataMember]
        public string paymentID { get; set; }
        /// <summary>Number that is associated to the payment. This number can be used for referencing purposes.</summary>
        [DataMember]
        public string paymentNumber { get; set; }
        /// <summary>Key of the customer account record assigned to the payment.</summary>
        [DataMember]
        public string keyCustomerAccountID { get; set; }
        /// <summary>Code of the customer account assigned to the payment.</summary>
        [DataMember]
        public string customerAccountCode { get; set; }
        /// <summary>Date that the payment record was created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long creationDate { get; set; }
        /// <summary>Date set to the payment. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long paymentDate { get; set; }
        /// <summary>Key of an entity that is linked to the payment as a reference. A Reference could be an ID of a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceKeyID { get; set; }
        /// <summary>Type of entity that is linked to the payment as a reference.  A Reference could be a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceType { get; set; }
        /// <summary>Number that provides a reference to the payment.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceNumber { get; set; }
        /// <summary>Text, number or code that the customer uses to identify the payment record. This could be the customer's purchase order order, supplier invoice code, or an other identifier.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerReference { get; set; }
        /// <summary>total monetary amount the payment applies</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalAmount { get; set; }
        /// <summary>Total number of surcharges applied to the payment</summary>
        [DataMember(EmitDefaultValue = false)]
        public int totalSurchargeItems { get; set; }
        /// <summary>Total monetary amount of surcharges applied to the payment exclusive of taxes</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeExTax { get; set; }
        /// <summary>Total monetary amount of surcharges applied to the payment inclusive of taxes</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeIncTax { get; set; }
        /// <summary>Total monetary amount of taxes applied to surcharges in the payment</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalSurchargeTax { get; set; }
        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored in the payment with</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyCode { get; set; }
        /// <summary>Text that describes any information associated with the payment</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Text that contains additional comments that have been made for the payment</summary>
        [DataMember(EmitDefaultValue = false)]
        public string comment { get; set; }
        /// <summary>Language that all text is described in. Set it to one of the LANG constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
        /// <summary>List of lines in the payment</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordCustomerAccountEnquiryPaymentLine[] lines { get; set; }
    }
}
