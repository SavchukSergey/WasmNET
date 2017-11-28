using WasmNet.Data;

namespace WasmNet.Nodes {
    public class IfNode : BaseNode {

        private BlockNode _then;
        private BlockNode _else;

        public IfNode(BaseNode condition, WasmType signature) {
            Condition = condition;
            Signature = signature;
        }

        public WasmType Signature { get; }

        public override WasmType ResultType => Signature;

        public BaseNode Condition { get; set; }

        public BlockNode Then {
            get {
                return _then;
            }
            set {
                if ((value != null ? value.Signature : WasmType.BlockType) != Signature) throw new WasmNodeException($"cannot assign {value.Signature} then block to {Signature} if block");
                _then = value;
            }
        }

        public BlockNode Else {
            get {
                return _else;
            }
            set {
                if ((value != null ? value.Signature : WasmType.BlockType) != Signature) throw new WasmNodeException($"cannot assign {value.Signature} else block to {Signature} if block");
                _else = value;
            }
        }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"if ({Condition}) {{");

            writer.Indent();
            if (Then != null) {
                Then.ToString(writer);
            }
            writer.Unindent();

            if (Else != null) {
                writer.WriteLine("} else {");
                writer.Indent();
                Else.ToString(writer);
                writer.Unindent();
                writer.WriteLine("}");
            } else {
                writer.WriteLine("}");
            }
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(if {ConvertType(Signature)}");
            writer.Indent();
            Condition.ToSExpressionString(writer);
            Then.ToSExpressionString(writer);
            Else?.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
