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
    /// <summary>Ecommerce Standards Record that holds data for a single attribute profile set for a order line. This allows any additional attribute data to be set for the line.</summary>
    [DataContract]
    public class ESDRecordOrderLineAttributeProfile
    {
        /// <summary>Key of the order attribute profile record</summary>
        [DataMember]
        public string keyAttributeProfileID { get; set; }
        /// <summary>Code of the attribute profile.  May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string profileCode { get; set; }
        /// <summary>Name of the attribute profile.</summary>
        [DataMember]
        public string profileName { get; set; }
        /// <summary>List of attributes and values set for the order attribute profile</summary>
        [DataMember]
        public List<ESDRecordOrderLineAttribute> values { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>sets default values for members that have no values set</summary>
        public void setDefaultValuesForNullMembers()
        {
            if (values == null){
                values = new List<ESDRecordOrderLineAttribute>();
            }else{
                foreach (ESDRecordOrderLineAttribute attributeValue in values){
                    attributeValue.setDefaultValuesForNullMembers();
                }
            }

            if (profileCode == null){
                profileCode = "";
            }

            if (profileName == null){
                profileName = "";
            }

            if (keyAttributeProfileID == null)
            {
                keyAttributeProfileID = "";
            }
        }
    }
}
