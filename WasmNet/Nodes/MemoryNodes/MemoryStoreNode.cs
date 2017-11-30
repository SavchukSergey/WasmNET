using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryStoreNode : MemoryAccessNode {

        public ExecutableNode Value { get; }

        public MemoryStoreNode(WasmMemoryImmediate immediate, ExecutableNode address, ExecutableNode value) : base(immediate, address) {
            if (value.ResultType != ValueType) throw new WasmNodeException($"expected {ValueType} value");
            Value = value;
        }

        protected abstract WasmType ValueType { get; }

        public sealed override void ToString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}{FormatImmediate()}");
            writer.Indent();
            Address?.ToString(writer);
            Value?.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        public override WasmType ResultType => WasmType.BlockType;

    }
}
