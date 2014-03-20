using System.Runtime.InteropServices;

namespace MemoryModule.FASM
{
    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct FasmState
    {
        [FieldOffset(0)]
        public FasmCondition condition;

        [FieldOffset(4)]
        public FasmError error_code;

        [FieldOffset(4)]
        public int output_lenght;

        [FieldOffset(8)]
        public byte* output_data;

        [FieldOffset(8)]
        public FasmLineHeader* error_data;
    };
}