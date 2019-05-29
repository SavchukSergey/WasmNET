using WasmNet.Data;

namespace WasmNet.Opcodes {
    public abstract class MemoryStoreOpcode : MemoryAccessOpcode {

        protected MemoryStoreOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

    }
}
