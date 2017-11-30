using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryStoreNode : MemoryAccessNode {

        public BaseNode Value { get; set; }

        public MemoryStoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address) {
            //todo: move to setters? or readonly? check null
            if (value.ResultType != ValueType) throw new WasmNodeException($"expected {ValueType} value");
            Value = value;
        }

        protected abstract WasmType ValueType { get; }

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
