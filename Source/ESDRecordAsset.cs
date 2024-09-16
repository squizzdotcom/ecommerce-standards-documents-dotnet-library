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
    /// <summary>Ecommerce Standards Record that holds data for a single asset. An asset can be single instance of a tangible or intangible product/service/resource that is created, owned, traded, and may ultimately be destroyed.</summary>
    [DataContract]
    public class ESDRecordAsset
    {
        /// <summary>Key that allows the asset record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyAssetID { get; set; }
        /// <summary>Code of the asset.  May or may not be a unqiue identifier.</summary>
        [DataMember]
        public string assetCode { get; set; }
        /// <summary>Key of the Taxcode record that the asset is assigned to. The taxcode may control the amount of tax applied to the asset.</summary>
        [DataMember]
        public string keyTaxcodeID { get; set; }
        /// <summary>Key of the Product record that the asset is represented by and linked to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Code that allows the asset to searched on. This search code may or may not be unique, and would typically contain key words that allows the asset to found.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string assetSearchCode { get; set; }
        /// <summary>Barcode set for the asset. A barcode is typically displayed on a asset and requires a reader to decipher an image that turns it into a sequence of characters.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string barcode { get; set; }
        /// <summary>Inner barcode set for the asset. Multiple barcodes be assigned to a asset, and the inner barcode could denote one of these barcodes, or it could be a portion of a single barcode.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string barcodeInner { get; set; }
        /// <summary>name of brand that the asset belongs to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string brand { get; set; }
        /// <summary>Name of the asset. The name provides a label to desribe the overall nature of the asset, making it more easily identifiable to humans</summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        /// <summary>First description of the asset. May contain any text used to describe the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description1 { get; set; }
        /// <summary>Second description of the asset. May contain any text used to describe the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description2 { get; set; }
        /// <summary>Third description of the asset. May contain any text used to describe the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description3 { get; set; }
        /// <summary>Fourth description of the asset. May contain any text used to describe the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description4 { get; set; }
        /// <summary>Meta title of the asset. This would typically be used in the meta data of a web page or user interface that may be hidden from being viewed, but contains a label of the asset that systems could utilise or be displayed in an application's header. The data in this field is typically targeted for online search engines.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string metaTitle { get; set; }
        /// <summary>A list of words that describe the asset. This would typically be used in the meta data of a web page or user interface that may be hidden from being viewed, but contains a space delimited list of keywords used by systems to index and allow for searching on the asset. The data in this field is typically targeted for online search engines.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string metaKeywords { get; set; }
        /// <summary>Meta description the asset. This would typically be used in the meta data of a web page or user interface that may be hidden from being viewed, but contains a paragraph of text describing the details of a asset that may be used to index, or display in search listings. The data in this field is typically targeted for online search engines.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string metaDescription { get; set; }
        /// <summary>primary resource path of the asset's Uniform Resource Locator (URL) that allows the asset to be communicated to or found within a public or private computer network</summary>
        [DataMember(EmitDefaultValue = false)]
        public string assetResourceURL { get; set; }
        /// <summary>Class of the asset. A class may contain any text that can be set for multiple assets as a classifier of the type of asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string assetClass { get; set; }
        /// <summary>United Nations Standard Assets and Service Code. Stores a standard code defined by the United Nations classifying objects.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string UNSPSC { get; set; }
        /// <summary>Key of the sell unit record that denotes the unit that the asset is sold in.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitID { get; set; }
        /// <summary>Label of the unit that the asset is sold as.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string unit { get; set; }
        /// <summary>Weight of a single asset unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal weight { get; set; }
        /// <summary>Width dimension of the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal width { get; set; }
        /// <summary>Height dimension of the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal height { get; set; }
        /// <summary>Depth dimension of the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal depth { get; set; }
        /// <summary>Weight of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageWeight { get; set; }
        /// <summary>Width dimension of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageWidth { get; set; }
        /// <summary>Height dimension of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageHeight { get; set; }
        /// <summary>Depth dimension of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageDepth { get; set; }
        /// <summary>Code of the asset's width measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_LENGTH_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string widthUnitMeasureCode { get; set; }
        /// <summary>Code of the asset's height measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_LENGTH_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string heightUnitMeasureCode { get; set; }
        /// <summary>Code of the asset's depth measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_LENGTH_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string depthUnitMeasureCode { get; set; }
        /// <summary>Code of the asset's weight measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_MASS_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string weightUnitMeasureCode { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that any pricing set for the asset is inclusive of tax applied to the price, based the rate of taxcode assigned to the asset.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isPriceTaxInclusive { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates asset is a kit, and is representative of a number of individual assets bundled together.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isKitted { get; set; }
        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'N' then indicated that if the asset is marked as a kit then when its pricing is calculated, that the price of the asset should be calculated by combining the price of all the component assets assignd to the kit.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string kitAssetsSetPrice { get; set; }
        /// <summary>Number to order the asset by. This may be used to order a number of assets within a list.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int ordering { get; set; }
        /// <summary>Date time that the asset was first created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long createdDate { get; set; }
        /// <summary>Date time that the asset was destroyed. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long destroyedDate { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>Stores a list of sell units that denote different quantities the the asset can be sold in</summary>
        [DataMember(EmitDefaultValue = false)]
        public ESDRecordSellUnit[] sellUnits { get; set; }
    }
}
