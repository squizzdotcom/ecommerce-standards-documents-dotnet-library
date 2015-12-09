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
    /// <summary>Ecommerce Standards Record for storing the field data associated to a product combination profile. Each field can contain any number of field-values, which allows products to be assigned to.</summary>
    [DataContract]
    public class ESDRecordProductCombinationProfileField
    {
        /// <summary>Key that allows the product combination profile field record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyProductComboProfileFieldID { get; set; }
        /// <summary>Name of the field</summary>
        [DataMember(EmitDefaultValue = false)]
        public string fieldName {get; set;}
        /// <summary>Numeric value to order the field by. This ordering may be used when multiple fields are assigned to same product combination profile</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering {get; set;}
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>List of field value labels. Each label can contain any text to label the field. Ensure that the length of the list matches the fieldValueIDs array</summary>
        [DataMember]
        public string[] fieldValues{get; set;}
        /// <summary>List of field value IDs. Each value ID uniquely identifies the field value. Ensure that the length of the list matches the fieldValues array</summary>
        [DataMember]
        public string[] fieldValueIDs { get; set; }
    }
}
