using WasmNet.Data;

namespace WasmNet.Nodes {
    public class IfNode : ExecutableNode {

        private NodesList _then;
        private NodesList _else;

        public ExecutableNode Condition { get; }

        public IfNode(ExecutableNode condition, WasmType signature) {
            if (condition.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 condition");
            Condition = condition;
            Signature = signature;
        }

        public WasmType Signature { get; }

        public override WasmType ResultType => Signature;

        public NodesList Then {
            get {
                return _then;
            }
            set {
                if ((value != null ? value.Signature : WasmType.BlockType) != Signature) throw new WasmNodeException($"cannot assign {value.Signature} then block to {Signature} if block");
                _then = value;
            }
        }

        public NodesList Else {
            get {
                return _else;
            }
            set {
                if ((value != null ? value.Signature : WasmType.BlockType) != Signature) throw new WasmNodeException($"cannot assign {value.Signature} else block to {Signature} if block");
                _else = value;
            }
        }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("if");

            if (!string.IsNullOrWhiteSpace(_then.Label.Name)) {
                writer.EnsureSpace();
                writer.Write($"${_then.Label.Name}");
            }

            writer.EnsureSpace();
            writer.Write($"{ConvertType(Signature)}");

            writer.EnsureNewLine();
            Condition.ToString(writer);

            writer.EnsureNewLine();
            Then.ToString(writer);
            writer.EnsureNewLine();

            if (Else != null) {
                //todo: else's label
                new ElseNode(_else).ToString(writer);
                writer.EnsureNewLine();
            }

            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
