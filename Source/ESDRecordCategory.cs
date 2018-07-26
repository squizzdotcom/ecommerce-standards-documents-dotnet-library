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
    /// <summary>Ecommerce Standards record that contains data for a single category. A category is a representation of a collection of objects, and can be linked in a hierarchical data structure.</summary>
    [DataContract]
    public class ESDRecordCategory
    {
        /// <summary>Key that allows the category record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyCategoryID { get; set; }

        /// <summary>Code of the category. May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string categoryCode { get; set; }

        /// <summary>Key of the category record that it is assigned to in a hierarchical data structure.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCategoryParentID { get; set; }

        /// <summary>Key of the category tree that the category record may reside within. The category tree defines a collection of categories that can be navigated within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCategoryTreeID { get; set; }

        /// <summary>Name of the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>First description field of the category. It may contain any text used to describe the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description1 { get; set; }

        /// <summary>Second description field of the category. It may contain any text used to describe the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description2 { get; set; }

        /// <summary>Third description field of the category. It may contain any text used to describe the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description3 { get; set; }

        /// <summary>Fourth description field of the category. It may contain any text used to describe the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description4 { get; set; }

        /// <summary>Meta title of the category. This would typically be used in the meta data of a web page.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string metaTitle { get; set; }

        /// <summary>A list of words that describe the category. This would typically be used in the meta data of a web page.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string metaKeywords { get; set; }

        /// <summary>Meta description the category. This would typically be used in the meta data of a web page.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string metaDescription { get; set; }

        /// <summary>Number to order the category by. This may be used to order a number of categories in a hierarchical tree that are all assigned to the same parent category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>List of Key Product IDs, that link any number of Product records to the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyProductIDs { get; set; }

        /// <summary>List of Key Download IDs, that link any number of Download records to the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyDownloadIDs { get; set; }

        /// <summary>List of Key Labour IDs, that link any number of Labour records to the category.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyLabourIDs { get; set; }
    }
}
