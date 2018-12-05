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
    /// <summary>Ecommerce Standards record that contains the data of a single address associated to a customer account.</summary>
    [DataContract]
    public class ESDRecordCustomerAccountAddress
    {
        /// <summary>Key that allows the customer account address record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyAddressID { get; set; }

        /// <summary>Key of the customer account record that the address record is linked to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCustomerAccountID { get; set; }

        /// <summary>Description of the customer account address. This may be used as a label to help a person identify with the address.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }

        /// <summary>Name of the organisation that the address is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string orgName { get; set; }

        /// <summary>Name of the person who can be contacted at the address.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string contact { get; set; }

        /// <summary>Phone number of the address. Its preferable to set phone numbers that can be dialled from anywhere internationally.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string phone { get; set; }

        /// <summary>Fax number of the address. Its preferable to set fax numbers that can be dialled from anywhere internationally.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string fax { get; set; }

        /// <summary>First address field. Typically this could be a unit number or street number.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string address1 { get; set; }

        /// <summary>Second address field. Typically this could be the street name.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string address2 { get; set; }

        /// <summary>Third address field. Typically this could be the suburb, city or town.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string address3 { get; set; }

        /// <summary>Name of the region/province/state that the address exists within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string region { get; set; }

        /// <summary>Name of the country that the address exists within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string country { get; set; }

        /// <summary>Postcode or zipcode of the address.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string postcode { get; set; }

        /// <summary>Code that denotes the freight location or freight data associated to the address.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string freightCode { get; set; }

        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the address is the primary address assigned to the customer account. Typically a primary address would be the account's billing address.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isPrimary { get; set; }

        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the address may be used by the customer account to have goods delivered to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isDelivery { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
