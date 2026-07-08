namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Defines the format for converting a property's value to a string.
    /// </summary>
    public enum ParameterFormat
    {
        /// <summary>
        /// Default conversion (usually .ToString()).
        /// </summary>
        Default,
        /// <summary>
        /// Converts a boolean to "1" or "0".
        /// </summary>
        IntegerFromBool,
        // Add other formats as needed in the future
    }
}
