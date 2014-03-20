
namespace MemoryModule.FASM
{
    /// <summary>
    /// Error codes for FASM_ERROR condition
    /// </summary>
    internal enum FasmError : int
    {
        FILE_NOT_FOUND                      = -101,
        ERROR_READING_FILE                  = -102,
        INVALID_FILE_FORMAT                 = -103,
        INVALID_MACRO_ARGUMENTS             = -104,
        INCOMPLETE_MACRO                    = -105,
        UNEXPECTED_CHARACTERS               = -106,
        INVALID_ARGUMENT                    = -107,
        ILLEGAL_INSTRUCTION                 = -108,
        INVALID_OPERAND                     = -109,
        INVALID_OPERAND_SIZE                = -110,
        OPERAND_SIZE_NOT_SPECIFIED          = -111,
        OPERAND_SIZES_DO_NOT_MATCH          = -112,
        INVALID_ADDRESS_SIZE                = -113,
        ADDRESS_SIZES_DO_NOT_AGREE          = -114,
        DISALLOWED_COMBINATION_OF_REGISTERS = -115,
        LONG_IMMEDIATE_NOT_ENCODABLE        = -116,
        RELATIVE_JUMP_OUT_OF_RANGE          = -117,
        INVALID_EXPRESSION                  = -118,
        INVALID_ADDRESS                     = -119,
        INVALID_VALUE                       = -120,
        VALUE_OUT_OF_RANGE                  = -121,
        UNDEFINED_SYMBOL                    = -122,
        INVALID_USE_OF_SYMBOL               = -123,
        NAME_TOO_LONG                       = -124,
        INVALID_NAME                        = -125,
        RESERVED_WORD_USED_AS_SYMBOL        = -126,
        SYMBOL_ALREADY_DEFINED              = -127,
        MISSING_END_QUOTE                   = -128,
        MISSING_END_DIRECTIVE               = -129,
        UNEXPECTED_INSTRUCTION              = -130,
        EXTRA_CHARACTERS_ON_LINE            = -131,
        SECTION_NOT_ALIGNED_ENOUGH          = -132,
        SETTING_ALREADY_SPECIFIED           = -133,
        DATA_ALREADY_DEFINED                = -134,
        TOO_MANY_REPEATS                    = -135,
        SYMBOL_OUT_OF_SCOPE                 = -136,
        USER_ERROR                          = -140,
        ASSERTION_FAILED                    = -141,
    }
}