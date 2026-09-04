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
    /// <summary>Ecommerce Standards Record that holds data for a single tax category. Each tax category definies a single collection of tax codes that can be calculated for any relevant monetary price.</summary>
    [DataContract]
    public class ESDRecordTaxCategory
    {
        /// <summary>Key of the tax category record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyTaxCategoryID { get; set; }
        /// <summary>Tax Category Code. Human known identifier of the tax category. May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxCategoryCode { get; set; }
        /// <summary>name of the tax category</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>Text to describe the tax category</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
