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
    /// <summary>Ecommerce Standards Record that holds data associated with a single product, download, or labour image.</summary>
    [DataContract]
    public class ESDRecordImage
    {
        /// <summary>Key that allows the image record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyImageID { get; set; }
        /// <summary>Key of the product record that the image is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Key of the download record that the image is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }
        /// <summary>Key of the labour record that the image is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }
        /// <summary>Key of the category record that the image is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCategoryID { get; set; }
        /// <summary>Key of the category tree record that the image is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCategoryTreeID { get; set; }
        /// <summary>Key of the maker/manufacturer model record that the image is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyMakerModelID { get; set; }
        /// <summary>Key of the maker/manufacturer that creates or assembles models and products that the image is set for.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyMakerID { get; set; }
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
        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the image is the primary image of the entity (such as product, category, model etc...) that the image is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isPrimary { get; set; }
        /// <summary>Number to order the image by. This may be used to order a number of images that appear is a list against the same entity.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}