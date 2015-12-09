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
    /// <summary>Ecommerce Standards Record that holds data associated with a single product image.</summary>
    [DataContract]
    public class ESDRecordProductImage
    {
        /// <summary>Key that allows the product image record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyProductImageID { get; set; }
        /// <summary>Key of the product record that the image is set for.</summary>
        [DataMember]
        public string keyProductID { get; set; }
        /// <summary>Full file path to locate the image, including the image file name and extension. The file path may be a URL, or could be a path to the file in a local machine, or network file store.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string imageFullFilePath { get; set; }
        /// <summary>Name of the image file excluding its extension. The name should match the name in the imageFullFilePath property if set.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string imageFileName { get; set; }
        /// <summary>Extension of the image file. The extension should match the extension in the imageFullFilePath property if set.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string imageFileExtension { get; set; }
        /// <summary>Title to label the image.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string title { get; set; }
        /// <summary>Text to decribe details about the image</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
    }
}