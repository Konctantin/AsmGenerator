using System.Runtime.InteropServices;

namespace MemoryModule.FASM
{
    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct FasmLineHeader
    {
        [FieldOffset(0)]
        public sbyte* file_path;

        [FieldOffset(4)]
        public int line_number;

        [FieldOffset(8)]
        public int file_offset;

        [FieldOffset(8)]
        public int macro_offset_line;

        [FieldOffset(12)]
        public FasmLineHeader* macro_line;

        public string FilePath
        {
            get { return new string(file_path); }
        }
    };
}