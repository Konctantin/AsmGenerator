using System.Runtime.InteropServices;

namespace MemoryModule.FASM
{
    public class Internals
    {
        [DllImport("FASM.DLL", SetLastError = true)]
        public static extern int fasm_GetVersion();

        [DllImport("FASM.DLL", SetLastError = true)]
        public static extern unsafe int fasm_Assemble([In]string lpSource, byte[] lpMemory, [In]int cbMemorySize, [In]int nPassesLimit, [In]int hDisplayPipe);
    }
}