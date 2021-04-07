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
    /// <summary>Ecommerce Standards record that contains the data of a single transaction that can be queried for a customer account. A transaction record contains information about a positive or negative amount applied against the customer account's balance, as well the balance after the amount was applied. The account enquiry aspect denotes that the record may be queried in real time and contain additional information associated with the record.</summary>
    [DataContract]
    public class ESDRecordCustomerAccountEnquiryTransaction
    {
        /// <summary>Key that allows the customer account transaction record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyTransactionID { get; set; }
        /// <summary>ID that allows the transaction to be identified with. May or may not be unique.</summary>
        [DataMember]
        public string transactionID { get; set; }
        /// <summary>Number that is associated to the transaction. This number can be used for referencing purposes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string transactionNumber { get; set; }
        /// <summary>Key of the customer account record assigned to the transaction.</summary>
        [DataMember]
        public string keyCustomerAccountID { get; set; }
        /// <summary>Code of the customer account assigned to the transaction.</summary>
        [DataMember]
        public string customerAccountCode { get; set; }
        /// <summary>Text that describes any information associated with the transaction</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Date that the transaction record was created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long creationDate { get; set; }
        /// <summary>Date set to the transaction. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long transactionDate { get; set; }
        /// <summary>Key of an entity that is linked to the transaction as a reference. A Reference could be an ID of a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceKeyID { get; set; }
        /// <summary>Type of entity that is linked to the transaction as a reference.  A Reference could be a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceType { get; set; }
        /// <summary>Number that provides a reference to the transaction.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceNumber { get; set; }
        /// <summary>Monetary amount that denotes the balance of the customer account's after the transaction was applied.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal balance { get; set; }
        /// <summary>Monetary amount negated from the customer account's balance. If set then the creditAmount property should not contain a value.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal debitAmount { get; set; }
        /// <summary>Monetary amount added to the customer account's balance. If set then the debitAmount property should not contain a value.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal creditAmount { get; set; }
        /// <summary>Language that all text is described in. Set it to one of the LANG constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }
        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored in the transaction with</summary>
        [DataMember]
        public string currencyCode { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
