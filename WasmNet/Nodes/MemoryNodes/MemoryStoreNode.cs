using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryStoreNode : MemoryAccessNode {

        public BaseNode Value { get; set; }

        public MemoryStoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address) {
            Value = Value;
        }

        public sealed override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}{FormatImmediate()}");
            writer.Indent();
            Address?.ToSExpressionString(writer);
            Value?.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        public override WasmType ResultType => WasmType.BlockType;

    }
}
