using System;
using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmTypeSection {

        public WasmTypeSection(IReadOnlyList<WasmFunctionSignature> signatures) {
            if (signatures == null) {
                throw new ArgumentNullException(nameof(signatures));
            }
            Entries = signatures;
        }

        public IReadOnlyList<WasmFunctionSignature> Entries { get; }

    }
}
