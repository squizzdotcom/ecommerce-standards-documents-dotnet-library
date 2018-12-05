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
    /// <summary>Details of a surcharge assigned to an invoice record within a Ecommerce Standards Document</summary>
    [DataContract]
    public class ESDRecordInvoiceSurcharge
    {
        /// <summary>List of tax records applied to the surcharge.</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordInvoiceLineTax> taxes { get; set; }

        /// <summary>Key of the surcharge record that the invoice line surcharge record is linked to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySurchargeID { get; set; }

        /// <summary>Code of the surcharge. May or may not be a unique identifier</summary>
        [DataMember(EmitDefaultValue = false)]
        public string surchargeCode { get; set; }

        /// <summary>Label of the surcharge</summary>
        [DataMember(EmitDefaultValue = false)]
        public string surchargeLabel { get; set; }

        /// <summary>Text description of the surcharge</summary>
        [DataMember(EmitDefaultValue = false)]
        public string surchargeDescription { get; set; }

        /// <summary>Language that the descriptive text of the line is  in. Set it to a constant prefixed with LANG_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }

        /// <summary>Monetary price of the surcharge, excluding tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceExTax { get; set; }

        /// <summary>Monetary price of the surcharge, including tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceIncTax { get; set; }

        /// <summary>Monetary price of the tax applied to the surcharge</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceTax { get; set; }

        /// <summary>Monetary price of the surcharge before any discounting was applied, exclusive of tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceUndiscountedExTax { get; set; }

        /// <summary>Monetary price of the surcharge before any discounting was applied, inclusive of tax.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceUndiscountedIncTax { get; set; }

        /// <summary>Monetary price of tax applied the surcharge before any discounting was applied.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal priceUndiscountedTax { get; set; }

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
            if (taxes == null)
            {
                taxes = new List<ESDRecordInvoiceLineTax>();
            }
            else
            {
                foreach (ESDRecordInvoiceLineTax tax in taxes)
                {
                    tax.setDefaultValuesForNullMembers();
                }
            } 
            if (keySurchargeID == null)
            {
                keySurchargeID = "";
            }
         
            if (surchargeCode == null)
            {
                surchargeCode = "";
            }
         
            if (surchargeLabel == null)
            {
                surchargeLabel = "";
            }
         
            if (surchargeDescription == null)
            {
                surchargeDescription = "";
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