﻿/// <remarks>
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
    /// <summary>Ecommerce Standards Record that holds data for a single line in a sales order.</summary>
    [DataContract]
    public class ESDRecordOrderSaleLine
    {
        /// <summary>list of product delivery records for the order</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordOrderProductDelivery> productDeliveries { get; set; }
        /// <summary>list of attributes associated with the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordOrderLineAttributeProfile> attributes { get; set; }
        /// <summary>list of taxes applied to the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordOrderLineTax> taxes { get; set; }

        /// <summary>Type of line set in the order. Set it to a constant prefixed with ORDER_LINE_TYPE_ in the ESDocumentConstants class</summary>
        [DataMember]
        public string lineType { get; set; }
        /// <summary>Code of the line in the purchase order associated to the sales order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLineCode { get; set; }
        /// <summary>number of the line in the purchase order associated to the sales order.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLineNumber { get; set; }
        /// <summary>Code of the location that order line is assigned to.  This location may override the default location assigned to the order that specifies where the products are picked/packed/delivered/managed from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationCode { get; set; }
        /// <summary>Name of the location that the order line is assigned to. This location may override the default location assigned to the order that specifies where the products are picked/packed/delivered/managed from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationName { get; set; }
        /// <summary>Key of the location record that the order line is assigned to. This location may override the default location assigned to the order that specifies where the products are picked/packed/delivered/managed from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }
        /// <summary>key of the external location where the products for the order can be found. This external location may be the location where goods are being delivered to or held at.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string externalKeyLocationID { get; set; }
        /// <summary>Code of the external location. This external location may be the location where goods are being delivered to or held at.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string externalLocationCode { get; set; }
        /// <summary>Name of the external location. This external location may be the location where goods are being delivered to or held at.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string externalLocationName { get; set; }
        /// <summary>United Nations Standard Products and Service Code. Stores a standard code defined by the United Nations classifying objects.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string UNSPSC { get; set; }
        /// <summary>Language that the descriptive text of the line is set in. Set it to a constant prefixed with LANG_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }
        /// <summary>Quantity of units ordered.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantity { get; set; }
        /// <summary>Monetary price of the line's unit, excluding tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceExTax { get; set; }
        /// <summary>Monetary price of the line's unit, including tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceIncTax { get; set; }
        /// <summary>Monetary price of the tax applied to the line's unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTax { get; set; }
        /// <summary>Monetary price of the line's unit before any discounting was applied, exclusive of tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceUndiscountedExTax { get; set; }
        /// <summary>Monetary price of the line's unit before any discounting was applied, inclusive of tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceUndiscountedIncTax { get; set; }
        /// <summary>Monetary price of tax applied the line's unit before any discounting was applied.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceUndiscountedTax { get; set; }
        /// <summary>Total monetary price of the quantity of unit's ordered, excluding tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalExTax { get; set; }
        /// <summary>Total monetary price of the quantity of unit's ordered, including tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalIncTax { get; set; }
        /// <summary>Total monetary price of the tax applied over the total quantity of unit's ordered.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalTax { get; set; }
        /// <summary>Total monetary price of the quantity of unit's ordered before discounting, excluding tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalUndiscountedExTax { get; set; }
        /// <summary>Total monetary price of the quantity of unit's ordered before discounting, including tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalUndiscountedIncTax { get; set; }
        /// <summary>Total monetary price of the tax applied over the total quantity of unit's ordered before discounting.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalUndiscountedTax { get; set; }
        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the price of the line was explicitly priced at 0.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isPriceFree { get; set; }
        /// <summary>Sets which system or person set the pricing of the line. Set it to a constant prefixed with ENTITY_SET_PRICE_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string entitySetPrice { get; set; }
        /// <summary>Key of the sell unit that the line is assigned to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitID { get; set; }
        /// <summary>Sets the unit quantity of the ordered line that makes up the base quantity. Eg. if the line was bought as a pack, this would indicate that a pack sell unit type consists of "6" individual units.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal sellUnitBaseQuantity { get; set; }
        /// <summary>Name of the unit set for the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string unitName { get; set; }
        /// <summary>Code that the pricing references.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string priceReferenceCode { get; set; }
        /// <summary>Type of entity that the price is referenced to. Typically use one of the PRICE constants in th ESDRecordProductPrice class to set this field, or leave it empty.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string priceReferenceType { get; set; }
        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the line is associated to a product that is the parent of a kit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isKitted { get; set; }
        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the line has been priced based on the component product of a product kit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string kittedProductSetPrice { get; set; }
        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates quantity in the line should be reserved.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isReserved { get; set; }

        //text line fields
        /// <summary>description/comment or any other text to set for a line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string textDescription { get; set; }

        // product fields
        /// <summary>Key of the product record associated to the line. Only relevent when the lineType has been set to product</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Code the product in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productCode { get; set; }
        /// <summary>name of the product in the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productName { get; set; }
        /// <summary>text to describe details of the product in the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productDescription { get; set; }
        /// <summary>code of the product in the purchase order associated to the sales order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderProductCode { get; set; }
        /// <summary>Width measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal width { get; set; }
        /// <summary>Height measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal height { get; set; }
        /// <summary>Depth measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal depth { get; set; }
        /// <summary>Volume measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal volume { get; set; }
        /// <summary>Weight measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal weight { get; set; }
        /// <summary>Code of the product's width measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_LENGTH_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string widthUnitMeasureCode { get; set; }
        /// <summary>Code of the product's height measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_LENGTH_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string heightUnitMeasureCode { get; set; }
        /// <summary>Code of the product's depth measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_LENGTH_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string depthUnitMeasureCode { get; set; }
        /// <summary>Code of the product's volume measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_VOLUME_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string volumeUnitMeasureCode { get; set; }
        /// <summary>Code of the product's weight measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_MASS_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string weightUnitMeasureCode { get; set; }

        // deprecated download fields, use assets data fields instead, since a download is a digital kind of asset
        /// <summary>Key of the download record associated to the line. Only relevent when the lineType has been set to download</summary>
        [Obsolete("keyDownloadID is deprecated, please use keyAssetID instead.")]
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }
        /// <summary>Code the download in the line.</summary>
        [Obsolete("downloadCode is deprecated, please use assetName instead.")]
        [DataMember(EmitDefaultValue = false)]
        public string downloadCode { get; set; }
        /// <summary>name the download in the line.</summary>
        [Obsolete("downloadName is deprecated, please use assetCode instead.")]
        [DataMember(EmitDefaultValue = false)]
        public string downloadName { get; set; }
        /// <summary>description the download in the line.</summary>
        [Obsolete("downloadDescription is deprecated, please use assetDescription instead.")]
        [DataMember(EmitDefaultValue = false)]
        public string downloadDescription { get; set; }
        /// <summary>code of the download in the purchase order associated to the sales order</summary>
        [Obsolete("purchaseOrderDownloadCode is deprecated, please use purchaseOrderAssetCode instead.")]
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderDownloadCode { get; set; }

        // asset fields
        /// <summary>Key of the asset record associated to the line. Only relevent when the lineType has been set to asset</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyAssetID { get; set; }
        /// <summary>Code the asset in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string assetCode { get; set; }
        /// <summary>name the asset in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string assetName { get; set; }
        /// <summary>description the asset in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string assetDescription { get; set; }
        /// <summary>code of the asset in the purchase order associated to the sales order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderAssetCode { get; set; }

        // labour fields
        /// <summary>Key of the labour record associated to the line. Only relevent when the lineType has been set to labour</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }
        /// <summary>Code the labour in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string labourCode { get; set; }
        /// <summary>name the labour in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string labourName { get; set; }
        /// <summary>text to describe details of the labour in the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string labourDescription { get; set; }
        /// <summary>code of the labour in the purchase order associated to the sales order</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLabourCode { get; set; }

        /// <summary>Key of the general ledger account that the line is assigned to. This links the invoice line to the general ledger account that the sale may be reported against for accounting purposes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyGLAccountID { get; set; }

        /// <summary>Code of the general ledger account that the line is assigned to. The code can be used to identify the general ledger account that the sale may be reported against for accounting purposes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string glAccountCode { get; set; }

        /// <summary>Name of the general ledger account that the line is assigned to. The name can be used to identify the general ledger account that the sale may be reported against for accounting purposes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string glAccountName { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>Constructor</summary>
        public ESDRecordOrderSaleLine()
        {
            productDeliveries = new List<ESDRecordOrderProductDelivery>();
            attributes = new List<ESDRecordOrderLineAttributeProfile>();
            taxes = new List<ESDRecordOrderLineTax>();
        }
        
        /// <summary>sets default values for members that have no values set</summary>
        public void setDefaultValuesForNullMembers()
        {
            if (productDeliveries == null)
            {
                productDeliveries = new List<ESDRecordOrderProductDelivery>();
            }
            else
            {
                foreach(ESDRecordOrderProductDelivery productDelivery in productDeliveries)
                {
                    productDelivery.setDefaultValuesForNullMembers();
                }
            }

            if (attributes == null)
            {
                attributes = new List<ESDRecordOrderLineAttributeProfile>();
            }
            else
            {
                foreach (ESDRecordOrderLineAttributeProfile productAttributeProfile in attributes)
                {
                    productAttributeProfile.setDefaultValuesForNullMembers();
                }
            }

            if (taxes == null)
            {
                taxes = new List<ESDRecordOrderLineTax>();
            }
            else
            {
                foreach (ESDRecordOrderLineTax tax in taxes)
                {
                    tax.setDefaultValuesForNullMembers();
                }
            }
            
            if (lineType == null){
                lineType = "";
            }

            if (productCode == null){
                productCode = "";
            }

            if (textDescription == null){
                textDescription = "";
            }

            if (keyProductID == null){
                keyProductID = "";
            }

            if (isKitted == null){
                isKitted = "N";
            }

            if (kittedProductSetPrice == null){
                kittedProductSetPrice = "N";
            }

            if (isReserved == null){
                isReserved = "N";
            }

            if (productCode == null){
                productCode = "";
            }

            if (productName == null){
                productName = "";
            }

            if (productDescription == null){
                productDescription = "";
            }

            if (widthUnitMeasureCode == null){
                widthUnitMeasureCode = "";
            }

            if (heightUnitMeasureCode == null){
                heightUnitMeasureCode = "";
            }

            if (depthUnitMeasureCode == null){
                depthUnitMeasureCode = "";
            }

            if (volumeUnitMeasureCode == null){
                volumeUnitMeasureCode = "";
            }

            if (weightUnitMeasureCode == null){
                weightUnitMeasureCode = "";
            }

            if (downloadCode == null){
                downloadCode = "";
            }

            if (purchaseOrderLineCode == null){
                purchaseOrderLineCode = "";
            }

            if (purchaseOrderLineNumber == null){
                purchaseOrderLineNumber = "";
            }

            if (locationCode == null){
                locationCode = "";
            }

            if (locationName == null){
                locationName = "";
            }

            if (keyLocationID == null){
                keyLocationID = "";
            }

            if (externalKeyLocationID == null){
                externalKeyLocationID = "";
            }

            if (externalLocationCode == null){
                externalLocationCode = "";
            }

            if (externalLocationName == null){
                externalLocationName = "";
            }

            if (UNSPSC == null){
                UNSPSC = "";
            }

            if (language == null){
                language = ESDocumentConstants.LANG_EN_AU;
            }

            if (isPriceFree == null){
                isPriceFree = "N";
            }
            
            if(entitySetPrice == null){
                entitySetPrice = "N";
            }

            if (keySellUnitID == null){
                keySellUnitID = "";
            }

            if (unitName == null){
                unitName = "";
            }

            if (priceReferenceCode == null){
                priceReferenceCode = "";
            }

            if (priceReferenceType == null){
                priceReferenceType = "";
            }

            if (purchaseOrderProductCode == null){
                purchaseOrderProductCode = "";
            }

            if (keyDownloadID == null){
                keyDownloadID = "";
            }

            if (downloadName == null){
                downloadName = "";
            }

            if (downloadDescription == null){
                downloadDescription = "";
            }

            if (purchaseOrderDownloadCode == null){
                purchaseOrderDownloadCode = "";
            }

            if (assetCode == null){
                assetCode = "";
            }

            if (keyAssetID == null){
                keyAssetID = "";
            }

            if (assetName == null){
                assetName = "";
            }

            if (assetDescription == null){
                assetDescription = "";
            }

            if (purchaseOrderAssetCode == null){
                purchaseOrderAssetCode = "";
            }

            if (keyLabourID == null){
                keyLabourID = "";
            }

            if (labourCode == null){
                labourCode = "";
            }

            if (labourName == null){
                labourName = "";
            }

            if (labourDescription == null){
                labourDescription = "";
            }

            if (purchaseOrderLabourCode == null){
                purchaseOrderLabourCode = "";
            }

            if (keyGLAccountID == null){
                keyGLAccountID = "";
            }

            if (glAccountCode == null){
                glAccountCode = "";
            }

            if (glAccountName == null){
                glAccountName = "";
            }

            if (internalID == null){
                internalID = "";
            }
        }
    }
}
