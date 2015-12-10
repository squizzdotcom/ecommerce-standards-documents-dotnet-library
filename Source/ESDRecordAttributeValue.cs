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
    /// <summary>Ecommerce Standards Record that holds data for a single product, download, or labour attribute value.</summary>
    [DataContract]
    public class ESDRecordAttributeValue
    {
        /// <summary>Key of the product record that the attribute value is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Key of the download record that the attribute value is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }
        /// <summary>Key of the labour record that the attribute value is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }
        /// <summary>Key of the attribute profile record that the attribute assigned to the value is set to.</summary>
        [DataMember]
        public string keyAttributeProfileID { get; set; }
        /// <summary>Key of the attribute record that the value is set to.</summary>
        [DataMember]
        public string keyAttributeID { get; set; }
        /// <summary>text of the attribute value, if its attribute data type is set to string.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string stringValue { get; set; }
        /// <summary>number of the attribute value, if its attribute data type is set to number.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal numberValue { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
    }
}
