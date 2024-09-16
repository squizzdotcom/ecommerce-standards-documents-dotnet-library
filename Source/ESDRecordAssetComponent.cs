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
    /// <summary>Ecommerce Standards Record that holds data for a single relationship between an asset belonging to another parent asset. This allows an asset to be made of many component assets to make a single collective larger asset/resource</summary>
    [DataContract]
    public class ESDRecordAssetComponent
    {
        /// <summary>Key of the asset record.</summary>
        [DataMember]
        public string keyAssetID { get; set; }

        /// <summary>Hey of the category record, that is used to denote the category that the child asset is associated to for a given parent asset</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCategoryID { get; set; }

        /// <summary>Key of the asset record  that is the child asset that belongs to, or is a component of the parent asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyChildAssetID { get; set; }

        /// <summary> list of attributes and values associated to the child asset for the particular category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordAttributeValue> attributes { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
