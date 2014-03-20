
namespace MemoryModule.FASM
{
    /// <summary>
    /// General errors and conditions
    /// </summary>
    public enum FasmCondition : int
    {
        /// <summary>
        /// FASM_STATE points to output
        /// </summary>
        OK                          = 00,
        WORKING                     = 01,
        /// <summary>
        /// FASM_STATE contains error code
        /// </summary>
        ERROR                       = 02,
        INVALID_PARAMETER           = -1,
        OUT_OF_MEMORY               = -2,
        STACK_OVERFLOW              = -3,
        SOURCE_NOT_FOUND            = -4,
        UNEXPECTED_END_OF_SOURCE    = -5,
        CANNOT_GENERATE_CODE        = -6,
        FORMAT_LIMITATIONS_EXCEDDED = -7,
        WRITE_FAILED                = -8,
    }
}