using WasmNet.Data;

namespace WasmNet.Nodes {
    public class IfNode : ExecutableNode {

        private BlockNode _then;
        private BlockNode _else;

        public ExecutableNode Condition { get; }

        public IfNode(ExecutableNode condition, WasmType signature) {
            if (condition.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 condition");
            Condition = condition;
            Signature = signature;
        }

        public WasmType Signature { get; }

        public override WasmType ResultType => Signature;

        public BlockNode Then {
            get {
                return _then;
            }
            set {
                if ((value != null ? value.ResultType : WasmType.BlockType) != Signature) throw new WasmNodeException($"cannot assign {value.ResultType} then block to {Signature} if block");
                _then = value;
            }
        }

        public BlockNode Else {
            get {
                return _else;
            }
            set {
                if ((value != null ? value.ResultType : WasmType.BlockType) != Signature) throw new WasmNodeException($"cannot assign {value.ResultType} else block to {Signature} if block");
                _else = value;
            }
        }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(if {ConvertType(Signature)}");
            writer.Indent();
            Condition.ToString(writer);
            Then.ToString(writer);
            Else?.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
