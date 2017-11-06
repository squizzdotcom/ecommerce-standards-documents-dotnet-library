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
    /// <summary>Ecommerce Standards Record that holds data for a single product. A product can be a physical or non-physical item that can be sold in quantities.</summary>
    [DataContract]
    public class ESDRecordProduct
    {
        /// <summary>Key that allows the product record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyProductID { get; set; }
        /// <summary>Code of the product.  May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string productCode { get; set; }
        /// <summary>Key of the Taxcode record that the product is assigned to. The taxcode may control the amount of tax applied to the product.</summary>
        [DataMember]
        public string keyTaxcodeID { get; set; }
        /// <summary>Code that allows the product to searched on. This search code may or may not be unique, and would typically contain key words that allows the product to found.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productSearchCode { get; set; }
        /// <summary>Barcode set for the product. A barcode is typically displayed on a product and requires a reader to decipher an image that turns it into a sequence of characters.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string barcode { get; set; }
        /// <summary>Inner barcode set for the product. Multiple barcodes be assigned to a product, and the inner barcode could denote one of these barcodes, or it could be a portion of a single barcode.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string barcodeInner { get; set; }
        /// <summary>Branding of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string brand { get; set; }
        /// <summary>Name of the product</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>First description of the product. May contain any text used to describe the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description1 { get; set; }
        /// <summary>Second description of the product. May contain any text used to describe the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description2 { get; set; }
        /// <summary>Third description of the product. May contain any text used to describe the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description3 { get; set; }
        /// <summary>Fourth description of the product. May contain any text used to describe the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description4 { get; set; }
        /// <summary>Class of the product. A class may contain any text that can be set for multiple products as a classifier of the type of product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productClass { get; set; }
        /// <summary>United Nations Standard Products and Service Code. Stores a standard code defined by the United Nations classifying objects.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string UNSPSC { get; set; }
        /// <summary>Key of the sell unit record that denotes the default unit that the product is sold in.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitID { get; set; }
        /// <summary>Label of the default unit that the product is sold individually as.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string unit { get; set; }
        /// <summary>Quantity of units that allow the product to bought as a pack. This is deprecated in favour of using sell units.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packQuantity { get; set; }
        /// <summary>Label of the pack that the product may be bought as.  This is deprecated in favour of using sell units.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string packUnit { get; set; }
        /// <summary>Weight of a single product unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal weight { get; set; }
        /// <summary>Width dimension of a single product unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal width { get; set; }
        /// <summary>Height dimension of a single product unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal height { get; set; }
        /// <summary>Depth dimension of a single product unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal depth { get; set; }
        /// <summary>Monetary value that denotes the average cost to purchase a single product unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal averageCost { get; set; }
        /// <summary>Label of the warehouse location that the product is assigned to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string warehouse { get; set; }
        /// <summary>Label of the supplier that the product is purchased from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplier { get; set; }
        /// <summary>Label of the amount of time that it would typically take for the product to be delivered when it is out of stock</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryTimeNoStock { get; set; }
        /// <summary>Label of the amount of time that it would typically take for the product to be delivered when it is in stock</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryTimeInStock { get; set; }
        /// <summary>The amount of product units that are in stock and available for purchase.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal stockQuantity { get; set; }
        /// <summary>The amount of product units that indicate when the product is no longer in stock.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal stockNoneQuantity { get; set; }
        /// <summary>The amount of product units that indicate when the product is low in stock.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal stockLowQuantity { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that any pricing set for the product is inclusive of tax applied to the price, based the rate of taxcode assigned to the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isPriceTaxInclusive { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates product is a kit, and is representative of a number of individual products bundled together.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isKitted { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'N' then indicated that if the product is marked as a kit then when its pricing is calculated, that the price of the product should be calculated by combining the price of all the component products assignd to the kit.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string kitProductsSetPrice { get; set; }
        /// <summary>Number to order the product by. This may be used to order a number of products within a list.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>Stores a list of sell units that denote different quantities the the product can be sold in</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordSellUnit[] sellUnits { get; set; }
    }
}
