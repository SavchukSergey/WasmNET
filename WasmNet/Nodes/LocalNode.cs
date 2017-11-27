using WasmNet.Data;

namespace WasmNet.Nodes {
    public class LocalNode : BaseNode {

        public string Name { get; set; }

        public WasmType Type { get; set; }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(local ${Name} {ConvertValueType(Type)})");
        }

    }
}
