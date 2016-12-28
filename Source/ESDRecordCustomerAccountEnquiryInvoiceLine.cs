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
    /// <summary>Ecommerce Standard Record holding data for a customer account invoice line</summary>
    [DataContract]
    public class ESDRecordCustomerAccountEnquiryInvoiceLine
    {
        /// <summary>Key that allows the customer account invoice line record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyInvoiceLineID { get; set; }
        /// <summary>ID that allows the line to be identified with. May or may not be unique.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string lineItemID { get; set; }
        /// <summary>Code that allows the line to be identified with. May or may not be unique.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string lineItemCode { get; set; }
        /// <summary>Defines the type of data that the line represents. Set it to one of the constants prefixed with RECORD_LINE_TYPE_ in the ESDocumentCustomerAccountEnquiry class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string lineType { get; set; }
        /// <summary>text to describe any details of the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>United Nations Standard Products and Service Code. Stores a standard code defined by the United Nations classifying objects.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string UNSPSC { get; set; }
        /// <summary>Language that all text is described in. Set it to one of the LANG constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }
        /// <summary>label of the unit that any quantities set to the line represent.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string unit { get; set; }
        /// <summary>Quantity ordered for the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantityOrdered { get; set; }
        /// <summary>Quantity delivered for the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantityDelivered { get; set; }
        /// <summary>Quantity back ordered for the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantityBackordered { get; set; }
        /// <summary>monetary price for a single unit excluding tax amount.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceExTax { get; set; }
        /// <summary>monetary price for a single unit including tax amount.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceIncTax { get; set; }
        /// <summary>monetary price for the amount of tax applied to a single unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTax { get; set; }
        /// <summary>monetary price for the total quantity of units excluding tax amount.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceExTax { get; set; }
        /// <summary>monetary price for the total quantity of units including tax amount.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceIncTax { get; set; }
        /// <summary>monetary price for the amount of tax applied to the total quantity of units.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal totalPriceTax { get; set; }
        /// <summary>tax code set for the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxCode { get; set; }
        /// <summary>pecentage amount associated with the taxcode that has been used to calculate the line tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal taxCodeRatePercent { get; set; }
        /// <summary>Key of the location record associated to the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLocationID { get; set; }
        /// <summary>Code of the location associated to the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string locationCode { get; set; }
        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored as in the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyCode { get; set; }
        /// <summary>Item code of a line that it may reference from another record</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceLineItemCode { get; set; }
        /// <summary>Code of the line that it may reference from another record</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceLineCode { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
