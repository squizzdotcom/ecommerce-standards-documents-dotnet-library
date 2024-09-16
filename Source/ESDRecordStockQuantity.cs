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
    /// <summary>Ecommerce Standards Record that holds data for a stock unit quantity of a product, download or labour. This record typically stores stock quantity data that can updated on a frequent basis.</summary>
    [DataContract]
    public class ESDRecordStockQuantity
    {
        /// <summary>Key of the product record that the stock level quantity is set for</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Key of the download record that the stock level quantity is set for</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }
        /// <summary>Key of the labour record that the stock level quantity is set for</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }
        /// <summary>Base unit quantity of stock available to be purchased</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyAvailable { get; set; }
        /// <summary>Base unit quantity of stock on hand at its location(s)</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyOnHand { get; set; }
        /// <summary>Base unit quantity of stock that has been ordered by purchaser(s)</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyOrdered { get; set; }
        /// <summary>Base unit quantity of stock that is the maximum amount that can be ordered by purchaser(s)</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyOrderable { get; set; }
        /// <summary>Base unit quantity of stock that has been back ordered from supplier(s)</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyBackordered { get; set; }
        /// <summary>Base unit quantity of stock that has been reserved for given purchasers</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyReserved { get; set; }
        /// <summary>Base unit quantity of stock that has been placed at an external location (consigned)</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyConsigned { get; set; }
        /// <summary>Date time that indicates when the product's stock has been available or in-stock since. If the product currently has no stock available then ignore setting. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long stockAvailableSinceDate { get; set; }
        /// <summary>Date time that indicates when the product's stock has been on hand at its location since. If the product currently has no stock on hand then ignore setting. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long stockOnHandSinceDate { get; set; }
        /// <summary>Date time that indicates when the product's stock has been on order by purchaser(s) since. If the product currently has no stock on order then ignore setting. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long stockOrderedSinceDate { get; set; }
        /// <summary>Date time that indicates when the product's stock has been on back order from supplier(s). If the product currently has no stock on back order then ignore setting. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long stockBackorderedSinceDate { get; set; }
        /// <summary>Date time that indicates when the product's stock has been reserved by purchaser(s). If the product currently has no stock reserved then ignore setting. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long stockReservedSinceDate { get; set; }
        /// <summary>Date time that indicates when the product's stock has been on consignment for. If the product currently has no stock consigned then ignore setting. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long stockConsignedSinceDate { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
