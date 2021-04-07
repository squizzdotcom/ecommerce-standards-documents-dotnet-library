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
    /// <summary>Ecommerce Standards Record that holds data for a single sell unit. The unit defines how a product, download, or labour is sold individually.</summary>
    public class ESDRecordSellUnit
    {
        /// <summary>Key that allows the sell unit record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keySellUnitID { get; set; }

        /// <summary>Code of the sell unit. May or may not be a unqiue identifier.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string sellUnitCode { get; set; }

        /// <summary>Label of the sell unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string sellUnitLabel { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the selling unit is the base selling unit. The base selling unit may be the unit stored in the system that all other units reference off. Typically only one sell unit would be set as the base.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isBaseUnit { get; set; }

        /// <summary>quantity of the unit that makes up the base unit. If not set then the default would be 1.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal baseQuantity { get; set; }

        /// <summary>quantity of the unit that makes up its parent unit. If not set then the default would be 1.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal parentQuantity { get; set; }

        /// <summary>minimum quantity of the sell unit that can be ordered. If not set then the default would be 1.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal minOrderQuantity { get; set; }

        /// <summary>quantity of the sell unit that can be incrementally ordered. Only sell unit quantities that evenly divide by this number should be orderable. If not set then the default would be 1.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal incrementOrderQuantity { get; set; }

        /// <summary>
        /// Either
        /// <list type="bullet">
        /// <item><term>N</term><description>No</description></item>
        /// <item><term>Y</term><description>Yes</description></item>
        /// </list>
        /// If 'Y' then indicates that the pricing of the sell unit should occur off the base sell unit. This could be set if a sell unit is assigned to a product for a given quantity, and all the pricing of the product is set in the base sell unit, not the assigned sell unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string isPricedOffBaseUnit { get; set; }

        /// <summary>Key of the sell unit linked as a parent. This allows the parentQuantity to be related to another unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keySellUnitParentID { get; set; }

        /// <summary>Weight of a single sell unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal weight { get; set; }

        /// <summary>Width dimension of a single sell unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal width { get; set; }

        /// <summary>Height dimension of a single sell unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal height { get; set; }

        /// <summary>Depth dimension of a single sell unit.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal depth { get; set; }

        /// <summary>Weight of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageWeight { get; set; }

        /// <summary>Width dimension of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageWidth { get; set; }

        /// <summary>Height dimension of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageHeight { get; set; }

        /// <summary>Depth dimension of the package that the sell unit is contained within.</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal packageDepth { get; set; }

        /// <summary>Code of the sell unit's width measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_MASS_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string widthUnitMeasureCode { get; set; }

        /// <summary>Code of the sell unit's height measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_MASS_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string heightUnitMeasureCode { get; set; }

        /// <summary>Code of the sell unit's depth measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_MASS_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string depthUnitMeasureCode { get; set; }

        /// <summary>Code of the sell unit's weight measurement to define the unit of measurement. Set it to a constant prefixed with UNIT_MEASURE_MASS_ in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string weightUnitMeasureCode { get; set; }

        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }

        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
