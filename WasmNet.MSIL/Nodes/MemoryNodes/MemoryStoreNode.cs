using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryStoreNode : MemoryAccessNode {

        public ExecutableNode Value { get; }

        protected MemoryStoreNode(WasmMemoryImmediate immediate, ExecutableNode address, ExecutableNode value) : base(immediate, address) {
            if (value.ResultType != ValueType) throw new WasmNodeException($"expected {ValueType} value");
            Value = value;
        }

        protected abstract WasmType ValueType { get; }

        public sealed override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode(NodeName);
            writer.Write(FormatImmediate());

            writer.EnsureNewLine();
            Address.ToString(writer);

            writer.EnsureNewLine();
            Value.ToString(writer);

            writer.EnsureNewLine();
            writer.CloseNode();
            writer.EnsureNewLine();
        }

        public override WasmType ResultType => WasmType.BlockType;

    }
}
