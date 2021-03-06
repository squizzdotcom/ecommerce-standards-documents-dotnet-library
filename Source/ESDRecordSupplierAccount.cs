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
    /// <summary>Ecommerce Standards record that contains data for a single supplier account. A supplier account represents an entity (such as a person or organisation) that supplies goods/services/items from another external entity. The supplier account may also known as a "creditor".</summary>
    [DataContract]
    public class ESDRecordSupplierAccount
    {
        /// <summary>Key that allows the supplier account record to be uniquely identified and linked to. In other records it may be referred to keyAccountID where appropriate.</summary>
        [DataMember]
        public string keySupplierAccountID { get; set; }

        /// <summary>Key of the Price Level record that the supplier account is assigned to. The price level record may reflect the price-level pricing associated to the account.</summary>
        [DataMember]
        public string keyPriceLevelID { get; set; }

        /// <summary>Code that allows the account to be identified with. May or may not be unique.</summary>
        [DataMember]
        public string supplierAccountCode { get; set; }

        /// <summary>Name of the account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string accountName { get; set; }

        /// <summary>Name of person associated to the account that can be contacted.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string contactName { get; set; }

        /// <summary>Name of the organisation associated to the account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string orgName { get; set; }

        /// <summary> list of numbers of the government, or any other entity records that is associated with the entity. Ensure that the array length is the same as the authorityNumberLabels property, or left empty</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] authorityNumbers { get; set; }

        /// <summary> list of Labels set for the authority numbers. Ensure that the array length is the same as the authorityNumbers property, or left empty</summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] authorityNumberLabels { get; set; }

        /// <summary>list of authority number types matching the authority numbers. If set must use the ESDocumentConstants that are prefixed with "AUTHORITY_NUM_". Ensure that the array length is the same as the authorityNumbers property, or left empty.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int[] authorityNumberTypes { get; set; }

        /// <summary>Primary phone number to contact the supplier account's organisation or individual person. Its preferable to set phone numbers that can be dialled from anywhere internationally.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string phone { get; set; }

        /// <summary>Email address that may be used to contact the entity associated with the supplier account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>Field that classifies the supplier account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string accountClass { get; set; }

        /// <summary>A comma delimited list of payment types that may be used to pay for the supplier account's debts.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string paymentTypes { get; set; }

        /// <summary>Key of the Purchaser record that links a purchaser to the supplier account. The assigned purchaser typically is in charge of the account.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyPurchaserID { get; set; }

        /// <summary>Name of the area that is supplier account is associated to.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string territory { get; set; }

        /// <summary>Method that goods ordered by the supplier account may be delivered by.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string shippingMethod { get; set; }

        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the supplier account is On Hold and may not be allowed to make any more purchases with it until its outstanding debts have been paid, or any other conditions.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isOnHold { get; set; }

        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes
        /// If 'Y' then indicates that the supplier account's debt balance is outside of its allowed credit limits.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isOutsideBalance { get; set; }

        /// <summary>Either 'N'-No or 
        /// 'Y'-Yes 
        /// If 'Y' then indicates that the supplier account is operating outside of the payment terms of its debts, or other predefined terms.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isOutsideTerms { get; set; }

        /// <summary>Monetary balance of supplier account. If the balance is negative then supplier account owes money and is in debt, if the balance is positive then the supplier account is owed money and is in credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal balance { get; set; }

        /// <summary>Maximum monetary amount that the supplier account is allowed to purchase debts to. A positive amount denotes that the account's balance may be in placed in debt. A negative amount denots that the account's balance must stay within positive credit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal limit { get; set; }

        /// <summary>Either 'GND'-Given Number of Days
        /// 'DOM'-Date OF the Month
        /// 'NDAE'-Number of Days After the End of the month
        /// 'DMAE'-Date of the Month After the End of the month
        /// 'COD'-Cash On Delivery
        /// 'NA'-Not Applicable
        /// Defines the type of terms required by the supplier account to pay off its debts, and the length that the terms apply for. Use the ACCOUNT PAYMENT constants of the record to set this value.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string termsType { get; set; }

        /// <summary>Readable description of the type of terms required by the supplier accounts to pay off its debts</summary>
        [DataMember(EmitDefaultValue = false)]
        public string termsDescription { get; set; }

        /// <summary>First value that may be used to calculate the payment terms of the account</summary>
        [DataMember(EmitDefaultValue = false)]
        public string termsValue1 { get; set; }

        /// <summary>Second value that may be used to calculate the payment terms of the account</summary>
        [DataMember(EmitDefaultValue = false)]
        public string termsValue2 { get; set; }

        /// <summary>Key of the general ledger account that the supplier account is assigned to. This links the supplier account to a general ledger account that expenditures against it may be reported for accounting purposes.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyGLAccountID { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }

        /// <summary>Payment Terms - Given Number of Days</summary>
        public static readonly string ACCOUNT_PAYMENT_TERMS_GIVEN_NO_DAYS = "GND";
        /// <summary>Payment Terms - Day Of the Month</summary>
        public static readonly string ACCOUNT_PAYMENT_TERMS_DAY_OF_MONTH = "DOM";
        /// <summary>Payment Terms - Number of Days After the End of the month</summary>
        public static readonly string ACCOUNT_PAYMENT_TERMS_NO_DAYS_AFTER_END_OF_MONTH = "NDAE";
        /// <summary>Payment Terms - Date of the Month After the End of the month</summary>
        public static readonly string ACCOUNT_PAYMENT_TERMS_DAY_OF_MONTH_AFTER_DAY_OF_MONTH = "DMAE";
        /// <summary>Payment Terms - Cash On Delivery</summary>
        public static readonly string ACCOUNT_PAYMENT_TERMS_CASH_ON_DELIVERY = "COD";
        /// <summary>Payment Terms - Not Applicable</summary>
        public static readonly string ACCOUNT_PAYMENT_TERMS_NA = "MA";
    }
}
