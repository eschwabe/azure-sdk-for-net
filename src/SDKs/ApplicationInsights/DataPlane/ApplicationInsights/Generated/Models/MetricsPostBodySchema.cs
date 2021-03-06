// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Query.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A metric request
    /// </summary>
    public partial class MetricsPostBodySchema
    {
        /// <summary>
        /// Initializes a new instance of the MetricsPostBodySchema class.
        /// </summary>
        public MetricsPostBodySchema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricsPostBodySchema class.
        /// </summary>
        /// <param name="id">An identifier for this query.  Must be unique
        /// within the post body of the request.  This identifier will be the
        /// 'id' property of the response object representing this
        /// query.</param>
        /// <param name="parameters">The parameters for a single metrics
        /// query</param>
        public MetricsPostBodySchema(string id, MetricsPostBodySchemaParameters parameters)
        {
            Id = id;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an identifier for this query.  Must be unique within
        /// the post body of the request.  This identifier will be the 'id'
        /// property of the response object representing this query.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the parameters for a single metrics query
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public MetricsPostBodySchemaParameters Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parameters");
            }
            if (Parameters != null)
            {
                Parameters.Validate();
            }
        }
    }
}
