using WasmNet.Data;

namespace WasmNet.Nodes {
    public class FunctionNode : BaseNode {

        public string Name { get; set; }

        public WasmFunctionSignature Signature { get; set; }

        public BlockNode Execution { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"{Convert(Signature.Return)} {Name}(");
            for (var i = 0; i < Signature.Parameters.Count; i++) {
                if (i != 0) {
                    writer.Write(", ");
                }
                writer.Write(Convert(Signature.Parameters[i]));
                writer.Write($" arg{i}");
            }
            writer.Write(") {");
            writer.EndLine();
            writer.Indent();
            Execution.ToString(writer);
            writer.Unindent();
            writer.StartLine();
            writer.Write("}");
            writer.EndLine();
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"(func ${Name}");
            for (var i = 0; i < Signature.Parameters.Count; i++) {
                writer.Write($" (param $arg{i} {ConvertSExpression(Signature.Parameters[i])})");
            }
            if (Signature.Return != null) {
                writer.Write($" (result {ConvertSExpression(Signature.Return)})");
            }
            writer.EndLine();
            writer.Indent();
            Execution.ToSExpressionString(writer);
            writer.Unindent();
            writer.StartLine();
            writer.Write(")");
            writer.EndLine();
        }

        private static string Convert(WasmType? type) {
            switch (type) {
                case null: return "void";
                case WasmType.BlockType: return "void";
                case WasmType.I32: return "int";
                case WasmType.I64: return "long";
                case WasmType.F32: return "float";
                case WasmType.F64: return "double";
                default:
                    throw new WasmNodeException($"unknown type {type}");
            }
        }

        private static string ConvertSExpression(WasmType? type) {
            switch (type) {
                case WasmType.I32: return "i32";
                case WasmType.I64: return "i64";
                case WasmType.F32: return "f32";
                case WasmType.F64: return "f64";
                default:
                    throw new WasmNodeException($"unknown type {type}");
            }
        }

    }
}
