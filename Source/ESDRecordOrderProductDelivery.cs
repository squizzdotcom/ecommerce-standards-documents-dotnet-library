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
    /// <summary>Ecommerce Standards Record that holds data for a single product delivery associated to an order.</summary>
    [DataContract]
    public class ESDRecordOrderProductDelivery
    {
        /// <summary>Quantity of product units delivered</summary>
        [DataMember]
        public decimal quantity { get; set; }
        /// <summary>Date that the products were delivered. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember]
        public long deliveryDate { get; set; }
        /// <summary>Code of the invoice that the product delivery is associated with.</summary>
        [DataMember]
        public string invoiceCode { get; set; }
        /// <summary>Code of the line in the invoice that the product delivery is associated with.</summary>
        [DataMember]
        public string invoiceLineCode { get; set; }
        /// <summary>Code of the delivery. May or may not be a unique identifier</summary>
        [DataMember]
        public string deliveryCode { get; set; }
        /// <summary>Code of the line in the delivery. May or may not be a unique identifier</summary>
        [DataMember]
        public string deliveryLineCode { get; set; }
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

            if (invoiceCode == null)
            {
                invoiceCode = "";
            }

            if (invoiceLineCode == null)
            {
                invoiceLineCode = "";
            }

            if (deliveryCode == null)
            {
                deliveryCode = "";
            }

            if (deliveryLineCode == null)
            {
                deliveryLineCode = "";
            }

            if (internalID == null)
            {
                internalID = "";
            }
        }
    }
}
