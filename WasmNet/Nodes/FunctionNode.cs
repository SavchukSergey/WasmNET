using WasmNet.Data;

namespace WasmNet.Nodes {
    public class FunctionNode {

        public string Name { get; set; }

        public WasmFunctionSignature Signature { get; set; }

        public BlockNode Execution { get; set; }

        public void ToString(NodeWriter writer) {
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

    }
}
