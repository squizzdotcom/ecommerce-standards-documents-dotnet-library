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
    /// <summary>Ecommerce Standards Record that holds data for a single item group. Each record represents a group of assigned products, downloads and/or labour.</summary>
    [DataContract]
    public class ESDRecordItemGroup
    {
        /// <summary>Key of the item Group record</summary>
        [DataMember]
        public string keyItemGroupID { get; set; }
        /// <summary>Code of the group, may or may not be a unique identifier.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string groupCode { get; set; }
        /// <summary>Label of item group.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string groupLabel { get; set; }
        /// <summary>Description of the item group.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string groupDescription { get; set; }
        /// <summary>List of key product record IDs that link product records to the group</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyProductIDs { get; set; }
        /// <summary>List of key download IDs that link download records to the group</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyDownloadIDs { get; set; }
        /// <summary>List of key labour IDs that link labour records to the group</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyLabourIDs { get; set; }

        /// <summary>Key product ID that denotes one product record in the group that is the default or primary representative of the group.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDefaultProductID { get; set; }
        /// <summary>Key download ID that denotes one download record in the group that is the default or primary representative of the group.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDefaultDownloadID { get; set; }
        /// <summary>Key labour ID that denotes one labour record in the group that is the default or primary representative of the group.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDefaultLabourID { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
