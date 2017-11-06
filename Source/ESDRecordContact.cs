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
    /// <summary>Ecommerce Standards record that contains data for a single contact. A contact contains information about a person on how they can be communicated with. The contact record may be linked to a customer account, or supplier account</summary>
    [DataContract]
    public class ESDRecordContact
    {
        /// <summary>Key that allows the contact record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyContactID { get; set; }

        /// <summary>Key of the customer account record that the contact record is linked to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCustomerAccountID { get; set; }

        /// <summary>Key of the supplier account record that the contact record is linked to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySupplierAccountID { get; set; }

        /// <summary>Code of the contact. May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string contactCode { get; set; }

        /// <summary>Title of the contact person. Eg. Mrs, Mr, Miss, Doctor</summary>
        [DataMember(EmitDefaultValue = false)]
        public string title { get; set; }

        /// <summary>First name field of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name1 { get; set; }

        /// <summary>Second name field of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name2 { get; set; }

        /// <summary>Third name field of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name3 { get; set; }

        /// <summary>Email address of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>First phone number of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string phone1 { get; set; }

        /// <summary>Second phone number of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string phone2 { get; set; }

        /// <summary>Third phone number of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string phone3 { get; set; }

        /// <summary>fax number of the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string fax { get; set; }

        /// <summary>URL of the website that the contact is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string website { get; set; }

        /// <summary>Name of the organisation associated to the contact.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string orgName { get; set; }

        /// <summary>Name of the employment position of the contact within the organisation.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string orgPosition { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
