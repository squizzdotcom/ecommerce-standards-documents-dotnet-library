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
    /// <summary>Ecommerce Standards Record that holds data for a single purchaser. A purchaser represents an entity (person or organisation) that may buy products, manage supplier accounts, and place purchase orders with suppliers.</summary>
    [DataContract]
    public class ESDRecordPurchaser
    {
        /// <summary>Key of the purchaser record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyPurchaserID { get; set; }
        /// <summary>Code of the purchaser. May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaserCode { get; set; }
        /// <summary>Name of purchaser</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>Name of contact person</summary>
        [DataMember(EmitDefaultValue = false)]
        public string contact { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the purchaser is an individual person.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool isIndividual { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
