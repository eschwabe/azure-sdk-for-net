// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// NumberLessThan Advanced Filter.
    /// </summary>
    [Newtonsoft.Json.JsonObject("NumberLessThan")]
    public partial class NumberLessThanAdvancedFilter : AdvancedFilter
    {
        /// <summary>
        /// Initializes a new instance of the NumberLessThanAdvancedFilter
        /// class.
        /// </summary>
        public NumberLessThanAdvancedFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NumberLessThanAdvancedFilter
        /// class.
        /// </summary>
        /// <param name="key">The field/property in the event based on which
        /// you want to filter.</param>
        /// <param name="value">The filter value.</param>
        public NumberLessThanAdvancedFilter(string key = default(string), double? value = default(double?))
            : base(key)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the filter value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}