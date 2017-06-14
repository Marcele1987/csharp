// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// EnvFromSource represents the source of a set of ConfigMaps
    /// </summary>
    public partial class V1EnvFromSource
    {
        /// <summary>
        /// Initializes a new instance of the V1EnvFromSource class.
        /// </summary>
        public V1EnvFromSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1EnvFromSource class.
        /// </summary>
        /// <param name="configMapRef">The ConfigMap to select from</param>
        /// <param name="prefix">An optional identifer to prepend to each key
        /// in the ConfigMap. Must be a C_IDENTIFIER.</param>
        /// <param name="secretRef">The Secret to select from</param>
        public V1EnvFromSource(V1ConfigMapEnvSource configMapRef = default(V1ConfigMapEnvSource), string prefix = default(string), V1SecretEnvSource secretRef = default(V1SecretEnvSource))
        {
            ConfigMapRef = configMapRef;
            Prefix = prefix;
            SecretRef = secretRef;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ConfigMap to select from
        /// </summary>
        [JsonProperty(PropertyName = "configMapRef")]
        public V1ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>
        /// Gets or sets an optional identifer to prepend to each key in the
        /// ConfigMap. Must be a C_IDENTIFIER.
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the Secret to select from
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public V1SecretEnvSource SecretRef { get; set; }

    }
}