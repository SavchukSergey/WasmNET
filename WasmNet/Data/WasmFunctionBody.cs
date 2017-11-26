using System.Collections.Generic;
using WasmNet.Opcodes;

namespace WasmNet.Data {
    public class WasmFunctionBody {

        public IList<WasmLocalEntry> Locals { get; } = new List<WasmLocalEntry>();

        public IList<BaseOpcode> Opcodes { get; } = new List<BaseOpcode>();

    }
}
