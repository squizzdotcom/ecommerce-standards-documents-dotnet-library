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
    /// <summary>Ecommerce Standards Record that holds data for a single payment type. Each payment type defines a way to purchase goods and services, or the way that goods and servies were paid for.</summary>
    [DataContract]
    public class ESDRecordPaymentType
    {
        /// <summary>Key of the payment type record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyPaymentTypeID { get; set; }
        /// <summary>Code of the payment type.  May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentTypeCode { get; set; }
        /// <summary>Label of the payment type</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentTypeLabel { get; set; }
        /// <summary>Text to describe the payment type</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Method that the payment type relates to. Set null, or set it to ine of the PAYMENT_METHOD constants in the ESDocumentConstants class.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentMethod { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
