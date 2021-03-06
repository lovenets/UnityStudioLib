using System;

namespace UnityStudio.Serialization {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class MonoBehaviourPropertyAttribute : Attribute {

        public string Name { get; set; }

        /// <summary>
        /// Used to convert from the type noted in the original file to a desired type.
        /// The assigned converter type must implement <see cref="ISimpleTypeConverter"/> interface.
        /// </summary>
        public Type ConverterType { get; set; }

    }
}
