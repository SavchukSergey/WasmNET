using WasmNet.Data;

namespace WasmNet.Nodes {
    public class LocalNode : DeclarationNode {

        public string Name { get; set; }

        public WasmType Type { get; private set; }

        public LocalNode(WasmType type) {
            AssertValueType(type);
            Type = type;
        }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(local ${Name} {ConvertValueType(Type)})");
        }

    }
}
