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
    /// <summary>Details of a tax assigned to a invoice line within a Ecommerce Standards Document</summary>
    [DataContract]
    public class ESDRecordInvoiceLineTax
    {
        /// <summary>Key of the taxcode record that the invoice line tax record is linked to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyTaxcodeID { get; set; }

        /// <summary>Taxcode. May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxcode { get; set; }

        /// <summary>Label of the taxcode</summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxcodeLabel { get; set; }

        /// <summary>Numeric amount as a percentage rate that the taxcode applies to. Eg. if  to 10, then a 10% tax will be applied on top of the invoice line price.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal taxRate { get; set; }

        /// <summary>Language that the descriptive text of the line is set in. Set it to a constant prefixed with LANG_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }

        /// <summary>Number of units that the tax applies to</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal quantity { get; set; }

        /// <summary>Monetary amount of tax priced for each unit</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTax { get; set; }

        /// <summary>Monetary amount of tax priced for the total quantity of units</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTotalTax { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>sets default values for members that have no values </summary>
        public void setDefaultValuesForNullMembers()
        {
            if (taxcodeLabel == null)
            {
                taxcodeLabel = "";
            }
         
            if (keyTaxcodeID == null)
            {
                keyTaxcodeID = "";
            }
         
            if (taxcode == null)
            {
                taxcode = "";
            }
         
            if (language == null)
            {
                language = "";
            }
         
            if (internalID == null)
            {
                internalID = "";
            }
        }
    }
}