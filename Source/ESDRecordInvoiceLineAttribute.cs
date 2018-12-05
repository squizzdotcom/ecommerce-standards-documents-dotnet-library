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
    /// <summary>Ecommerce Standards Record that holds data for a single attribute and value within an invoice line. This allows any additional fields and field values to be with the invoice line.</summary>
    [DataContract]
    public class ESDRecordInvoiceLineAttribute
    {
        /// <summary>Key of the attribute record that the line is associated to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyAttributeID { get; set; }

        /// <summary>Code of the attribute.  May or may not be a unqiue identifier.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string attributeCode { get; set; }

        /// <summary>name of the attribute.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string attributeName { get; set; }

        /// <summary>value of the attribute.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string attributeValue { get; set; }

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
            if (attributeCode == null)
            {
                attributeCode = "";
            }

            if (attributeName == null)
            {
                attributeName = "";
            }

            if (keyAttributeID == null)
            {
                keyAttributeID = "";
            }

            if (attributeValue == null)
            {
                attributeValue = "";
            }

            if (internalID == null)
            {
                internalID = "";
            }
        }
    }
}