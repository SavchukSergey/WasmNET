using WasmNet.Data;

namespace WasmNet.Opcodes {
    public abstract class MemoryAccessOpcode : BaseOpcode {

        public WasmMemoryImmediate Immediate { get; set; }

    }
}
