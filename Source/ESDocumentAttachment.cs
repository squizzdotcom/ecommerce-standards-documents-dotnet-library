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
using Newtonsoft.Json;

namespace EcommerceStandardsDocuments
{
    /// <summary>
    /// Ecommerce standards document that contains a list of attachment file records associated with products, downloads or labour
    /// </summary>
    /// <example>
    /// An example of the Attachment Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The product attachment data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyProductAttachmentID,keyProductID,fileName,fileExtension,fullFilePath"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyProductAttachmentID":"1",
    ///             "keyProductID":"1234",
    ///             "fileName":"product-image",
    ///             "fileExtension":"jpg",
    ///             "fullFilePath":"C://product/images/product-image.jpg"
    ///         },
    ///         {
    ///             "keyProductAttachmentID":"2",
    ///             "keyProductID":"1234",
    ///             "fileName":"product-image2",
    ///             "fileExtension":"png",
    ///             "fullFilePath":"C://product/images/product-image2.png"
    ///         },
    ///         {
    ///             "keyProductAttachmentID":"33A",
    ///             "keyProductID":"123A",
    ///             "fileName":"12345",
    ///             "fileExtension":"gif",
    ///             "fullFilePath":"D://products2/images/12345.gif"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentAttachment : ESDocument
    {
        /// <summary>List of attachment records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordAttachment[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the attachment data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="attachmentRecords">list of attachment records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the attachment record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentAttachment(int resultStatus, string message, ESDRecordAttachment[] attachmentRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = attachmentRecords;
            this.configs = configs;
            if (attachmentRecords != null)
            {
                this.totalDataRecords = attachmentRecords.Length;
            }
        }
    }
}
