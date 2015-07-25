// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// HCatalog properties.
    /// </summary>
    public partial class HCatalogProperties
    {
        private bool _alterSchema;
        
        /// <summary>
        /// Optional. Flag to indicate if alter schema should be performed.
        /// </summary>
        public bool AlterSchema
        {
            get { return this._alterSchema; }
            set { this._alterSchema = value; }
        }
        
        private string _linkedServiceName;
        
        /// <summary>
        /// Optional. The name of Azure SQL linked service.
        /// </summary>
        public string LinkedServiceName
        {
            get { return this._linkedServiceName; }
            set { this._linkedServiceName = value; }
        }
        
        private bool _recoverPartitions;
        
        /// <summary>
        /// Optional. Flag to indicate to recover partitions.
        /// </summary>
        public bool RecoverPartitions
        {
            get { return this._recoverPartitions; }
            set { this._recoverPartitions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HCatalogProperties class.
        /// </summary>
        public HCatalogProperties()
        {
        }
    }
}