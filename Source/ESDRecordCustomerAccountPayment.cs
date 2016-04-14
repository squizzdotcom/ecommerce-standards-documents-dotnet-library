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
using System.Data;

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standard Document that holds details of a payment made by a customer account for a given record type</summary>
    [DataContract]
    public class ESDRecordCustomerAccountPayment
    {
        /// <summary>list of records that the payment applies to</summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ESDRecordCustomerAccountPaymentRecord> records { get; set; }

        /// <summary>Key that allows the customer account payment record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyCustomerAccountPaymentID { get; set; }
        /// <summary>ID that allows the payment to be identified with. May or may not be unique.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentID { get; set; }
        /// <summary>Code that allows the payment to be identified with. May or may not be unique.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentCode { get; set; }
        /// <summary>Number set for reference purposes to the payment.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceNumber { get; set; }
        /// <summary>Key of the customer account record assigned to the payment.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyCustomerAccountID { get; set; }
        /// <summary>Code of the customer account assigned to the invoice.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string customerAccountCode { get; set; }
        /// <summary>ID of the user in the associated Ecommerce system where the payment was made from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string eCommerceUserID { get; set; }
        /// <summary>ID of the associated Ecommerce system where the payment was made from.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string eCommerceSystemID { get; set; }
        /// <summary>Method on how the order is being paid for. The field must be set to one of the class's constants prefixed by PAYMENT_METHOD_</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentMethod { get; set; }
        /// <summary>Name of the user in the associated Ecommerce system where the payment was created. Ideally this is set to a label of the user, and not the credentials used for a user to login (since that could be a security issue passing around such information).</summary>
        [DataMember]
        public string eCommerceUserName { get; set; }
        /// <summary>Monetary amount of the payment</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal paymentAmount { get; set; }
        /// <summary>text that contains a receipt number associated with the payment</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentReceipt { get; set; }
        /// <summary>Key of the payment type record that is associated to the payment. The payment type record indicates how the payment was made.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyPaymentTypeID { get; set; }
        /// <summary>Date of the payment record. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long paymentDate { get; set; }
        /// <summary>Date that the payment record was created. Date is in the form of a number in milliseconds since the 01-01-1970 12:00am Epoch in UTC time-zone</summary>
        [DataMember(EmitDefaultValue = false)]
        public long creationDate { get; set; }
        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored in the invoice with</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyCode { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>Record Type - Invoice</summary>
        public static readonly string RECORD_TYPE_INVOICE = "INVOICE";
        /// <summary>Record Type - Sales Order</summary>
        public static readonly string RECORD_TYPE_ORDER_SALE = "ORDER_SALE";
        /// <summary>Record Type - Purchase Order</summary>
        public static readonly string RECORD_TYPE_ORDER_PURCHASE = "ORDER_PURCHASE";
        /// <summary>Record Type - Back Order</summary>
        public static readonly string RECORD_TYPE_BACKORDER = "BACKORDER";

        /// <summary>UNPAID - No payment was received as yet</summary>
        public static readonly string PAYMENT_METHOD_UNPAID = "UNPAID";
        /// <summary>CREDIT - Payment was made with a credit card</summary>
        public static readonly string PAYMENT_METHOD_CREDIT = "CREDITCARD";
        /// <summary>DIRECTDEPOSIT - Payment has been made with a direct bank transfer</summary>
        public static readonly string PAYMENT_METHOD_DIRECTDEPOSIT = "DIRECTDEPOSIT";
        /// <summary>PROPRIETARY - A payment was made using a proprietary payment system. PayPal could be one example of this.</summary>
        public static readonly string PAYMENT_METHOD_PROPRIETARY = "PROPRIETARY";
        /// <summary>ACCOUNT - A payment was not applicable</summary>
        public static readonly string PAYMENT_METHOD_NA = "NA";

        /// <summary>Creates a Customer Account Payment Ecommerce Standard Document record</summary>
        public ESDRecordCustomerAccountPayment()
        {
            this.records = new List<ESDRecordCustomerAccountPaymentRecord>();
        }

        /// <summary>sets default values for members that have no values set</summary>
        public void setDefaultValuesForNullMembers()
        {
            if (records == null)
            {
                records = new List<ESDRecordCustomerAccountPaymentRecord>();
            }
            else
            {
                foreach (ESDRecordCustomerAccountPaymentRecord record in records)
                {
                    record.setDefaultValuesForNullMembers();
                }
            }

            if (paymentID == null)
            {
                paymentID = "";
            }

            if (paymentCode == null)
            {
                paymentCode = "";
            }

            if (keyCustomerAccountID == null)
            {
                keyCustomerAccountID = "";
            }

            if (customerAccountCode == null)
            {
                customerAccountCode = "";
            }

            if (eCommerceUserID == null)
            {
                eCommerceUserID = "";
            }

            if (eCommerceSystemID == null)
            {
                eCommerceSystemID = "";
            }

            if (eCommerceUserName == null)
            {
                eCommerceUserName = "";
            }

            if (referenceNumber == null)
            {
                referenceNumber = "";
            }

            if (paymentMethod == null)
            {
                paymentMethod = "";
            }

            if (paymentReceipt == null)
            {
                paymentReceipt = "";
            }

            if (paymentDate==0)
            {
                //set the date to the milliseconds since the epoch
                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                paymentDate = (long)t.TotalMilliseconds;
            }

            if (creationDate == 0)
            {
                //set the date to the milliseconds since the epoch
                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                creationDate = (long)t.TotalMilliseconds;
            }

            if (currencyCode == null)
            {
                currencyCode = "";
            }
        }
    }
}
