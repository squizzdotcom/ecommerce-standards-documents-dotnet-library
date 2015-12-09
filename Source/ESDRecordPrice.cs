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
    /// <summary>Ecommerce Standards Record that holds data for a single product price. The price may be assigned to a price-level, a price-group, or a customer account</summary>
    [DataContract]
    public class ESDRecordPrice
    {
        /// <summary>Key of the product record that links the price to the product</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Key of the download record that links the price to the download</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }
        /// <summary>Key of the labour record that links the price to the labour</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }
        /// <summary>Key of the price level record that the price is linked to. This can be set to null if the price is not linked to a price level</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyPriceLevelID { get; set; }
        /// <summary>Key of the customer account record that the price is linked to. This can be set to null if the price is not linked to any customer account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyAccountID { get; set; }
        /// <summary>Key of the price group that the price is linked. This can be set to null if the price is not assigned to any price group.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyPriceGroupID { get; set; }
        /// <summary>Key of the sell unit that the price is linked to. This can be set to null, and if so then the price should be assigned to the the default unit of a product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitID { get; set; }
        /// <summary>The amount of product units that the price is set to. This should always be a positive number.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantity { get; set; }
        /// <summary>The tax rate that applies to the price. This can be set to null, and if so then the tax rate of taxcode assigned to the product should be used instead to calculate the product's price.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal taxRate { get; set; }
        /// <summary>ID of an entity that the price is referenced to. Typically it could be an ID of a contract, or promotion</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceID { get; set; }
        /// <summary>Type of entity that the price is referenced to. Typically use one of the PRICE constants in this class to set this field, or leave it empty.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceType { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the price to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Monetary amount of the price. This price may be exclusive or inclusive of tax, depending on the IsInclusive settings of a product. The currency of the price is based on the system where the price was set.</summary>
        [DataMember]
        public decimal price { get; set; }

        /// <summary>Price has been set in a contract</summary>
        public static readonly string PRICE_CONTRACT = "C";
        /// <summary>Price has been set in a contract, and it the price should override other pricing (Contract Forced Pricing)</summary>
        public static readonly string PRICE_CONTRACT_FORCED = "CF";
        /// <summary>Price has been set in a promotion</summary>
        public static readonly string PRICE_PROMOTION = "P";
    }
}
