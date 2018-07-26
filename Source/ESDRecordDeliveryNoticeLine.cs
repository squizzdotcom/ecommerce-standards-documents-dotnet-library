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
    /// <summary>Ecommerce Standards Record that holds data for a single line in a delivery notice record. The line indicates the quantity of a product that is being delivered, or in the process thereof.</summary>
    [DataContract]
    public class ESDRecordDeliveryNoticeLine
    {
        /// <summary>Unique identifier of the delivery notice line.</summary>
        [DataMember]
        public string keyDeliveryNoticeLineID { get; set; }

        /// <summary>Code of the line in the delivery. May or may not be a unique identifier. Contains a human known identifier of the delivery notice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string deliveryLineCode { get; set; }

        /// <summary>Unique identifier of the customer invoice within the supplier's system that the delivery is associated with.</summary>
		[DataMember(EmitDefaultValue = false)]
        public string keyCustomerInvoiceID { get; set; }

        /// <summary>Unique identifier of the supplier invoice within the customer's system that the delivery is associated with.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySupplierInvoiceID { get; set; }

        /// <summary>Code of the invoice that the delivery is associated with. The code is the human known identifier of the invoice that the delivery line is associated to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string invoiceCode { get; set; }

        /// <summary>Code of the line in the invoice that the product delivery is associated with. THe code is the human known identifier of the invoice line associated to this delivery notice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string invoiceLineCode { get; set; }

        /// <summary>Code of the line in the original purchase order associated to this delivery notice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLineCode { get; set; }

        /// <summary>number of the line in original purchase order associated to this delivery notice line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string purchaseOrderLineNumber { get; set; }

        /// <summary>Key of the sell unit that indicates the kind of unit that the quantity being delivered is</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitID { get; set; }

        /// <summary>Key of the product record associated to the line. Specifies the product that is linked to the line being delivered</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }

        /// <summary>Code the product in the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productCode { get; set; }

        /// <summary>name of the product in the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string productName { get; set; }

        /// <summary>Code of the customer's product that the line is associated to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerProductCode { get; set; }

        /// <summary>Code of the supplire's product that the line is associated to</summary>
        [DataMember(EmitDefaultValue = false)]
        public string supplierProductCode { get; set; }

        /// <summary>quantity of the product's units being delivered</summary>
        [DataMember(EmitDefaultValue = false)]
        public double quantityOnDelivery { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or  it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>s default values for members that have no values </summary>
        public void setDefaultValuesForNullMembers()
        {
            if (keyDeliveryNoticeLineID == null)
            {
                keyDeliveryNoticeLineID = "";
            }

            if (keyCustomerInvoiceID == null)
            {
                keyCustomerInvoiceID = "";
            }

            if (keySupplierInvoiceID == null)
            {
                keySupplierInvoiceID = "";
            }

            if (invoiceCode == null)
            {
                invoiceCode = "";
            }

            if (invoiceLineCode == null)
            {
                invoiceLineCode = "";
            }

            if (deliveryLineCode == null)
            {
                deliveryLineCode = "";
            }

            if (purchaseOrderLineCode == null)
            {
                purchaseOrderLineCode = "";
            }

            if (purchaseOrderLineNumber == null)
            {
                purchaseOrderLineNumber = "";
            }

            if (keySellUnitID == null)
            {
                keySellUnitID = "";
            }

            if (keyProductID == null)
            {
                keyProductID = "";
            }

            if (productCode == null)
            {
                productCode = "";
            }

            if (productName == null)
            {
                productName = "";
            }

            if (customerProductCode == null)
            {
                customerProductCode = "";
            }

            if (internalID == null)
            {
                internalID = "";
            }

            if (supplierProductCode == null)
            {
                supplierProductCode = "";
            }
        }
    }
}