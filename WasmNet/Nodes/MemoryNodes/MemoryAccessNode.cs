using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryAccessNode : BaseNode {

        public WasmMemoryImmediate Immediate { get; set; }

        public BaseNode Address { get; set; }

        public MemoryAccessNode(WasmMemoryImmediate immediate, BaseNode address) {
            Immediate = immediate;
            Address = address;
        }

        protected string FormatImmediate() {
            if (Immediate.Offset != 0) {
                return $" offset={Immediate.Offset}";
            }
            return "";
        }

        protected abstract string NodeName { get; }

    }
}
