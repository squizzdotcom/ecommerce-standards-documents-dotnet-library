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
    /// <summary>Ecommerce Standards Record that holds data for a single surcharge. Each surcharge defines a type of monetary amount that may be added or substracted which is factored into the final price of purchasing goods or services.</summary>
    [DataContract]
    public class ESDRecordSurcharge
    {
        /// <summary>Key of the surcharge record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keySurchargeID { get; set; }
        /// <summary>Code of the surcharge.  May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string surchargeCode { get; set; }
        /// <summary>Label of the surcharge</summary>
        [DataMember(EmitDefaultValue = false)]
        public string surchargeLabel { get; set; }
        /// <summary>Text to describe the surcharge</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Type of surcharge that it relates to. Set null, or set it to ine of the SURCHARGE_TYPE constants in the ESDocumentConstants class.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string surchargeType { get; set; }
        /// <summary>Key of the Taxcode record that the surcharge is assigned to. The taxcode may control the amount of tax applied to the surcharge.</summary>
        [DataMember]
        public string keyTaxcodeID { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the surcharge should always be included with sales orders and purchase orders even if it has 0 monetary amount applied to the order
        /// </summary>
        [DataMember]
        public string alwaysShowInOrders { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
