using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmTypeSection {

        public IList<WasmFunctionSignature> Entries { get; } = new List<WasmFunctionSignature>();

    }
}
