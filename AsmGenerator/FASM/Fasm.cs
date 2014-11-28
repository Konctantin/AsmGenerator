using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MemoryModule.FASM
{
    public class Fasm
    {        /// <summary>
        ///
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static unsafe byte[] Assemble(string source)
        {
            var passesLimit = 0x100;
            Debug.WriteLine("AsmSource:\n" + source);

            var tbuffer = new byte[source.Length * passesLimit];
            Internals.fasm_Assemble(source, tbuffer, tbuffer.Length, passesLimit, 0);

            fixed (byte* pointer = tbuffer)
            {
                var fasm_result = *(FASM.FasmState*)pointer;

                if (fasm_result.condition == FASM.FasmCondition.ERROR)
                    throw new Exception(string.Format("Fasm Syntax Error: {0}, at line {1}",
                        fasm_result.error_code, fasm_result.error_data->line_number-1));

                if (fasm_result.condition != FASM.FasmCondition.OK && fasm_result.condition != FASM.FasmCondition.ERROR)
                    throw new Exception(string.Format("Fasm Error: {0}", fasm_result.condition));

                var buffer = new byte[fasm_result.output_lenght];
                Marshal.Copy(new IntPtr(fasm_result.output_data), buffer, 0, fasm_result.output_lenght);
                Debug.WriteLine("ByteCode:\n" + string.Join(" ", buffer.Select(n => n.ToString("X2"))));
                return buffer;
            }
        }
    }
}
