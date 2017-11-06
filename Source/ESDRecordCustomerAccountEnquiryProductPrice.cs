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
    /// <summary>Holds a product's price based on a specific account price that is used for the web</summary>
    [DataContract]
    public class ESDRecordCustomerAccountEnquiryProductPrice
    {
        /// <summary>Key of the product record that links the price to the product</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }

        /// <summary>Code of the product record</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productCode { get; set; }

        /// <summary>Quantity of units that the price applies against</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantity { get; set; }

        /// <summary>Monetary price for each unit excluding tax</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal unitPriceExTax { get; set; }

        /// <summary>Monetary price for each unit including tax</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal unitPriceIncTax { get; set; }

        /// <summary>Monetary price of tax applied to a single unit</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal unitPriceTax { get; set; }

        /// <summary>Montary price for for total quantity of units, excluding tax</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceExTax { get; set; }

        /// <summary>Montary price for for total quantity of units, including tax</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceIncTax { get; set; }

        /// <summary>Montary tax price for for total quantity of units</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceTax { get; set; }

        /// <summary>Tax rate as a percentage that is used to calculate the tax price</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal taxRate { get; set; }

        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored in</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyCode { get; set; }

        /// <summary>Either Y or N. If Y then denotes that the pricing has been discounted.</summary>
        [DataMember]
        public bool isDiscounted { get; set; }

        /// <summary>Type of discount applied to the pricing.</summary>
        [DataMember]
        public string discountType { get; set; }

        /// <summary>Code of the entity that the pricing was discounted with.</summary>
        [DataMember]
        public string discountCode { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
