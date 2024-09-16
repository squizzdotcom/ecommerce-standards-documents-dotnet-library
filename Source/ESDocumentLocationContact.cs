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
    /// Ecommerce standards document that holds a list of contacts records that are associated to locations. These are the people who are linked or can be found at the location.
    /// </summary>
    /// <example>
    /// An example of the Location Contact Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.5,
    ///     "resultStatus": 1,
    ///     "message":"The location contact data has been successfully obtained.",
    ///     "totalDataRecords": 2,
    ///     "dataTransferMode": "COMPLETE",
    ///     "configs":{"dataFields":"keyContactID,keyLocationID,contactCode,title,name1,name2,name3,email,phone1,phone2,phone3,fax,website,orgName,orgPosition,isPrimary,allowMarketing,marketingCategoryCodes,authCode"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyContactID":"CON1",
    ///             "keyLocationID":"2"
    ///         },
    ///         {
    ///             "keyContactID":"2",
    ///             "keyLocationID":"2",
    ///             "contactCode":"JD123",
    ///             "title":"Mr",
    ///             "name1":"John",
    ///             "name2":"Wilbur",
    ///             "name3":"Smith",
    ///             "email":"personal@test.com",
    ///             "phone1":"+6112341231",
    ///             "phone2":"+6112341232",
    ///             "phone3":"+6112341233",
    ///             "fax":"+6112341234",
    ///             "website":"www.squizz.com/esd/index.html",
    ///             "orgName":"Squizz Pty Ltd",
    ///             "orgPosition":"Service Centre Coordinator",
    ///             "isPrimary":"Y",
    ///             "allowMarketing": "Y",
    ///             "marketingCategoryCodes": ["VIP","LATEST-NEWS-EVENTS","NEW-SALES"],
    ///             "authCode":"c0nt@ct-X@amp^le-password"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentLocationContact : ESDocument
    {
        /// <summary>List of contact records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordContact[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the location contact record data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="contactRecords">list of contact records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the contact record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.
        /// </param>
        public ESDocumentLocationContact(int resultStatus, string message, ESDRecordContact[] contactRecords, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = contactRecords;
            this.configs = configs;
            if (contactRecords != null)
            {
                this.totalDataRecords = contactRecords.Length;
            }
        }
    }
}
