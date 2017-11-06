/// <remarks>
/// Copyright (C) 2018 Squizz PTY LTD
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
    /// <summary>Ecommerce Standards Record that holds data for a single model created or assembled by a maker/manufacturer. Each model is made up of a collection of products or raw materials.</summary>
    [DataContract]
    public class ESDRecordMakerModel
    {
        /// <summary>Key that allows the maker's model record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyMakerModelID { get; set; }
        /// <summary>Key of the maker/manufacturer that creates or assembles the model.</summary>
        [DataMember]
        public string keyMakerID { get; set; }
        /// <summary>Code of the model. May or may not be a unqiue identifier.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string modelCode { get; set; }
        /// <summary>Secondary code of the model which may be used further identify it.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string modelSubCode { get; set; }
        /// <summary>Name of the model.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>Code that allows the model to searched on. This search code may or may not be unique, and would typically contain key words that allows the model to be found.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string modelSearchCode { get; set; }
        /// <summary>Class that allows the model to be grouped with other models of the same type.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string groupClass { get; set; }
        /// <summary>Date that the model was released by the maker/manufacturer. This date may be designated by the maker as the official date that the model was first made available and known by. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long releasedDate { get; set; }
        /// <summary>Date that the model was created. This date may be considered an internal date only relevant to the maker completing production of the first model. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long createdDate { get; set; }
        /// <summary> list of attributes and values associated to the model. This allows almost any kind of data to be set against the model in the from of attribute key value pairs</summary>
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
