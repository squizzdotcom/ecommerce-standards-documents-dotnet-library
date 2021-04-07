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
    /// <summary>Ecommerce Standards Record that holds data for a single maker/manufacturer. A maker/manufacturer builds and/or assembles models which contain a collection of products or raw materials.</summary>
    [DataContract]
    public class ESDRecordMaker
    {
        /// <summary>Key that allows the maker record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyMakerID { get; set; }
        /// <summary>Code of the maker. May or may not be a unqiue identifier.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string makerCode { get; set; }
        /// <summary>Name of the maker.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>Code that allows the maker to searched on. This search code may or may not be unique, and would typically contain key words that allows the maker to be found.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string makerSearchCode { get; set; }
        /// <summary>Class that allows the maker to be grouped with other makers of the same type.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string groupClass { get; set; }
        /// <summary>Numeric value that may be set to control how the maker is ordered with other makers within a list</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal ordering { get; set; }
        /// <summary>Date that the maker was established. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long establishedDate { get; set; }
        /// <summary>Name of the organisation, if the maker is an organisation.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string orgName { get; set; }
        /// <summary> list of numbers of the government, or any other entity records that is associated with the maker. Ensure that the array length is the same as the authorityNumberLabels property, or left empty</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] authorityNumbers { get; set; }
        /// <summary> list of Labels set for the authority numbers. Ensure that the array length is the same as the authorityNumbers property, or left empty</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] authorityNumberLabels { get; set; }
        /// <summary>list of authority number types matching the authority numbers. If set must use the ESDocumentConstants that are prefixed with "AUTHORITY_NUM_". Ensure that the array length is the same as the authorityNumbers property, or left empty.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int[] authorityNumberTypes { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
