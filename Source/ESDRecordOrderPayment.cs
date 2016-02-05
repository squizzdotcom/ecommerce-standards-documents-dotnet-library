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
    /// <summary>Ecommerce Standards Record that holds data for a single payment associated to an order.</summary>
    [DataContract]
    public class ESDRecordOrderPayment
    {
        /// <summary>Method on how the payment was made. The field must be set to one of the class's constants prefixed by PAYMENT_METHOD_</summary>
        [DataMember]
        public string paymentMethod;
        /// <summary>Monetary amount the payment applies to</summary>
        [DataMember]
        public decimal paymentAmount;
        /// <summary>Receipt number associated to the payment.</summary>
        [DataMember]
        public string paymentReceipt;
        /// <summary>Code the proprietary system that is used as the payment method.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentProprietaryCode { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>sets default values for members that have no values set</summary>
        public void setDefaultValuesForNullMembers()
        {
            if (paymentMethod == null){
                paymentMethod = "";
            }

            if (paymentReceipt == null){
                paymentReceipt = "";
            }

            if (paymentProprietaryCode == null){
                paymentProprietaryCode = "";
            }

            if (internalID == null){
                internalID = "";
            }
        }
    }
}
