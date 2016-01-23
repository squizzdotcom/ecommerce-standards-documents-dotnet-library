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
using System.Runtime.Serialization;

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standard Document that holds details of a record associated to a payment made by a customer account</summary>
    [DataContract]
    public class ESDRecordCustomerAccountPaymentRecord
    {
        /// <summary>Key that allows the record of the customer account payment to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyCustomerAccountPaymentRecordID { get; set; }
        /// <summary>Key of the record linked to the payment. This would typically be the key of an invoice or order record.</summary>
        [DataMember]
        public string keyRecordID { get; set; }
        /// <summary>ID the the record. This would typically be the ID of an invoice or order record.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string recordID { get; set; }
        /// <summary>Monetary amount applied against the record</summary>
        [DataMember]
        public decimal amount { get; set; }
        /// <summary>The type of record that the payment is applied to. The field must be set to one of the ESDRecordCustomerAccountPayment class's constants prefixed by PAYMENT_METHOD_</summary>
        [DataMember]
        public string recordType { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>sets default values for members that have no values set</summary>
        public void setDefaultValuesForNullMembers()
        {
            if (keyRecordID == null)
            {
                keyRecordID = "";
            }

            if (recordID == null)
            {
                recordID = "";
            }

            if (recordType == null)
            {
                recordType = "";
            }
        }
    }
}
