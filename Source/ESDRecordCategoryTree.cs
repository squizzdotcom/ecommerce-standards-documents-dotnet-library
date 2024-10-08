﻿/// <remarks>
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
    /// <summary>Ecommerce Standards record that contains data for a single category tree. A category tree represents an overall hierarchical collection of categories, used to navigate and find associated products, maker models etc.. assigned to each category.</summary>
    [DataContract]
    public class ESDRecordCategoryTree
    {
        /// <summary>Key that allows the category record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyCategoryTreeID { get; set; }

        /// <summary>Code of the category tree. May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string categoryTreeCode { get; set; }

        /// <summary>Name of the category tree.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>Description field of the category tree. It may contain any text used to describe the category tree.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }

        /// <summary>Number to order the category tree by. This may be used to order a number of category trees that appear within a list.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }

        /// <summary>Either 'N'-No or 'Y'-Yes. If 'Y' then indicates that the category tree is used for navigation of maker/model data, and grouping of products assigned to each model through the tree's catgories.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isMakerModelCategoryTree { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
