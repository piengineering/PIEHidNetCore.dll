namespace PIEHidNetCore
{
    /// <summary>
    /// DataHandler Callback Interface
    /// </summary>
    public interface PIEDataHandler
    {
        /// <summary>
        /// Handle Input Data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="sourceDevice"></param>
        /// <param name="error"></param>
        void HandlePIEHidData(byte[] data, PIEDevice sourceDevice, int error);
    }

    /// <summary>
    /// ErrorHandler Callback Interface
    /// </summary>
    public interface PIEErrorHandler
    {
        /// <summary>
        /// Handle Error Data
        /// </summary>
        /// <param name="sourceDevices"></param>
        /// <param name="error"></param>
        void HandlePIEHidError(PIEDevice sourceDevices, int error);
    }

}
