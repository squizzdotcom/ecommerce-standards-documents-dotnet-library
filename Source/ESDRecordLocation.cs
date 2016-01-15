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
    /// <summary>Ecommerce Standards Record that holds data for a single location. Location could be a physical geographical location or a virtual place.</summary>
    [DataContract]
    public class ESDRecordLocation
    {
        /// <summary>Key that allows the location record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyLocationID { get; set; }
        /// <summary>Code of the location. May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string locationCode { get; set; }
        /// <summary>Name of the location.</summary>
        [DataMember]
        public string locationName { get; set; }
        /// <summary>First address field. Typically this could be a unit number or street number.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string address1 { get; set; }
        /// <summary>Second address field. Typically this could be the street name.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string address2 { get; set; }
        /// <summary>Third address field. Typically this could be the suburb, city or town.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string address3 { get; set; }
        /// <summary>Name of the region/province/state where the location exists</summary>
        [DataMember(EmitDefaultValue = false)]
        public string region { get; set; }
        /// <summary>Name of the country where the location exists.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string country { get; set; }
        /// <summary>Postcode or zip code of the location's address.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string postcode { get; set; }
        /// <summary>Name of the contact at the location</summary>
        [DataMember(EmitDefaultValue = false)]
        public string contact { get; set; }
        /// <summary>Phone number of the location</summary>
        [DataMember(EmitDefaultValue = false)]
        public string phone { get; set; }
        /// <summary>Fax number of the location</summary>
        [DataMember(EmitDefaultValue = false)]
        public string fax { get; set; }
        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the location is being used actively.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isActive { get; set; }
        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the location physically exists at a geographic location in the world.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isGeographic { get; set; }
        /// <summary>Latitude co-ordinate of the geographic location. The number must be between 90 and -90</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal latitude { get; set; }
        /// <summary>longitude co-ordinate of the geographic location. The number must be between 180 and -180</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal longitude { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>list of products stock level records that denote the products assigned to the location, and the quantity of product stock available for each</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordStockQuantity[] productStock { get; set; }
    }
}
