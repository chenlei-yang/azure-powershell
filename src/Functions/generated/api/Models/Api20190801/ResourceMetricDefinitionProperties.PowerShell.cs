namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>ResourceMetricDefinition resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceMetricDefinitionPropertiesTypeConverter))]
    public partial class ResourceMetricDefinitionProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricDefinitionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ResourceMetricDefinitionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricDefinitionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ResourceMetricDefinitionProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ResourceMetricDefinitionProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricDefinitionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ResourceMetricDefinitionProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).MetricAvailability = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricAvailability[]) content.GetValueForProperty("MetricAvailability",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).MetricAvailability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricAvailability>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricAvailabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).PrimaryAggregationType = (string) content.GetValueForProperty("PrimaryAggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).PrimaryAggregationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionProperties1) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricDefinitionProperties1TypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).ResourceUri = (string) content.GetValueForProperty("ResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).ResourceUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Unit, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricDefinitionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ResourceMetricDefinitionProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).MetricAvailability = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricAvailability[]) content.GetValueForProperty("MetricAvailability",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).MetricAvailability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricAvailability>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricAvailabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).PrimaryAggregationType = (string) content.GetValueForProperty("PrimaryAggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).PrimaryAggregationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionProperties1) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ResourceMetricDefinitionProperties1TypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).ResourceUri = (string) content.GetValueForProperty("ResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).ResourceUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceMetricDefinitionPropertiesInternal)this).Unit, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ResourceMetricDefinition resource specific properties
    [System.ComponentModel.TypeConverter(typeof(ResourceMetricDefinitionPropertiesTypeConverter))]
    public partial interface IResourceMetricDefinitionProperties

    {

    }
}