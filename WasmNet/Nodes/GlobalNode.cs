using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GlobalNode : BaseNode {

        public string Name { get; set; }

        public WasmType  Type { get; set; }

        public bool Mutable { get; set; }

        public BlockNode Init { get; set; }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"(global ${Name} ({(Mutable ? "mut " : "")}{ConvertValueType(Type)})");
            if (Init != null) {
                writer.EndLine();
                writer.Indent();
                Init.ToSExpressionString(writer);
                writer.Unindent();
                writer.WriteLine(")");
            } else {
                writer.Write(")");
                writer.EndLine();
            }
        }

    }
}
