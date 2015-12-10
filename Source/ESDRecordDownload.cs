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
    /// <summary>Ecommerce Standards Record that holds data for a single download. A download represents a piece of digital information, that may be stored, sold, or transferred.</summary>
    [DataContract]
    public class ESDRecordDownload
    {
        /// <summary>Key that allows the download record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyDownloadID { get; set; }
        /// <summary>Code of the download.  May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string downloadCode { get; set; }
        /// <summary>Key of the Taxcode record that the download is assigned to. The taxcode may control the amount of tax applied to the download.</summary>
        [DataMember]
        public string keyTaxcodeID { get; set; }
        /// <summary>Code that allows the download to searched on. This search code may or may not be unique, and would typically contain key words that allows the download to be found.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string downloadSearchCode { get; set; }
        /// <summary>Branding of the download.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string brand { get; set; }
        /// <summary>Name of the download</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>location where the data can be downloaded from</summary>
        [DataMember(EmitDefaultValue = false)]
        public string downloadLocation { get; set; }
        /// <summary>key that allows the file to be accessed and downloaded</summary>
        [DataMember(EmitDefaultValue = false)]
        public string downloadKey { get; set; }
        /// <summary>First description of the download. May contain any text used to describe the download.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description1 { get; set; }
        /// <summary>Second description of the download. May contain any text used to describe the download.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description2 { get; set; }
        /// <summary>Third description of the download. May contain any text used to describe the download.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description3 { get; set; }
        /// <summary>Fourth description of the download. May contain any text used to describe the download.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description4 { get; set; }
        /// <summary>Class of the download. A class may contain any text that can be set for multiple downloads as a classifier of the type of download.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string downloadClass { get; set; }
        /// <summary>United Nations Standard Products and Service Code. Stores a standard code defined by the United Nations classifying objects.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string UNSPSC { get; set; }
        /// <summary>Size of the download, in bytes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public long downloadSize { get; set; }
        /// <summary>Monetary value that denotes the average cost to purchase a single download unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal averageCost { get; set; }        
        /// <summary>Label of the supplier that the download is purchased from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplier { get; set; }
        /// <summary>The amount of download units that are available for purchase.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal downloadQuantity { get; set; }
        /// <summary>The amount of download units that indicate when the download is no longer available.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal downloadNoneQuantity { get; set; }
        /// <summary>The amount of download units that indicate when the download is no longer available.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal downloadLowQuantity { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that any pricing set for the download is inclusive of tax applied to the price, based the rate of taxcode assigned to the download.</summary>
        /// [DataMember(EmitDefaultValue = false)]
        public string isPriceTaxInclusive { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates download is a kit, and is representative of a number of individual downloads bundled together.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isKitted { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that if the download is marked as a kit then when its pricing is calculated, that the pricing assigned to the download is for the cost of kit.
        /// If 'N' then indicated that if the download is marked as a kit then when its pricing is calculated, that the price of the download should be calculated by combining the price of all the component downloads assigned to the kit.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string kitSetPrice { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
    }
}
