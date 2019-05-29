using WasmNet.Data;

namespace WasmNet.Opcodes {
    public abstract class MemoryAccessOpcode : BaseOpcode {

        protected MemoryAccessOpcode(WasmMemoryImmediate immediate) {
            Immediate = immediate;
        }

        public WasmMemoryImmediate Immediate { get; }

    }
}
