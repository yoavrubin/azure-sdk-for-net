// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Azure Storage account information.
    /// </summary>
    public partial class StorageAccountInfo
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountInfo class.
        /// </summary>
        public StorageAccountInfo() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccountInfo class.
        /// </summary>
        /// <param name="name">the account name associated with the Azure storage account.</param>
        /// <param name="properties">the properties associated with this storage account.</param>
        public StorageAccountInfo(string name, StorageAccountProperties properties)
        {
            Name = name;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the account name associated with the Azure storage
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the properties associated with this storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public StorageAccountProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
