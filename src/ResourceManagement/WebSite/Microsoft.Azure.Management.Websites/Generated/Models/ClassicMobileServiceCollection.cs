// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Collection of Classic Mobile Services
    /// </summary>
    public partial class ClassicMobileServiceCollection
    {
        /// <summary>
        /// Initializes a new instance of the ClassicMobileServiceCollection
        /// class.
        /// </summary>
        public ClassicMobileServiceCollection() { }

        /// <summary>
        /// Initializes a new instance of the ClassicMobileServiceCollection
        /// class.
        /// </summary>
        public ClassicMobileServiceCollection(IList<ClassicMobileService> value = default(IList<ClassicMobileService>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ClassicMobileService> Value { get; set; }

        /// <summary>
        /// Link to next page of resources
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
