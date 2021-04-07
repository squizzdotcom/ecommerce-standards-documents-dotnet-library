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
    /// <summary>Ecommerce Standards Record that holds data for a single sales representative. A sales representative represents an entity (person or organisation) that may sell products, manage customer accounts, and place sales orders on behalf of customers among other things.</summary>
    [DataContract]
    public class ESDRecordSalesRep
    {
        /// <summary>Key of the sales representative record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keySalesRepID { get; set; }
        /// <summary>Code of the sales representative. May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesRepCode { get; set; }
        /// <summary>Name of sales representative</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>Name of contact person</summary>
        [DataMember(EmitDefaultValue = false)]
        public string contact { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the sales representative is an individual person.
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
