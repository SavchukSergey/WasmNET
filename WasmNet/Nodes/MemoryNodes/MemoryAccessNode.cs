using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryAccessNode : ExecutableNode {

        public WasmMemoryImmediate Immediate { get;  }

        public ExecutableNode Address { get;  }

        protected MemoryAccessNode(WasmMemoryImmediate immediate, ExecutableNode address) {
            if (address.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 address");

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
