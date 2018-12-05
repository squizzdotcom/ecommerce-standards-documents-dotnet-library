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
    /// <summary>Ecommerce Standards Record that holds data for a single payment associated to an invoice.</summary>
    [DataContract]
    public class ESDRecordInvoicePayment
    {
        /// <summary>Method on how the payment was made. The field must be set to one of the class's constants prefixed by PAYMENT_METHOD_ within the ESDocument CONSTANTS</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentMethod { get; set; }
        /// <summary>Monetary amount the payment applies to</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal paymentAmount { get; set; }
        /// <summary>Receipt number associated to the payment.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentReceipt { get; set; }
        /// <summary>Code the proprietary system that is used as the payment method.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentProprietaryCode { get; set; }

        /// <summary>Key of the payment type record that is assigned to the payment. The payment type record indicates how the payment was made.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyPaymentTypeID { get; set; }

        /// <summary>Date that the payment was made. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long paidDate { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>sets default values for members that have no values</summary>
        public void setDefaultValuesForNullMembers()
        {
            if (paymentMethod == null)
            {
                paymentMethod = "";
            }
         
            if (paymentReceipt == null)
            {
                paymentReceipt = "";
            }
         
            if (paymentProprietaryCode== null)
            {
                paymentProprietaryCode = "";
            }
         
            if (keyPaymentTypeID== null)
            {
                keyPaymentTypeID = "";
            }
         
            if (internalID== null)
            {
                internalID = "";
            }
        }
    }
}