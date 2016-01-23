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
    /// <summary>Ecommerce Standards Record that holds data for a single taxcode. Each taxcode defines a type of tax that can be calculated for any relevant monetary price.</summary>
    [DataContract]
    public class ESDRecordTaxcode
    {
        /// <summary>Key of the taxcode record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyTaxcodeID { get; set; }
        /// <summary>Taxcode.  May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxcode { get; set; }
        /// <summary>Label of the taxcode</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxcodeLabel { get; set; }
        /// <summary>Text to describe the taxcode</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Numeric amount as a percentage rate that the taxcode applies to. Eg. if set to 10, then a 10% tax will be applied on top of a price.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal taxcodePercentageRate { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
