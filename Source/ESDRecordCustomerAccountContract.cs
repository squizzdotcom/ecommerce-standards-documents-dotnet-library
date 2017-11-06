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
    /// <summary>Ecommerce Standards record that contains the data of a single customer account contract. A contract record may be applied to a number of customer accounts and products for a given amount of time.</summary>
    [DataContract]
    public class ESDRecordCustomerAccountContract
    {
        /// <summary>Key that allows the customer account contract record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyContractID { get; set; }
        /// <summary>Code that allows the contract to be identified with. May or may not be unique.</summary>
        [DataMember]
        public string contractCode { get; set; }
        /// <summary>Text that describes the contract.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that any pricing associated to the contract will be applied to the customer accounts, even if other pricing exists that may be cheaper.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string forceContractPrice { get; set; }
        /// <summary>Text that describes the type of contract</summary>
        [DataMember(EmitDefaultValue = false)]
        public string type { get; set; }
        /// <summary>Date that the contract expires. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long expireDate { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>List of Key Account IDs that link any number of customer accounts to the contract.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyAccountIDs { get; set; }

        /// <summary>List of Key Product IDs that link any number of products to the contract. 
        /// Product pricing is not linked to the contract, this can be done with the use of ESD Product Price Records and the ESDocumentProductPrice document.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] keyProductIDs { get; set; }
    }
}
