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
    /// <summary>Ecommerce Standards Record that holds data for a single General Ledger Account. The account is used to record the monetary transactions against an aspect of a business, person or other entity, recorded against the General Ledger.</summary>
    [DataContract]
    public class ESDRecordGeneralLedgerAccount
    {
        /// <summary>Key of the general ledger account record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyGLAccountID { get; set; }
        /// <summary>Code of the general ledger account. May or may not be a unique identifier and is typically human known to identify the account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string glAccountCode { get; set; }
        /// <summary>Name of the general ledger account. The name typically describes the kinds of transactions that the general ledger account records.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>Description of the general ledger account. The description may contain more detail on what the account is used for, or why it exists.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Class or classifier of the account. The class may be used to identify the kind of account that it is, or be used to group accounts together.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string accountClass { get; set; }
        /// <summary>Current monetary balance of the account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal balance { get; set; }
        /// <summary>Key of the Taxcode record that the account is assigned to. The taxcode may control the amount of tax that is applied when the account is used with monetary transactions.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyTaxcodeID { get; set; }
        /// <summary>Key of a general ledger account that is the parent of the account and is linked to. This is used to create a hierarchy of accounts that may be used for reporting purposes.</summary>
        [DataMember]
        public string keyParentGLAccountID { get; set; }
        /// <summary>Specifies the kind of monetary transactions that are recorded against the general ledger account. If set, must use the ESDocumentConstants that are prefixed with "GENERAL_LEDGER_ACCOUNT_TYPE".</summary>
        [DataMember(EmitDefaultValue = false)]
        public string accountType { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
