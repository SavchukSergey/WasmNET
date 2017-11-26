using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmCodeSection {

        public IList<WasmFunctionBody> Bodies { get; } = new List<WasmFunctionBody>();

    }
}
