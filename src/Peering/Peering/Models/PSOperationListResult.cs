// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The paginated list of [T].
    /// </summary>
    public partial class PSOperationListResult
    {
        /// <summary>
        /// Initializes a new instance of the PSOperationListResult class.
        /// </summary>
        public PSOperationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSOperationListResult class.
        /// </summary>
        /// <param name="value">The list of [T].</param>
        /// <param name="nextLink">The link to fetch the next page of
        /// [T].</param>
        public PSOperationListResult(IList<PSOperation> value = default(IList<PSOperation>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of [T].
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PSOperation> Value { get; set; }

        /// <summary>
        /// Gets or sets the link to fetch the next page of [T].
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
