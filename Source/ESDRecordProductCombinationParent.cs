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
using Newtonsoft.Json;
using System.ComponentModel;

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standards record for associating a parent product with a product combination profile, and all of its associated product-field-value combinations</summary>
    [DataContract]
    public class ESDRecordProductCombinationParent
    {
        /// <summary>For product combinations specifics the value to set when no child product is the default within the combination</summary>
        public const int DEFAULT_COMBINATION_NOT_SET = -1;

        /// <summary>Constructor</summary>
        public ESDRecordProductCombinationParent()
        {
            //denote that the default product combination has not been set
            defaultCombination = DEFAULT_COMBINATION_NOT_SET;
        }

        /// <summary>Key of the product record that links it to being the parent product of the combination</summary>
        [DataMember]
        public string keyProductID { get; set; }
        /// <summary>Key of the product combination profile that links the profile to the combination</summary>
        [DataMember]
        public string keyComboProfileID { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
        /// <summary>List of product combinations that contains the child products assigned based on a combination of field values be set for each</summary>
        [DataMember]
        public ESDRecordProductCombination[] productCombinations { get; set; }
        /// <summary>Index of the product combinations list that denotes the combination that is the default. The default may be set when initially viewing a combination product</summary>
        [DefaultValue(-1)]
        [DataMember(EmitDefaultValue = false)]        
        public int defaultCombination { get; set; }
    }
}
