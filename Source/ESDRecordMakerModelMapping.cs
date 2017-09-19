/// <remarks>
/// Copyright (C) 2017 Squizz PTY LTD
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
    /// <summary>Ecommerce Standards Record that holds data for a single mapping between a maker/manufacturer's model, a category, and either a product, download, or labour entity. Each mapping may also contain any number of attribute values to contain more data about the mapping</summary>
    [DataContract]
    public class ESDRecordMakerModelMapping
    {
        /// <summary>Key of the maker/manufacturer model record.</summary>
        [DataMember]
        public string keyMakerModelID { get; set; }

        /// <summary>Hey of the category record, that is used to denote the category that the product, labour, or download is associated to for a given model</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCategoryID { get; set; }

        /// <summary>Key of the Product record.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }

        /// <summary>Key of the Labour record that the flag is assigned to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }

        /// <summary>Key of the Download record that the flag is assigned to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }

        /// <summary>Quantity of the product assigned to the model for the given category. The default is 1 if the quantity has not been set.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantity { get; set; }

        /// <summary> list of attributes and values associated to the product, download, or labour assigned to the model in the particular category.</summary>
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
