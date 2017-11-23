using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmCodeSection {

        public IList<WasmFunctionBody> Bodies { get; } = new List<WasmFunctionBody>();

    }
}
