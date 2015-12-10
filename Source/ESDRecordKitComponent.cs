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
    /// <summary>Ecommerce Standards Record that holds data for a single product, download, or labour assigned to a kit. A kit allows any number of products, downloads, or labour to be assigned it.</summary>
    [DataContract]
    public class ESDRecordKitComponent
    {
        /// <summary>Key of the product record that is identified as the parent of the kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyKitProductID { get; set; }
        /// <summary>Key of the download record that is identified as the parent of the kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyKitDownloadID { get; set; }
        /// <summary>Key of the labour record that is identified as the parent of the kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyKitLabourID { get; set; }
        /// <summary>Key of the product record that linked as a child, or component product of the kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyComponentProductID { get; set; }
        /// <summary>Key of the download record that linked as a child, or component download of the kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyComponentDownloadID { get; set; }
        /// <summary>Key of the labour record that linked as a child, or component labour of the kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyComponentLabourID { get; set; }
        /// <summary>Amount of units of the components that are added to the kit</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantity { get; set; }
        /// <summary>Numeric value to order the components by. If multiple component products, downloads, or labour are assigned to a kit then this field may be used to sort the components.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
    }
}
