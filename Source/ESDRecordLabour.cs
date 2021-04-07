/// <remarks>
/// Copyright (C) Squizz PTY LTD
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
    /// <summary>Ecommerce Standards Record that holds data for a single labour record. Labour describes the different kinds of effort required to perform a piece of work.</summary>
    [DataContract]
    public class ESDRecordLabour
    {
        /// <summary>Key that allows the labour record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyLabourID { get; set; }
        /// <summary>Code of the labour.  May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string labourCode { get; set; }
        /// <summary>Key of the Taxcode record that the labour is assigned to. The taxcode may control the amount of tax applied to the labour.</summary>
        [DataMember]
        public string keyTaxcodeID { get; set; }
        /// <summary>Code that allows the labour to searched on. This search code may or may not be unique, and would typically contain key words that allows the labour to found.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string labourSearchCode { get; set; }
        /// <summary>Name of the labour</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>First description of the labour. May contain any text used to describe the labour.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description1 { get; set; }
        /// <summary>Second description of the labour. May contain any text used to describe the labour.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description2 { get; set; }
        /// <summary>Third description of the labour. May contain any text used to describe the labour.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description3 { get; set; }
        /// <summary>Fourth description of the labour. May contain any text used to describe the labour.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description4 { get; set; }
        /// <summary>Class of the labour. A class may contain any text that can be set for multiple labour records as a classifier of the type of labour.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string labourClass { get; set; }
        /// <summary>United Nations Standard Products and Service Code. Stores a standard code defined by the United Nations classifying objects.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string UNSPSC { get; set; }
        /// <summary>Key of the sell unit record that denotes the default unit that the labour is sold in.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitID { get; set; }
        /// <summary>Label of the default unit that the labour is sold individually as.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string unit { get; set; }
        /// <summary>Monetary value that denotes the average cost to purchase a single labour unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal averageCost { get; set; }
        /// <summary>The amount of labour units that are available for purchase.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal labourQuantity { get; set; }
        /// <summary>The amount of labour units that indicate when the labour is no longer available.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal labourNoneQuantity { get; set; }
        /// <summary>The amount of labour units that indicate when the labour is low in availability.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal labourLowQuantity { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that any pricing set for the labour is inclusive of tax applied to the price, based the rate of taxcode assigned to the labour.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isPriceTaxInclusive { get; set; }
        /// <summary>Number to order the labour by. This may be used to order a number of labour items within a list.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>Stores a list of sell units that different units of labour can be sold in. Eg labour could be sold by the hour, or in packs</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordSellUnit[] sellUnits { get; set; }
    }
}
