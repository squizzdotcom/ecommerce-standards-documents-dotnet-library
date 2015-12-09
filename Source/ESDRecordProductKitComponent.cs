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
    /// <summary>Ecommerce Standards Record that holds data for a single product assigned to a product kit. A product kit allows any number of products to be assigned it.</summary>
    [DataContract]
    public class ESDRecordProductKitComponent
    {
        /// <summary>Key of the product record that is identified as a kitted product</summary>
        [DataMember]
        public string keyKitProductID { get; set; }
        /// <summary>Key of the product record that linked as a child, or component product of the product kit</summary>
        [DataMember]
        public string keyComponentProductID { get; set; }
        /// <summary>Amount of units of the component product that are added to the product kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantity { get; set; }
        /// <summary>Numeric value to order the component product by. If multiple component products are assigned to a product kit then this field may be used to sort the component products.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
    }
}
