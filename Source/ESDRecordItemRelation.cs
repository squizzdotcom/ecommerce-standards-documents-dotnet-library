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
    /// <summary>Ecommerce Standards Record that holds data for a single relation between items. Each record links one product, labour, or download record to another product, labour, or download record</summary>
    [DataContract]
    public class ESDRecordItemRelation
    {
        /// <summary>Key of the product record</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Key of the download record</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }
        /// <summary>Key of the labour record</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }
        /// <summary>Key of the product record that is related</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyRelatedProductID { get; set; }
        /// <summary>Key of the download record that is related</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyRelatedDownloadID { get; set; }
        /// <summary>Key of the labour record that is related</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyRelatedLabourID { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
