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
    /// <summary>Ecommerce Standards Record that holds data for a single line in a customer's invoice.</summary>
    [DataContract]
    public class ESDRecordCustomerInvoiceLine
    {
        /// <summary>list of attributes associated with the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordInvoiceLineAttributeProfile> attributes { get; set; }

        /// <summary>list of taxes applied to the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordInvoiceLineTax> taxes { get; set; }

        /// <summary>Type of line in the invoice. Set it to a constant prefixed with INVOICE_LINE_TYPE_ in the ESDocumentConstants class</summary>
        [DataMember]
        public string lineType { get; set; }

        /// <summary>Code of the line in the original purchase order associated to the customer's invoice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLineCode { get; set; }

        /// <summary>number of the line in original purchase order associated to the customer's invoice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLineNumber { get; set; }

        /// <summary>Code of the line in the customer's customer invoice associated to the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerInvoiceLineCode { get; set; }

        /// <summary>number of the line in the customer's customer invoice associated to the invoice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerInvoiceLineNumber { get; set; }

        /// <summary>Code of the line in the customer's sales order associated to the invoice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderLineCode { get; set; }

        /// <summary>number of the line in the customer's sales order associated to the invoice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderLineNumber { get; set; }

        /// <summary>Code of the location that invoice line is assigned to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationCode { get; set; }

        /// <summary>Name of the location that the invoice line is assigned to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationName { get; set; }

        /// <summary>Key of the location record that the invoice line is assigned to. Indicates the location that the invoiced goods are being delivered to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }

        /// <summary>key of the external location where the products for the invoice can be found. This external location may be the location where goods are being delivered to or held at.</summary>
        public string externalKeyLocationID { get; set; }

        /// <summary>Code of the external location. This external location may be the location where goods are being delivered to or held at.</summary>
        public string externalLocationCode { get; set; }

        /// <summary>Name of the external location. This external location may be the location where goods are being delivered to or held at.</summary>
        public string externalLocationName { get; set; }

        /// <summary>United Nations Standard Products and Service Code. Stores a standard code defined by the United Nations classifying objects.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string UNSPSC { get; set; }

        /// <summary>Language that the descriptive text of the line is  in. Set it to a constant prefixed with LANG_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the product purchased is stored in inventory and its quantities kept track of.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isInventoried { get; set; }

        /// <summary>Quantity of units invoiced.</summary>
        public decimal quantityInvoiced { get; set; }

        /// <summary>Quantity of units delivered.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantityDelivered { get; set; }

        /// <summary>Quantity of units back ordered.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantityBackordered { get; set; }

        /// <summary>Quantity of units that were ordered.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantityOrdered { get; set; }

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

        /// <summary>Total monetary price of the quantity of unit's invoiced, excluding tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalExTax { get; set; }

        /// <summary>Total monetary price of the quantity of unit's invoiced, including tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalIncTax { get; set; }

        /// <summary>Total monetary price of the tax applied over the total quantity of unit's invoiced.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalTax { get; set; }

        /// <summary>Total monetary price of the quantity of unit's invoiced before discounting, excluding tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalUndiscountedExTax { get; set; }

        /// <summary>Total monetary price of the quantity of unit's invoiced before discounting, including tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalUndiscountedIncTax { get; set; }

        /// <summary>Total monetary price of the tax applied over the total quantity of unit's invoiced before discounting.</summary>
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

        /// <summary>Sets which system or person  the pricing of the line. Set it to a constant prefixed with ENTITY_SET_PRICE_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string entitySetPrice { get; set; }

        /// <summary>Name of the unit  for the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string unitName { get; set; }

        /// <summary>Key of the sell unit that the line is assigned to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitID { get; set; }

        /// <summary>Sets the unit quantity of the invoiced line that makes up the base quantity. Eg. if the line was bought as a pack, this would indicate that a pack sell unit type consists of "6" individual units.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal sellUnitBaseQuantity{ get; set; }

        /// <summary>Code that the pricing references.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string priceReferenceCode { get; set; }

        /// <summary>Type of entity that the price is referenced to. Typically use one of the PRICE constants in th ESDRecordProductPrice class to  this field, or leave it empty.</summary>
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

        // product fields
        /// <summary>Key of the product record associated to the line. Only relevent when the lineType has been  to product</summary>
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

        /// <summary>code of the product in the customer's supplier invoice, that stores the code of the customer's product</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplierInvoiceProductCode { get; set; }

        /// <summary>code of the product in the supplier's sales order, that stores the code of the supplier's product originally ordered</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderProductCode { get; set; }

        /// <summary>code of the product in the customer's purchase order, that stores the code of the customer's product originally ordered</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderProductCode { get; set; }

        /// <summary>Width measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal width{ get; set; }

        /// <summary>Height measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal height{ get; set; }

        /// <summary>Depth measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal depth{ get; set; }

        /// <summary>Volume measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal volume{ get; set; }

        /// <summary>Weight measurement of the product.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal weight{ get; set; }

        /// <summary>Code of the product's width measurement to define the unit of measurement.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string widthUnitMeasureCode { get; set; }

        /// <summary>Code of the product's height measurement to define the unit of measurement.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string heightUnitMeasureCode { get; set; }

        /// <summary>Code of the product's depth measurement to define the unit of measurement.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string depthUnitMeasureCode { get; set; }

        /// <summary>Code of the product's volume measurement to define the unit of measurement.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string volumeUnitMeasureCode { get; set; }

        /// <summary>Code of the product's weight measurement to define the unit of measurement.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string weightUnitMeasureCode { get; set; }

        // download fields
        /// <summary>Key of the download record associated to the line. Only relevent when the lineType has been  to download</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }

        /// <summary>Code the download in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string downloadCode { get; set; }

        /// <summary>name the download in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string downloadName { get; set; }

        /// <summary>description the download in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string downloadDescription { get; set; }

        /// <summary>code of the download in the customer's supplier invoice, that stores the code of the customer's download</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplierInvoiceDownloadCode { get; set; }

        /// <summary>code of the download in the supplier's sales order, that stores the code of the supplier's download originally ordered</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderDownloadCode { get; set; }

        /// <summary>code of the download in the customer's purchase order, that stores the code of the customer's download originally ordered</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderDownloadCode { get; set; }

        // labour fields
        /// <summary>Key of the labour record associated to the line. Only relevent when the lineType has been  to labour</summary>
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

        /// <summary>code of the labour in the customer's supplier invoice, that stores the code of the customer's labour</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplierInvoiceLabourCode { get; set; }

        /// <summary>code of the labour in the supplier's sales order, that stores the code of the supplier's labour originally ordered</summary>
        [DataMember(EmitDefaultValue = false)]
        public string salesOrderLabourCode { get; set; }

        /// <summary>code of the labour in the customer's purchase order, that stores the code of the customer's labour originally ordered</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLabourCode { get; set; }

        /// <summary>text to describe details or comment of a text line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string textDescription { get; set; }

        /// <summary>Code of the customer's product/labour/download that the line is associated to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerItemCode { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>sets default values for members that have no values </summary>
        public void setDefaultValuesForNullMembers() {
            if (attributes == null)
            {
                attributes = new List<ESDRecordInvoiceLineAttributeProfile>();
            }
            else
            {
                foreach(ESDRecordInvoiceLineAttributeProfile lineAttributeProfile in attributes)
                {
                    lineAttributeProfile.setDefaultValuesForNullMembers();
                }
            }
            if (taxes == null)
            {
                taxes = new List<ESDRecordInvoiceLineTax>();
            }
            else
            {
                foreach (ESDRecordInvoiceLineTax lineTax in taxes)
                {
                    lineTax.setDefaultValuesForNullMembers();
                }
            }
            if (lineType == null)
            {
                lineType = "";
            }

            if (locationCode == null)
            {
                locationCode = "";
            }

            if (locationName == null)
            {
                locationName = "";
            }

            if (keyLocationID == null)
            {
                keyLocationID = "";
            }

            if (externalKeyLocationID == null)
            {
                externalKeyLocationID = "";
            }

            if (externalLocationCode == null)
            {
                externalLocationCode = "";
            }

            if (externalLocationName == null)
            {
                externalLocationName = "";
            }

            if (UNSPSC == null)
            {
                UNSPSC = "";
            }

            if (language == null)
            {
                language = "";
            }

            if (salesOrderLineCode == null)
            {
                salesOrderLineCode = "";
            }

            if (salesOrderLineNumber == null)
            {
                salesOrderLineNumber = "";
            }

            if (isPriceFree == null)
            {
                isPriceFree = ESDocumentConstants.ESD_VALUE_NO;
            }

            if (entitySetPrice == null)
            {
                entitySetPrice = ESDocumentConstants.ENTITY_SET_PRICE_SYSTEM;
            }

            if (unitName == null)
            {
                unitName = "";
            }

            if (isInventoried == null)
            {
                isInventoried = ESDocumentConstants.ESD_VALUE_NO;
            }

            if (priceReferenceCode == null)
            {
                priceReferenceCode = "";
            }

            if (priceReferenceType == null)
            {
                priceReferenceType = "";
            }

            if (keySellUnitID == null)
            {
                keySellUnitID = "";
            }

            if (productCode == null)
            {
                productCode = "";
            }

            if (productName == null)
            {
                productName = "";
            }

            if (keyProductID == null)
            {
                keyProductID = "";
            }

            if (productDescription == null)
            {
                productDescription = "";
            }

            if (widthUnitMeasureCode == null)
            {
                widthUnitMeasureCode = "";
            }

            if (heightUnitMeasureCode == null)
            {
                heightUnitMeasureCode = "";
            }

            if (depthUnitMeasureCode == null)
            {
                depthUnitMeasureCode = "";
            }

            if (volumeUnitMeasureCode == null)
            {
                volumeUnitMeasureCode = "";
            }

            if (weightUnitMeasureCode == null)
            {
                weightUnitMeasureCode = "";
            }

            if (downloadCode == null)
            {
                downloadCode = "";
            }

            if (keyDownloadID == null)
            {
                keyDownloadID = "";
            }

            if (downloadName == null)
            {
                downloadName = "";
            }

            if (downloadDescription == null)
            {
                downloadDescription = "";
            }

            if (labourCode == null)
            {
                labourCode = "";
            }

            if (keyLabourID == null)
            {
                keyLabourID = "";
            }

            if (labourName == null)
            {
                labourName = "";
            }

            if (labourDescription == null)
            {
                labourDescription = "";
            }

            if (isKitted == null)
            {
                isKitted = ESDocumentConstants.ESD_VALUE_NO;
            }

            if (kittedProductSetPrice == null)
            {
                kittedProductSetPrice = ESDocumentConstants.ESD_VALUE_NO;
            }

            if (isReserved == null)
            {
                isReserved = ESDocumentConstants.ESD_VALUE_NO;
            }

            if (textDescription == null)
            {
                textDescription = "";
            }

            if (internalID == null)
            {
                internalID = "";
            }

            if (customerItemCode == null)
            {
                customerItemCode = "";
            }
        }
    }
}