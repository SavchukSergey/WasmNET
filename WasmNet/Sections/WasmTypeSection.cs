using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmTypeSection {

        public IList<WasmFunctionSignature> Entries { get; } = new List<WasmFunctionSignature>();

    }
}
